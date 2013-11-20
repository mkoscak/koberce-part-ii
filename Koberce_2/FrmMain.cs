using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Koberce_2
{
    public partial class FrmMain : Form, IPresenter
    {
        Model model;

        public FrmMain()
        {
            InitializeComponent();

            model = new Model(this);

            tabMain.TabPages.Clear();
            TabAddDbHelper("Suppliers", new ucSuppliers());
            TabAddDbHelper("Number series", new ucNumberSeries());
            TabAddDbHelper("Database helper", new ucDBHelper());
        }

        private void toolDbHelper_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucDBHelper());
        }

        private void toolNrSeries_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucNumberSeries());
        }

        private void toolSuppliers_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucSuppliers());
        }

        /// <summary>
        /// Pridanie tabu s usercontrolom
        /// </summary>
        /// <returns></returns>
        private void TabAddDbHelper(string title, Control uc)
        {
            var newTab = new TabPage(title);
            tabMain.TabPages.Add(newTab);
            newTab.Controls.Add(uc);
            uc.Size = uc.Parent.ClientSize;
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
        }

        /// <summary>
        /// Zobrazi formular s uzivatelskym UC
        /// </summary>
        /// <param name="title"></param>
        /// <param name="uc"></param>
        private void ShowForm(string title, Control uc)
        {
            Form frm = new Form();
            frm.Text = title;
            frm.Controls.Add(uc);
            frm.Icon = this.Icon;
            frm.Size = uc.Size;
            uc.Size = uc.Parent.ClientSize;
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            frm.Show(this);
        }

        private void btnToolExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show(this, "Do you really want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
        }

        #region IPresenter Members

        public void ShowStatus(string status)
        {
            statusLabel1.Text = status;
        }

        #endregion
    }
}
