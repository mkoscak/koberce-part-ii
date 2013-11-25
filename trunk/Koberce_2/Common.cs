using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

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
    }
}
