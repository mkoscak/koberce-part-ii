using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koberce_2.Filters
{
    public class FilterItem
    {
        public string ColumnName { get; set; }
        public FilterItemType Type { get; set; }
        public Control Control { get; set; }

        public FilterItem(string colName, FilterItemType type)
        {
            ColumnName = colName;
            Type = type;
        }

        public string FormatSQL()
        {
            var value = Control.Text;
            if (Type == FilterItemType.BOOLEAN)
                value = (Control as CheckBox).Checked ? "1" : "0";

            return GetFilter(value, ColumnName);
        }

        private string GetFilter(string text, string columnName)
        {
            string ret = string.Empty;

            if (text != null && text.Trim().Length > 0)
            {
                string op = " like ";
                string neg = "";
                string perc = @"%";
                string quotes = "\"";

                if (text.Contains('!'))
                {
                    neg = " not ";
                    text = text.Replace("!", "");
                }
                else if (text.Contains('>'))
                {
                    op = " > ";
                    text = text.Replace(">", "");
                    if (text.Contains('='))
                        op = " >= ";
                    text = text.Replace("=", "");
                    perc = "";
                    quotes = "";

                    int ival;
                    if (!int.TryParse(text.Trim(), out ival))
                        return ret;

                    columnName = string.Format("CAST({0} as real)", columnName);
                }
                else if (text.Contains('<'))
                {
                    op = " < ";
                    text = text.Replace("<", "");
                    if (text.Contains('='))
                        op = " <= ";
                    text = text.Replace("=", "");
                    perc = "";
                    quotes = "";

                    int ival;
                    if (!int.TryParse(text.Trim(), out ival))
                        return ret;

                    columnName = string.Format("CAST({0} as real)", columnName);
                }

                if (text.Trim().Length == 0)
                    return ret;

                ret = string.Format(" {0} {1} {2} {5}{4}{3}{4}{5} ", columnName, neg, op, text, perc, quotes);
            }

            return ret;
        }
    }
}
