namespace Koberce_2.UCs
{
    partial class ucDBHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDBHelper));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNonQueryRes = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecNonQuery = new System.Windows.Forms.Button();
            this.btnExecQuery = new System.Windows.Forms.Button();
            this.splitBoxes = new System.Windows.Forms.SplitContainer();
            this.gridDBres = new Koberce_2.DoubleBufferedGrid();
            this.splitBoxes.Panel1.SuspendLayout();
            this.splitBoxes.Panel2.SuspendLayout();
            this.splitBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDBres)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNonQueryRes
            // 
            this.txtNonQueryRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNonQueryRes.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNonQueryRes.Location = new System.Drawing.Point(3, 3);
            this.txtNonQueryRes.Multiline = true;
            this.txtNonQueryRes.Name = "txtNonQueryRes";
            this.txtNonQueryRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNonQueryRes.Size = new System.Drawing.Size(521, 272);
            this.txtNonQueryRes.TabIndex = 3;
            this.txtNonQueryRes.WordWrap = false;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuery.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuery.Location = new System.Drawing.Point(134, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(271, 272);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.Text = resources.GetString("txtQuery.Text");
            this.txtQuery.WordWrap = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(3, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExecNonQuery
            // 
            this.btnExecNonQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecNonQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExecNonQuery.Location = new System.Drawing.Point(3, 42);
            this.btnExecNonQuery.Name = "btnExecNonQuery";
            this.btnExecNonQuery.Size = new System.Drawing.Size(125, 33);
            this.btnExecNonQuery.TabIndex = 7;
            this.btnExecNonQuery.Text = "Ex&ecute NONquery";
            this.btnExecNonQuery.UseVisualStyleBackColor = true;
            this.btnExecNonQuery.Click += new System.EventHandler(this.btnExecNonQuery_Click);
            // 
            // btnExecQuery
            // 
            this.btnExecQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExecQuery.Location = new System.Drawing.Point(3, 3);
            this.btnExecQuery.Name = "btnExecQuery";
            this.btnExecQuery.Size = new System.Drawing.Size(125, 33);
            this.btnExecQuery.TabIndex = 6;
            this.btnExecQuery.Text = "Execute &query";
            this.btnExecQuery.UseVisualStyleBackColor = true;
            this.btnExecQuery.Click += new System.EventHandler(this.btnExecQuery_Click);
            // 
            // splitBoxes
            // 
            this.splitBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitBoxes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitBoxes.Location = new System.Drawing.Point(3, 3);
            this.splitBoxes.Name = "splitBoxes";
            // 
            // splitBoxes.Panel1
            // 
            this.splitBoxes.Panel1.Controls.Add(this.txtQuery);
            this.splitBoxes.Panel1.Controls.Add(this.btnClear);
            this.splitBoxes.Panel1.Controls.Add(this.btnExecQuery);
            this.splitBoxes.Panel1.Controls.Add(this.btnExecNonQuery);
            this.splitBoxes.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitBoxes.Panel2
            // 
            this.splitBoxes.Panel2.Controls.Add(this.txtNonQueryRes);
            this.splitBoxes.Size = new System.Drawing.Size(947, 282);
            this.splitBoxes.SplitterDistance = 412;
            this.splitBoxes.TabIndex = 9;
            // 
            // gridDBres
            // 
            this.gridDBres.AllowUserToAddRows = false;
            this.gridDBres.AllowUserToDeleteRows = false;
            this.gridDBres.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            this.gridDBres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDBres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDBres.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.gridDBres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDBres.Location = new System.Drawing.Point(3, 291);
            this.gridDBres.Name = "gridDBres";
            this.gridDBres.Size = new System.Drawing.Size(947, 305);
            this.gridDBres.TabIndex = 1;
            // 
            // ucDBHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.splitBoxes);
            this.Controls.Add(this.gridDBres);
            this.DoubleBuffered = true;
            this.Name = "ucDBHelper";
            this.Size = new System.Drawing.Size(953, 599);
            this.splitBoxes.Panel1.ResumeLayout(false);
            this.splitBoxes.Panel1.PerformLayout();
            this.splitBoxes.Panel2.ResumeLayout(false);
            this.splitBoxes.Panel2.PerformLayout();
            this.splitBoxes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDBres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNonQueryRes;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecNonQuery;
        private System.Windows.Forms.Button btnExecQuery;
        private DoubleBufferedGrid gridDBres;
        private System.Windows.Forms.SplitContainer splitBoxes;
    }
}
