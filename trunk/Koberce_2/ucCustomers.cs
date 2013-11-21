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
    public partial class ucCustomers : UserControl
    {

        CustomerEntity current;

        public ucCustomers()
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
            gridSuppliers.DataSource = null;
            var data = CustomerEntity.LoadAll();
            gridSuppliers.DataSource = data;

            ReloadCustomerTypes();
        }

        private void ReloadCustomerTypes()
        {
            cbCustomerTypes.DataSource = null;
            cbCustomerTypes.DataSource = CustomerEntity.CustomerTypes;
        }

        private void NewItem()
        {
            current = CustomerEntity.Empty;
            ShowItem(current);
        }

        private void ShowItem(CustomerEntity ent)
        {
            lblId.Text = ent.Id.HasValue ? ent.Id.Value.ToString() : string.Empty;
            txtName.Text = ent.Name;
            txtAddress.Text = ent.Address;
            txtAddress2.Text = ent.Address2;
            txtPhone.Text = ent.Phone;
            txtEmail.Text = ent.Email;
            cbCustomerTypes.SelectedIndex = (int)(ent.DCustomerType ?? 0);
            txtComment.Text = ent.Comment;
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
            var ns = cbCustomerTypes.SelectedItem as CustomerEntity.CCustomerType;
            if (ns != null)
                current.DCustomerType = ns.id;
            else
                current.DCustomerType = null;

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
                current = CustomerEntity.Empty;
            else
                current = gridSuppliers.Rows[e.RowIndex].DataBoundItem as CustomerEntity;

            ShowItem(current);
        }
    }
}
