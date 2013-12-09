using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koberce_2
{
    interface IGridHolder
    {
        DoubleBufferedGrid GetDataGrid();
        bool ContainsEntities(Type ofType);
        bool FindEntity(long id);
        UserControl GetControl();
    }
}
