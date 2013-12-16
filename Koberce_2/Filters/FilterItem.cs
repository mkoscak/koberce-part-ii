using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2.Filters
{
    public enum FilterItemType
    {
        TEXT,
        INTEGER,
        REAL,
        BOOLEAN
    }

    public class FilterItem
    {
        public string ColumnName { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public FilterItemType Type { get; set; }

        public FilterItem(string colName, string op, string value, FilterItemType type)
        {
            ColumnName = colName;
            Operator = op;
            Value = value;
            Type = type;
        }

        public string FormatSQL()
        {
            return string.Format(" {0} {1} {2} ", ColumnName, Operator, GetFormattedValue());
        }

        private string GetFormattedValue()
        {
            string ret = Value;

            switch (Type)
            {
                case FilterItemType.TEXT:
                    if (Operator == Operators.LIKE || Operator == Operators.NOT_LIKE)
                        ret = string.Format("'%{0}%'", ret);
                    break;
                case FilterItemType.INTEGER:
                    break;
                case FilterItemType.REAL:
                    break;
                case FilterItemType.BOOLEAN:
                    break;
                default:
                    break;
            }

            return ret;
        }
    }
}
