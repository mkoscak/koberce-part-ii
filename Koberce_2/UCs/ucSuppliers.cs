using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koberce_2.Entities;

namespace Koberce_2.UCs
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
            Common.PresenterInst.ShowStatus(data.Count.ToString() + " suppliers loaded!");
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
            GetCurrentNrSerie();
            if (current.NrSerieId == -1)
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
            Save(false);
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            Save(true);
        }

        private void Save(bool asNew)
        {
            try
            {
                LoadCurrent();

                if (asNew)
                    current.Id = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load current product! " + ex, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                current.Save();
                MessageBox.Show(this, "Save successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Save unsuccessful: " + ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            LoadCurrent();
            current.Delete();

            MessageBox.Show(this, "Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
        }

        private void gridSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSuppliers.SelectedCells == null || gridSuppliers.SelectedCells.Count == 0)
                current = SupplierEntity.Empty;
            else
                current = gridSuppliers.Rows[gridSuppliers.SelectedCells[0].RowIndex].DataBoundItem as SupplierEntity;

            ShowItem(current);
        }

        private void linkNrSerie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetCurrentNrSerie();
            Common.PresenterInst.FindShowEntity(typeof(NumberSerieEntity), current.NrSerieId ?? -1);
        }

        private void GetCurrentNrSerie()
        {
            var se = cbNumberSerie.SelectedItem as NumberSerieEntity;
            if (se != null)
                current.NrSerieId = se.Id ?? -1;
            else
                current.NrSerieId = -1;
        }

        #region IGridHolder Members

        public DoubleBufferedGrid GetDataGrid()
        {
            return gridSuppliers;
        }

        public bool ContainsEntities(Type ofType)
        {
            return ofType == typeof(SupplierEntity);
        }

        public bool FindEntity(long id)
        {
            return Common.FindEntityInGrid<SupplierEntity>(GetDataGrid(), id);
        }

        public UserControl GetControl()
        {
            return this;
        }

        #endregion
    }
}
