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
    public partial class ucProducts : UserControl, IGridHolder
    {
        ProductEntity current;
        List<SupplierEntity> suppliers;

        public ucProducts()
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
            ReloadSuppliers();

            gridProducts.DataSource = null;
            var data = ProductEntity.LoadAll();
            gridProducts.DataSource = data;

            Common.PresenterInst.ShowStatus(data.Count.ToString() + " products loaded!");
        }

        private void ReloadSuppliers()
        {
            cbSuppliers.DataSource = null;
            suppliers = SupplierEntity.LoadAll();
            cbSuppliers.DataSource = suppliers;
        }

        private void NewItem()
        {
            current = ProductEntity.Empty;
            ShowItem(current);
        }

        private void ShowItem(ProductEntity ent)
        {
            Cursor = Cursors.WaitCursor;
            lblId.Text = ent.Id.HasValue ? ent.Id.Value.ToString() : string.Empty;
            txtProductNr.Text = ent.ProductNr;
            txtDescription.Text = ent.Description;
            txtHochflor.Text = ent.Hochflor.ToString();
            txtKnots.Text = ent.Knots.ToString();
            txtWeight.Text = ent.Weight.ToString();
            txtBuyPrice.Text = ent.BuyPrice.ToString();
            txtColor.Text = ent.Color.ToString();
            txtMaterial.Text = ent.Material.ToString();
            txtMatInside.Text = ent.MaterialInside.ToString();
            txtForm.Text = ent.Form.ToString();
            cbSuppliers.Text = string.Empty;
            txtComment.Text = ent.Comment;
            var found = suppliers.Where(s => s.Id == ent.SupplierId).FirstOrDefault();
            if (found != null)
            {
                cbSuppliers.Text = found.ToString();
                // preview image
                NumberSerieEntity nse = new NumberSerieEntity();
                nse.Load(found.NrSerieId ?? -1);
                picPreview.Image = Common.LoadImageFromStore(nse.Prefix + "-1.jpg");
                RotatePreviewIfNeeded();
            }

            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Otaca obrazok podla potreby na vysku/sirku
        /// </summary>
        private void RotatePreviewIfNeeded()
        {
            if (picPreview.Image == null)
                return;

            bool windowHorizontal = picPreview.Width > picPreview.Height;
            bool picHorizontal = picPreview.Image.Width > picPreview.Image.Height;

            // no need to do anything
            if ((windowHorizontal && picHorizontal) || (!windowHorizontal && !picHorizontal))
                return;

            picPreview.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void LoadCurrent()
        {
            current.Id = null;
            if (!string.IsNullOrEmpty(lblId.Text))
                current.Id = long.Parse(lblId.Text);

            current.ProductNr = txtProductNr.Text;
            current.Description = txtDescription.Text;
            current.Hochflor = long.Parse(txtHochflor.Text);
            current.Knots = long.Parse(txtKnots.Text);
            current.Weight = Common.GetPrice(txtWeight.Text);
            current.BuyPrice = Common.GetPrice(txtBuyPrice.Text);
            current.Color = txtColor.Text;
            current.Material = txtMaterial.Text;
            current.MaterialInside = txtMatInside.Text;
            current.Form = txtForm.Text;

            GetCurrentSupplier();
            if (current.SupplierId == -1)
                throw new Exception("Supplier is mandatory item!");

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
                {
                    current.Id = null;
                    current.ProductNr = GetNextProductNr(current.Supplier.NumberSerie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load current product! " + ex, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            current.Save();

            MessageBox.Show(this, "Save successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                LoadCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Unable to load current product! "+ex, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            current.Delete();

            MessageBox.Show(this, "Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
        }

        private void gridProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (gridProducts.SelectedCells == null || gridProducts.SelectedCells.Count == 0)
                current = ProductEntity.Empty;
            else
                current = gridProducts.Rows[gridProducts.SelectedCells[0].RowIndex].DataBoundItem as ProductEntity;

            // znovunacitanie aktualnej kvoli pokracujucim entitam..
            if (current.Id.HasValue)
                current.Load(current.Id.Value);
            ShowItem(current);
        }

        private void picPreview_Resize(object sender, EventArgs e)
        {
            RotatePreviewIfNeeded();
        }

        private void linkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetCurrentSupplier();
            Common.PresenterInst.FindShowEntity(typeof(SupplierEntity), current.SupplierId);
        }

        private void GetCurrentSupplier()
        {
            var se = cbSuppliers.SelectedItem as SupplierEntity;
            if (se != null)
                current.SupplierId = se.Id ?? -1;
            else
                current.SupplierId = -1;
        }

        private void cbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // len pre nove produkty
            if (current.Id != null)
                return;

            GetNewProdNumber();
        }

        private void GetNewProdNumber()
        {
            var sel = cbSuppliers.SelectedItem as SupplierEntity;
            if (sel == null)
            {
                txtProductNr.Text = "no supplier!";
                return;
            }

            txtProductNr.Text = GetNextProductNr(sel.NumberSerie);
        }

        private string GetNextProductNr(NumberSerieEntity nse)
        {
            if (nse == null)
                return string.Empty;

            return nse.Prefix + (nse.LastNr + 1).ToString();
        }

        #region IGridHolder Members

        public DoubleBufferedGrid GetDataGrid()
        {
            return gridProducts;
        }

        public bool ContainsEntities(Type ofType)
        {
            return ofType == typeof(ProductEntity);
        }

        public bool FindEntity(long id)
        {
            return Common.FindEntityInGrid<ProductEntity>(GetDataGrid(), id);
        }

        public UserControl GetControl()
        {
            return this;
        }

        #endregion
    }
}
