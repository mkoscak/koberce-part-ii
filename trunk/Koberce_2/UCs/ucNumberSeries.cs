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
    public partial class ucNumberSeries : UserControl, IGridHolder, IFilterProvider
    {
        NumberSerieEntity current;
        FilterPanel filter;

        public ucNumberSeries()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(btnReload, "Reload");

            filter = new FilterPanel(this, FilterChanged);
            filter.AddFilter(FilterItemType.TEXT, "NAME", "Name");
            filter.AddFilter(FilterItemType.TEXT, "PREFIX", "Prefix");
            filter.AddFilter(FilterItemType.NUMBER, "LAST_NR", "Last number");

            //nacitanie moze zlyhat ak DB neexistuje alebo nie je aktualne oscriptovana.. vtedy je potrebne pouzit DBHelper a spustit aktualny script
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
            gridSeries.DataSource = null;
            var data = NumberSerieEntity.Load(filter.GetSQL(" AND "), null);
            gridSeries.DataSource = data;
            Common.PresenterInst.ShowStatus(data.Count.ToString() + " number series loaded!");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        private void NewItem()
        {
            current = NumberSerieEntity.Empty;
            ShowItem(current);
        }

        private void LoadCurrent()
        {
            current.Id = null;
            if (!string.IsNullOrEmpty(lblId.Text))
                current.Id = long.Parse(lblId.Text);

            current.Name = txtName.Text;
            current.Prefix = txtPrefix.Text;
            current.LastNr = long.Parse(txtLastNr.Text);
            current.Comment = txtComment.Text;
        }

        private void ShowItem(NumberSerieEntity ent)
        {
            lblId.Text = ent.Id.HasValue ? ent.Id.Value.ToString() : string.Empty;
            txtName.Text = ent.Name;
            txtPrefix.Text = ent.Prefix;
            txtLastNr.Text = ent.LastNr.ToString();
            txtComment.Text = ent.Comment;
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
            try
            {
                DeleteCurrent();
                NewItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Delete unsuccessful: " + ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCurrent()
        {
            LoadCurrent();
            current.Delete();

            MessageBox.Show(this, "Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadAllData();
        }

        private void gridSeries_SelectionChanged(object sender, EventArgs e)
        {
            if (gridSeries.SelectedCells == null || gridSeries.SelectedCells.Count == 0)
                current = NumberSerieEntity.Empty;
            else
                current = gridSeries.Rows[gridSeries.SelectedCells[0].RowIndex].DataBoundItem as NumberSerieEntity;

            ShowItem(current);
        }

        #region IGridHolder Members

        public DoubleBufferedGrid GetDataGrid()
        {
            return gridSeries;
        }

        public bool ContainsEntities(Type ofType)
        {
            return ofType == typeof(NumberSerieEntity);
        }

        public bool FindEntity(long id)
        {
            return Common.FindEntityInGrid<NumberSerieEntity>(GetDataGrid(), id);
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
