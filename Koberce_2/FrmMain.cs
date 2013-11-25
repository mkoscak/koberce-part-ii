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
            TabAddNew("Suppliers", new ucSuppliers());
            TabAddNew("Customers", new ucCustomers());
            TabAddNew("Storages", new ucStorages());
            TabAddNew("Number series", new ucNumberSeries());
            TabAddNew("Database helper", new ucDBHelper());

            // TODO read exchange rates from net..
            toolExRateCzk.Text = Common.CleanPrice(toolExRateCzk.Text);
        }

        private void toolDbHelper_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucDBHelper(), (sender as ToolStripButton).Image);
        }

        private void toolNrSeries_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucNumberSeries(), (sender as ToolStripButton).Image);
        }

        private void toolSuppliers_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucSuppliers(), (sender as ToolStripButton).Image);
        }

        private void toolCustomers_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucCustomers(), (sender as ToolStripButton).Image);
        }

        private void toolStorages_Click(object sender, EventArgs e)
        {
            ShowForm((sender as ToolStripItem).Text, new ucStorages(), (sender as ToolStripButton).Image);
        }

        /// <summary>
        /// Pridanie tabu s usercontrolom
        /// </summary>
        /// <returns></returns>
        private void TabAddNew(string title, Control uc)
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
        private void ShowForm(string title, Control uc, Image i)
        {
            Form frm = new Form();
            frm.Text = title;
            frm.Controls.Add(uc);
            frm.Icon = this.Icon;
            frm.Size = uc.Size;
            frm.KeyPreview = true;
            frm.KeyDown += new KeyEventHandler(frm_KeyDown);
            
            uc.Size = uc.Parent.ClientSize;
            uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            Bitmap bitmap = new Bitmap(i);
            var c = System.Drawing.Icon.FromHandle(bitmap.GetHicon());

            frm.Icon = c;
            frm.Show(this);
        }

        void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                (sender as Form).Close();
        }

        private void btnToolExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            e.Cancel = (MessageBox.Show(this, "Do you really want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No);
#endif
        }

        #region IPresenter Members

        public void ShowStatus(string status)
        {
            statusLabel1.Text = status;
        }

        #endregion
    }
}
