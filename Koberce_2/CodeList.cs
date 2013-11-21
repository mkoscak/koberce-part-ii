using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2
{
    /// <summary>
    /// Help class as codelist
    /// </summary>
    public class CodeList
    {
        public long id;
        public string name;

        public CodeList(long id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
