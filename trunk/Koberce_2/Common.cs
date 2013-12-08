﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Drawing;
using OfficeOpenXml;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml.Style;

namespace Koberce_2
{
    class Common
    {
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
            }
            catch (Exception)
            {
                // TODO - sttaus bar message
            }

            return ret;
        }

        internal static void ExportExcel(string name, DoubleBufferedGrid grid)
        {
            string fName = GetFileName(name);
            if (fName == null)
                return;

            DoExport(fName, grid);

            MessageBox.Show(null, "Export finished!", "Excel export", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                var row = 2;
                for (int j = 0; j < grid.Rows.Count; j++)
                {
                    var obj = grid[i, j].Value;
                    // farbicky pre parne riadky
                    if (obj != null)
                        ws.Cells[row, col].Value = obj.ToString();

                    if (row % 2 == 1)
                    {
                        ws.Cells[row, col].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        ws.Cells[row, col].Style.Fill.BackgroundColor.SetColor(Color.LemonChiffon);
                    }

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
    }
}
