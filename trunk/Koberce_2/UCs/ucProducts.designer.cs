namespace Koberce_2.UCs
{
    partial class ucProducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductNr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHochflor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKnots = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSuppliers = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMatInside = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtForm = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.linkSupplier = new System.Windows.Forms.LinkLabel();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tabStorages = new System.Windows.Forms.TabPage();
            this.tabPreview = new System.Windows.Forms.TabPage();
            this.btnRotatePreview = new System.Windows.Forms.Button();
            this.gridProducts = new Koberce_2.DoubleBufferedGrid();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.tabDetails.SuspendLayout();
            this.tabPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Image = global::Koberce_2.Properties.Resources.reload_tiny;
            this.btnReload.Location = new System.Drawing.Point(257, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 23);
            this.btnReload.TabIndex = 24;
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(177, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(96, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Green;
            this.btnNew.Location = new System.Drawing.Point(96, 349);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtComment
            // 
            this.txtComment.ForeColor = System.Drawing.Color.Maroon;
            this.txtComment.Location = new System.Drawing.Point(96, 323);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(184, 20);
            this.txtComment.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(39, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Comment";
            // 
            // txtProductNr
            // 
            this.txtProductNr.Enabled = false;
            this.txtProductNr.ForeColor = System.Drawing.Color.Maroon;
            this.txtProductNr.Location = new System.Drawing.Point(96, 33);
            this.txtProductNr.Name = "txtProductNr";
            this.txtProductNr.Size = new System.Drawing.Size(184, 20);
            this.txtProductNr.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product number";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.Maroon;
            this.lblId.Location = new System.Drawing.Point(93, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(13, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id";
            // 
            // txtDescription
            // 
            this.txtDescription.ForeColor = System.Drawing.Color.Maroon;
            this.txtDescription.Location = new System.Drawing.Point(96, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 20);
            this.txtDescription.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(30, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description";
            // 
            // txtHochflor
            // 
            this.txtHochflor.ForeColor = System.Drawing.Color.Maroon;
            this.txtHochflor.Location = new System.Drawing.Point(96, 85);
            this.txtHochflor.Name = "txtHochflor";
            this.txtHochflor.Size = new System.Drawing.Size(184, 20);
            this.txtHochflor.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(43, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Hochflor";
            // 
            // txtKnots
            // 
            this.txtKnots.ForeColor = System.Drawing.Color.Maroon;
            this.txtKnots.Location = new System.Drawing.Point(96, 111);
            this.txtKnots.Name = "txtKnots";
            this.txtKnots.Size = new System.Drawing.Size(184, 20);
            this.txtKnots.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(56, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Knots";
            // 
            // txtWeight
            // 
            this.txtWeight.ForeColor = System.Drawing.Color.Maroon;
            this.txtWeight.Location = new System.Drawing.Point(96, 137);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(184, 20);
            this.txtWeight.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(49, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Weight";
            // 
            // cbSuppliers
            // 
            this.cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSuppliers.ForeColor = System.Drawing.Color.Maroon;
            this.cbSuppliers.FormattingEnabled = true;
            this.cbSuppliers.Location = new System.Drawing.Point(96, 293);
            this.cbSuppliers.Name = "cbSuppliers";
            this.cbSuppliers.Size = new System.Drawing.Size(184, 21);
            this.cbSuppliers.TabIndex = 34;
            this.cbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cbSuppliers_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(154, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "* - Mandatory items";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(286, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(286, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "*";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.ForeColor = System.Drawing.Color.Maroon;
            this.txtBuyPrice.Location = new System.Drawing.Point(96, 163);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(184, 20);
            this.txtBuyPrice.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(39, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Buy price";
            // 
            // txtColor
            // 
            this.txtColor.ForeColor = System.Drawing.Color.Maroon;
            this.txtColor.Location = new System.Drawing.Point(96, 189);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(184, 20);
            this.txtColor.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(59, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Color";
            // 
            // txtMaterial
            // 
            this.txtMaterial.ForeColor = System.Drawing.Color.Maroon;
            this.txtMaterial.Location = new System.Drawing.Point(96, 215);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(184, 20);
            this.txtMaterial.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(46, 218);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Material";
            // 
            // txtMatInside
            // 
            this.txtMatInside.ForeColor = System.Drawing.Color.Maroon;
            this.txtMatInside.Location = new System.Drawing.Point(96, 241);
            this.txtMatInside.Name = "txtMatInside";
            this.txtMatInside.Size = new System.Drawing.Size(184, 20);
            this.txtMatInside.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(16, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Material inside";
            // 
            // txtForm
            // 
            this.txtForm.ForeColor = System.Drawing.Color.Maroon;
            this.txtForm.Location = new System.Drawing.Point(96, 267);
            this.txtForm.Name = "txtForm";
            this.txtForm.Size = new System.Drawing.Size(184, 20);
            this.txtForm.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(60, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Form";
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.Location = new System.Drawing.Point(1, 0);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(284, 163);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            this.picPreview.Resize += new System.EventHandler(this.picPreview_Resize);
            // 
            // linkSupplier
            // 
            this.linkSupplier.AutoSize = true;
            this.linkSupplier.Location = new System.Drawing.Point(45, 298);
            this.linkSupplier.Name = "linkSupplier";
            this.linkSupplier.Size = new System.Drawing.Size(45, 13);
            this.linkSupplier.TabIndex = 49;
            this.linkSupplier.TabStop = true;
            this.linkSupplier.Text = "Supplier";
            this.linkSupplier.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSupplier_LinkClicked);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveNew.Location = new System.Drawing.Point(177, 378);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(103, 23);
            this.btnSaveNew.TabIndex = 50;
            this.btnSaveNew.Text = "S&ave as new";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // tabDetails
            // 
            this.tabDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabDetails.Controls.Add(this.tabStorages);
            this.tabDetails.Controls.Add(this.tabPreview);
            this.tabDetails.Location = new System.Drawing.Point(6, 407);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(293, 189);
            this.tabDetails.TabIndex = 51;
            // 
            // tabStorages
            // 
            this.tabStorages.Location = new System.Drawing.Point(4, 22);
            this.tabStorages.Name = "tabStorages";
            this.tabStorages.Padding = new System.Windows.Forms.Padding(3);
            this.tabStorages.Size = new System.Drawing.Size(285, 163);
            this.tabStorages.TabIndex = 0;
            this.tabStorages.Text = "Storages";
            this.tabStorages.UseVisualStyleBackColor = true;
            // 
            // tabPreview
            // 
            this.tabPreview.Controls.Add(this.btnRotatePreview);
            this.tabPreview.Controls.Add(this.picPreview);
            this.tabPreview.Location = new System.Drawing.Point(4, 22);
            this.tabPreview.Name = "tabPreview";
            this.tabPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPreview.Size = new System.Drawing.Size(285, 163);
            this.tabPreview.TabIndex = 1;
            this.tabPreview.Text = "Product preview";
            this.tabPreview.UseVisualStyleBackColor = true;
            // 
            // btnRotatePreview
            // 
            this.btnRotatePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotatePreview.Image = global::Koberce_2.Properties.Resources.reload_tiny;
            this.btnRotatePreview.Location = new System.Drawing.Point(256, 6);
            this.btnRotatePreview.Name = "btnRotatePreview";
            this.btnRotatePreview.Size = new System.Drawing.Size(23, 23);
            this.btnRotatePreview.TabIndex = 25;
            this.btnRotatePreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRotatePreview.UseVisualStyleBackColor = true;
            this.btnRotatePreview.Click += new System.EventHandler(this.btnRotatePreview_Click);
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            this.gridProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Location = new System.Drawing.Point(305, 3);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.Size = new System.Drawing.Size(442, 593);
            this.gridProducts.TabIndex = 0;
            this.gridProducts.SelectionChanged += new System.EventHandler(this.gridProducts_SelectionChanged);
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabDetails);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.linkSupplier);
            this.Controls.Add(this.txtForm);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtMatInside);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbSuppliers);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKnots);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHochflor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProducts);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(750, 599);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.tabDetails.ResumeLayout(false);
            this.tabPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private DoubleBufferedGrid gridProducts;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHochflor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKnots;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMatInside;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtForm;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.LinkLabel linkSupplier;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tabStorages;
        private System.Windows.Forms.TabPage tabPreview;
        private System.Windows.Forms.Button btnRotatePreview;

    }
}
