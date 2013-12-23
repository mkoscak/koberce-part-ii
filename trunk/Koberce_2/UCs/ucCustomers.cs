using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Koberce_2.Entities;
using Koberce_2.Filters;

namespace Koberce_2.UCs
{
    public partial class ucCustomers : UserControl, IGridHolder, IFilterProvider
    {
        CustomerEntity current;
        FilterPanel filter;

        public ucCustomers()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(btnReload, "Reload");

            filter = new FilterPanel(this, FilterChanged);
            filter.AddFilter(FilterItemType.NUMBER, "ID", "Id");
            filter.AddFilter(FilterItemType.BOOLEAN, "VALID", "Only valid");
            filter.AddFilter(FilterItemType.TEXT, "COMMENT", "Comment");

            filter.AddFilter(FilterItemType.TEXT, "NAME", "Name");
            filter.AddFilter(FilterItemType.TEXT, "ADDRESS", "Address");
            filter.AddFilter(FilterItemType.TEXT, "ADDRESS2", "Address2");
            filter.AddFilter(FilterItemType.TEXT, "PHONE", "Phone");
            filter.AddFilter(FilterItemType.TEXT, "EMAIL", "E-mail");

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
            ReloadCustomerTypes();

            gridCustomers.DataSource = null;
            var data = CustomerEntity.Load(filter.GetSQL(" AND "), null);
            gridCustomers.DataSource = data;
            Common.PresenterInst.ShowStatus(data.Count.ToString() + " customers loaded!");
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
            if (cbCustomerTypes.Items.Count > 0)
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
            var ns = cbCustomerTypes.SelectedItem as CodeList;
            if (ns != null)
                current.DCustomerType = ns.id;
            else
                throw new Exception("Customer type is mandatory item!");

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
                MessageBox.Show(this, "Unable to load current customer! " + ex, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gridCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCustomers.SelectedCells == null || gridCustomers.SelectedCells.Count == 0)
                current = CustomerEntity.Empty;
            else
                current = gridCustomers.Rows[gridCustomers.SelectedCells[0].RowIndex].DataBoundItem as CustomerEntity;

            ShowItem(current);
        }

        #region IGridHolder Members

        public DoubleBufferedGrid GetDataGrid()
        {
            return gridCustomers;
        }

        public bool ContainsEntities(Type ofType)
        {
            return ofType == typeof(CustomerEntity);
        }

        public bool FindEntity(long id)
        {
            return Common.FindEntityInGrid<CustomerEntity>(GetDataGrid(), id);
        }

        public UserControl GetControl()
        {
            return this;
        }

        #endregion

        #region IFilterProvider Members

        public Koberce_2.Filters.FilterPanel GetFilterPanel()
        {
            return filter;
        }

        public void FilterChanged(object sender, EventArgs e)
        {
            ReloadAllData();
        }

        #endregion
    }
}
