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
    public partial class ucNumberSeries : UserControl
    {
        NumberSerieEntity current;

        public ucNumberSeries()
        {
            InitializeComponent();

            new ToolTip().SetToolTip(btnReload, "Reload");

            ReloadAllData();
            NewItem();
        }

        private void ReloadAllData()
        {
            listSeries.Items.Clear();

            var data = NumberSerieEntity.LoadAll();
            foreach (var item in data)
            {
                var toAdd = new ListViewItem(item.Name);
                toAdd.Tag = item;
                listSeries.Items.Add(toAdd);
            }
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
            LoadCurrent();
            current.Save();

            MessageBox.Show(this, "Save successful!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReloadAllData();
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

        private void listSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSeries.SelectedItems == null || listSeries.SelectedItems.Count == 0)
                current = NumberSerieEntity.Empty;
            else
                current = listSeries.SelectedItems[0].Tag as NumberSerieEntity;

            ShowItem(current);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadAllData();
        }
    }
}
