namespace Koberce_2
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolbarMain = new System.Windows.Forms.ToolStrip();
            this.btnToolExit = new System.Windows.Forms.ToolStripButton();
            this.toolBack = new System.Windows.Forms.ToolStripButton();
            this.toolNextTab = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolProducts = new System.Windows.Forms.ToolStripButton();
            this.toolSuppliers = new System.Windows.Forms.ToolStripButton();
            this.toolCustomers = new System.Windows.Forms.ToolStripButton();
            this.toolStorages = new System.Windows.Forms.ToolStripButton();
            this.toolNrSeries = new System.Windows.Forms.ToolStripButton();
            this.toolDbHelper = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExRateLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolExRateCzk = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolExcelexport = new System.Windows.Forms.ToolStripButton();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolbarMain.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarMain
            // 
            this.toolbarMain.BackColor = System.Drawing.SystemColors.Control;
            this.toolbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarMain.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolExit,
            this.toolBack,
            this.toolNextTab,
            this.toolStripSeparator3,
            this.toolProducts,
            this.toolSuppliers,
            this.toolCustomers,
            this.toolStorages,
            this.toolNrSeries,
            this.toolDbHelper,
            this.toolStripSeparator1,
            this.toolExRateLabel,
            this.toolExRateCzk,
            this.toolStripSeparator2,
            this.toolExcelexport});
            this.toolbarMain.Location = new System.Drawing.Point(0, 0);
            this.toolbarMain.Name = "toolbarMain";
            this.toolbarMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbarMain.Size = new System.Drawing.Size(1138, 55);
            this.toolbarMain.TabIndex = 0;
            this.toolbarMain.Text = "Toolbar";
            // 
            // btnToolExit
            // 
            this.btnToolExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnToolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolExit.Image = ((System.Drawing.Image)(resources.GetObject("btnToolExit.Image")));
            this.btnToolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolExit.Name = "btnToolExit";
            this.btnToolExit.Size = new System.Drawing.Size(52, 52);
            this.btnToolExit.Text = "Exit application";
            this.btnToolExit.Click += new System.EventHandler(this.btnToolExit_Click);
            // 
            // toolBack
            // 
            this.toolBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBack.Image = ((System.Drawing.Image)(resources.GetObject("toolBack.Image")));
            this.toolBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBack.Name = "toolBack";
            this.toolBack.Size = new System.Drawing.Size(52, 52);
            this.toolBack.Text = "Previous selected tab";
            this.toolBack.Click += new System.EventHandler(this.toolBack_Click);
            // 
            // toolNextTab
            // 
            this.toolNextTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNextTab.Image = ((System.Drawing.Image)(resources.GetObject("toolNextTab.Image")));
            this.toolNextTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNextTab.Name = "toolNextTab";
            this.toolNextTab.Size = new System.Drawing.Size(52, 52);
            this.toolNextTab.Text = "Next tab";
            this.toolNextTab.Click += new System.EventHandler(this.toolNextTab_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolProducts
            // 
            this.toolProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolProducts.Image = ((System.Drawing.Image)(resources.GetObject("toolProducts.Image")));
            this.toolProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolProducts.Name = "toolProducts";
            this.toolProducts.Size = new System.Drawing.Size(52, 52);
            this.toolProducts.Text = "Products";
            this.toolProducts.Click += new System.EventHandler(this.toolProducts_Click);
            // 
            // toolSuppliers
            // 
            this.toolSuppliers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSuppliers.Image = ((System.Drawing.Image)(resources.GetObject("toolSuppliers.Image")));
            this.toolSuppliers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSuppliers.Name = "toolSuppliers";
            this.toolSuppliers.Size = new System.Drawing.Size(52, 52);
            this.toolSuppliers.Text = "Suppliers";
            this.toolSuppliers.Click += new System.EventHandler(this.toolSuppliers_Click);
            // 
            // toolCustomers
            // 
            this.toolCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCustomers.Image = ((System.Drawing.Image)(resources.GetObject("toolCustomers.Image")));
            this.toolCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCustomers.Name = "toolCustomers";
            this.toolCustomers.Size = new System.Drawing.Size(52, 52);
            this.toolCustomers.Text = "Customers";
            this.toolCustomers.Click += new System.EventHandler(this.toolCustomers_Click);
            // 
            // toolStorages
            // 
            this.toolStorages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStorages.Image = ((System.Drawing.Image)(resources.GetObject("toolStorages.Image")));
            this.toolStorages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStorages.Name = "toolStorages";
            this.toolStorages.Size = new System.Drawing.Size(52, 52);
            this.toolStorages.Text = "Storages";
            this.toolStorages.Click += new System.EventHandler(this.toolStorages_Click);
            // 
            // toolNrSeries
            // 
            this.toolNrSeries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNrSeries.Image = ((System.Drawing.Image)(resources.GetObject("toolNrSeries.Image")));
            this.toolNrSeries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNrSeries.Name = "toolNrSeries";
            this.toolNrSeries.Size = new System.Drawing.Size(52, 52);
            this.toolNrSeries.Text = "Number series";
            this.toolNrSeries.Click += new System.EventHandler(this.toolNrSeries_Click);
            // 
            // toolDbHelper
            // 
            this.toolDbHelper.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDbHelper.Image = ((System.Drawing.Image)(resources.GetObject("toolDbHelper.Image")));
            this.toolDbHelper.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDbHelper.Name = "toolDbHelper";
            this.toolDbHelper.Size = new System.Drawing.Size(52, 52);
            this.toolDbHelper.Text = "Database helper";
            this.toolDbHelper.Click += new System.EventHandler(this.toolDbHelper_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolExRateLabel
            // 
            this.toolExRateLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolExRateLabel.Name = "toolExRateLabel";
            this.toolExRateLabel.Size = new System.Drawing.Size(133, 52);
            this.toolExRateLabel.Text = "CZK / EUR exchange rate:";
            // 
            // toolExRateCzk
            // 
            this.toolExRateCzk.ForeColor = System.Drawing.Color.Maroon;
            this.toolExRateCzk.Name = "toolExRateCzk";
            this.toolExRateCzk.Size = new System.Drawing.Size(50, 55);
            this.toolExRateCzk.Text = "27,269";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // toolExcelexport
            // 
            this.toolExcelexport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExcelexport.Image = ((System.Drawing.Image)(resources.GetObject("toolExcelexport.Image")));
            this.toolExcelexport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExcelexport.Name = "toolExcelexport";
            this.toolExcelexport.Size = new System.Drawing.Size(52, 52);
            this.toolExcelexport.Text = "Export actual table to excel";
            this.toolExcelexport.Click += new System.EventHandler(this.toolExcelexport_Click);
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Location = new System.Drawing.Point(3, 58);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1135, 607);
            this.tabMain.TabIndex = 1;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 668);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1138, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "Status bar";
            // 
            // statusLabel1
            // 
            this.statusLabel1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(70, 17);
            this.statusLabel1.Text = "Form loaded!";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 690);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.toolbarMain);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(740, 465);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global - part II - v0.5.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.toolbarMain.ResumeLayout(false);
            this.toolbarMain.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbarMain;
        private System.Windows.Forms.ToolStripButton btnToolExit;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripButton toolDbHelper;
        private System.Windows.Forms.ToolStripButton toolNrSeries;
        private System.Windows.Forms.ToolStripButton toolSuppliers;
        private System.Windows.Forms.ToolStripButton toolCustomers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolExRateLabel;
        private System.Windows.Forms.ToolStripTextBox toolExRateCzk;
        private System.Windows.Forms.ToolStripButton toolStorages;
        private System.Windows.Forms.ToolStripButton toolProducts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolExcelexport;
        private System.Windows.Forms.ToolStripButton toolBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolNextTab;
    }
}

