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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolDbHelper = new System.Windows.Forms.ToolStripButton();
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
            this.toolDbHelper});
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
            this.statusLabel1.Size = new System.Drawing.Size(77, 17);
            this.statusLabel1.Text = "Form loaded!";
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
            this.Text = "Global - part II - v0.1";
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
    }
}

