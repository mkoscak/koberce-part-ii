using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2
{
    class Common
    {
        public static string NullableLong(long? l)
        {
            return l.HasValue ? l.Value.ToString() : "null";
        }
    }
}
