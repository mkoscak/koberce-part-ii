using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Drawing;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml.Style;
using Koberce_2.Entities;

namespace Koberce_2
{
    public static class Common
    {
        public static IPresenter PresenterInst
        {
            get;
            set;
        }
     
        public static string NullableLong(long? l)
        {
            return l.HasValue ? l.Value.ToString() : "null";
        }

        public static double GetPrice(string strPrice)
        {
            if (strPrice == null)
                return double.NaN;

            var tmp = CleanPrice(strPrice);

            double ret = double.NaN;
            try
            {
                ret = double.Parse(tmp);
            }
            catch (Exception)
            {
            }

            return ret;
        }

        public static string CleanPrice(string strPrice)
        {
            // cena obsahuje aj bodku aj ciarku, napr 1,000.25.. prvy znak vyhodime
            if (strPrice.Contains(',') && strPrice.Contains('.'))
            {
                int pointIndex = strPrice.LastIndexOf('.');
                int commaIndex = strPrice.LastIndexOf(',');

                if (pointIndex > commaIndex)
                    strPrice = strPrice.Replace(",", "");   // odstranime vsetky ciarky
                else
                    strPrice = strPrice.Replace(".", "");   // odstranime vsetky bodky
            }

            strPrice = new string(strPrice.ToCharArray().Where(c => Char.IsDigit(c) || c == ',' || c == '.' || c == '-').ToArray()).Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator).Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            return strPrice;
        }

        /// <summary>
        /// Nacitanie obrazku z disku/uloziska
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        internal static Image LoadImageFromStore(string fileName)
        {
            Image ret = null;

            string path = @".\Picture_Store\";
            try
            {
                ret = Image.FromFile(path + fileName);
                PresenterInst.ShowStatus(string.Format("Preview image '{0}' loaded!", fileName));
            }
            catch (Exception ex)
            {
                PresenterInst.ShowStatus(string.Format("Error during reading image '{0}': {1}", fileName, ex.Message));
            }

            return ret;
        }

        internal static void ExportExcel(string name, DoubleBufferedGrid grid)
        {
            string fName = GetFileName(name);
            if (fName == null)
                return;

            try
            {
                DoExport(fName, grid);

                MessageBox.Show(null, "Export finished!", "Excel export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                PresenterInst.ShowStatus(string.Format("Error during export: {0}", ex.Message));
            }
        }

        private static void DoExport(string fName, DoubleBufferedGrid grid)
        {
            ExcelPackage ep = new ExcelPackage();
            var ws = ep.Workbook.Worksheets.Add("Exported data");

            // hlavicka
            var col = 1;
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                // len zobrazene stlpce
                if (!grid.Columns[i].Visible)
                    continue;

                ws.Cells[1, col].Value = grid.Columns[i].HeaderText;
                ws.Cells[1, col].Style.Font.Bold = true;
                ws.Cells[1, col].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                ws.Cells[1, col].Style.Fill.BackgroundColor.SetColor(Color.GreenYellow);
                ws.Cells[1, col].Style.Border.BorderAround(ExcelBorderStyle.Medium, Color.DarkGray);
                ws.Column(col).Width = 17;

                var row = 2;
                for (int j = 0; j < grid.Rows.Count; j++)
                {
                    var obj = grid[i, j].Value;
                    // farbicky pre parne riadky
                    if (obj != null)
                    {
                        var dp = GetPrice(obj.ToString());
                        if (!double.IsNaN(dp))
                            ws.Cells[row, col].Value = dp;
                        else
                            ws.Cells[row, col].Value = obj.ToString();
                }

                    if (row % 2 == 1)
                    {
                        ws.Cells[row, col].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ws.Cells[row, col].Style.Fill.BackgroundColor.SetColor(Color.LemonChiffon);
                    }
                    ws.Cells[row, col].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    ws.Cells[row, col].Style.Border.Left.Color.SetColor(Color.DarkGray);
                    ws.Cells[row, col].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    ws.Cells[row, col].Style.Border.Right.Color.SetColor(Color.DarkGray);

                    row++;
                }
             
                col++;
            }

            // ulozenie
            ep.SaveAs(new FileInfo(fName));
        }

        private static string GetFileName(string name)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = name.Replace(' ','_') + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx";
            sfd.Filter = "Excel 2007 files|*.xlsx";
            sfd.CheckFileExists = false;
            sfd.InitialDirectory = ".";
            sfd.OverwritePrompt = true;
            sfd.SupportMultiDottedExtensions = true;
            sfd.Title = "Type file name or select existing";
            if (sfd.ShowDialog() == DialogResult.Cancel)
                return null;

            return sfd.FileName;
        }

        public static bool FindEntityInGrid<T>(DoubleBufferedGrid grid, long id)
            where T : BaseEntity<T>, new()
        {
            var ds = grid.DataSource as List<T>;

            grid.ClearSelection();
            for (int i = 0; i < ds.Count; i++)
            {
                if (ds[i].Id == id)
                {
                    grid[0, i].Selected = true;
                    return true;
                }
			}

            return false;
        }

        /// <summary>
        /// Extension metoda na konverziu double cisla na string pre DB operacie
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string ToDBString(this double num)
        {
            return num.ToString().Replace(',', '.');
        }
    }
}
