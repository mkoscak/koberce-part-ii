using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Koberce_2.Filters;

namespace Koberce_2
{
    interface IFilterProvider
    {
        FilterPanel GetFilterPanel();
        void FilterChanged(object sender, EventArgs e);
    }
}
