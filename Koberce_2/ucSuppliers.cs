using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koberce_2.Entities;

namespace Koberce_2
{
    public partial class ucSuppliers : UserControl, IGridHolder
    {
        SupplierEntity current;
        List<NumberSerieEntity> allSeries;
            
        public ucSuppliers()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(btnReload, "Reload");

            try
            {
                ReloadAllData();
            }
            catch (Exception)
            {
            }
            NewItem();
        }

        private void ReloadAllData()
        {
            ReloadNumSeries();

            gridSuppliers.DataSource = null;
            var data = SupplierEntity.LoadAll();
            gridSuppliers.DataSource = data;
        }

        private void ReloadNumSeries()
        {
            cbNumberSerie.DataSource = null;
            allSeries = NumberSerieEntity.LoadAll();
            cbNumberSerie.DataSource = allSeries;
        }

        private void NewItem()
        {
            current = SupplierEntity.Empty;
            ShowItem(current);
        }

        private void ShowItem(SupplierEntity ent)
        {
            lblId.Text = ent.Id.HasValue ? ent.Id.Value.ToString() : string.Empty;
            txtName.Text = ent.Name;
            txtAddress.Text = ent.Address;
            txtAddress2.Text = ent.Address2;
            txtPhone.Text = ent.Phone;
            txtEmail.Text = ent.Email;
            txtComment.Text = ent.Comment;
            var found = allSeries.Where(s => s.Id == ent.NrSerieId).FirstOrDefault();
            if (found != null)
                cbNumberSerie.Text = found.ToString();
        }

        private void LoadCurrent()
        {
            current.Id = null;
            if (!string.IsNullOrEmpty(lblId.Text))
                current.Id = long.Parse(lblId.Text);

            current.Name = txtName.Text;
            current.Address = txtAddress.Text;
            current.Address2 = txtAddress2.Text;
            current.Phone = txtPhone.Text;
            current.Email = txtEmail.Text;
            var ns = cbNumberSerie.SelectedItem as NumberSerieEntity;
            if (ns != null)
                current.NrSerieId = ns.Id;
            else
                throw new Exception("Number serie is mandatory item!");

            current.Comment = txtComment.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadAllData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Save unsuccessful: " + ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCurrent()
        {
            LoadCurrent();
            current.Save();

            MessageBox.Show(this, "Save successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadCurrent();
            current.Delete();

            MessageBox.Show(this, "Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
        }

        private void gridSuppliers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridSuppliers.SelectedCells == null || gridSuppliers.SelectedCells.Count == 0)
                current = SupplierEntity.Empty;
            else
                current = gridSuppliers.Rows[e.RowIndex].DataBoundItem as SupplierEntity;

            ShowItem(current);
        }

        #region IGridHolder Members

        public DoubleBufferedGrid GetDataGrid()
        {
            return gridSuppliers;
        }

        #endregion
    }
}
