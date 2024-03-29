﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koberce_2.UCs
{
    public partial class ucDBHelper : UserControl, IGridHolder
    {
        public ucDBHelper()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNonQueryRes.Clear();
            txtQuery.Clear();
        }

        private void btnExecQuery_Click(object sender, EventArgs e)
        {
            var q = txtQuery.SelectedText;
            try
            {
                var ds = DBProvider.Instance.ExecuteQuery(q);
                if (ds != null && ds.Tables.Count > 0)
                    gridDBres.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                txtNonQueryRes.AppendText(Environment.NewLine + ex.ToString());
            }
        }

        private void btnExecNonQuery_Click(object sender, EventArgs e)
        {
            var q = txtQuery.SelectedText;
            try
            {
                DBProvider.Instance.ExecuteNonQuery(q);
                txtNonQueryRes.AppendText(Environment.NewLine + "Exec successful!");
            }
            catch (Exception ex)
            {
                txtNonQueryRes.AppendText(Environment.NewLine + ex.ToString());
            }
        }

        #region IGridHolder Members

        public DoubleBufferedGrid GetDataGrid()
        {
            return gridDBres;
        }

        public bool ContainsEntities(Type ofType)
        {
            return false;
        }

        public bool FindEntity(long id)
        {
            return false;
        }

        public UserControl GetControl()
        {
            return this;
        }

        #endregion
    }
}
