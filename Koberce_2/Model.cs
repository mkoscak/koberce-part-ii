using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2
{
    public class Model
    {
        IPresenter presenter;

        public Model(IPresenter p)
        {
            presenter = p;

            presenter.ShowStatus("DBProvider successfully created with data source : " + DBProvider.DataSource);
        }
    }
}
