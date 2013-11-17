using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Koberce_2
{
    public class Model
    {
        public DBProvider dbProvider
        {
            get;
            private set;
        }

        IPresenter presenter;

        public Model(IPresenter p)
        {
            presenter = p;

            dbProvider = new DBProvider();
            presenter.ShowStatus("DBProvider successfully created with data source : " + DBProvider.DataSource);
        }
    }
}
