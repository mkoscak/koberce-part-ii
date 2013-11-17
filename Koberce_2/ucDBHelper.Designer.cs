namespace Koberce_2
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
            this.gridDBres = new System.Windows.Forms.DataGridView();
            this.txtNonQueryRes = new System.Windows.Forms.TextBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecNonQuery = new System.Windows.Forms.Button();
            this.btnExecQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDBres)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDBres
            // 
            this.gridDBres.AllowUserToAddRows = false;
            this.gridDBres.AllowUserToDeleteRows = false;
            this.gridDBres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDBres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDBres.Location = new System.Drawing.Point(3, 291);
            this.gridDBres.Name = "gridDBres";
            this.gridDBres.Size = new System.Drawing.Size(930, 290);
            this.gridDBres.TabIndex = 1;
            // 
            // txtNonQueryRes
            // 
            this.txtNonQueryRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNonQueryRes.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNonQueryRes.Location = new System.Drawing.Point(513, 3);
            this.txtNonQueryRes.Multiline = true;
            this.txtNonQueryRes.Name = "txtNonQueryRes";
            this.txtNonQueryRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNonQueryRes.Size = new System.Drawing.Size(420, 282);
            this.txtNonQueryRes.TabIndex = 3;
            this.txtNonQueryRes.WordWrap = false;
            // 
            // txtQuery
            // 
            this.txtQuery.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuery.Location = new System.Drawing.Point(134, 3);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(373, 282);
            this.txtQuery.TabIndex = 4;
            this.txtQuery.Text = "select * from sqlite_master\r\n\r\n";
            this.txtQuery.WordWrap = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 254);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExecNonQuery
            // 
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
            this.btnExecQuery.Location = new System.Drawing.Point(3, 3);
            this.btnExecQuery.Name = "btnExecQuery";
            this.btnExecQuery.Size = new System.Drawing.Size(125, 33);
            this.btnExecQuery.TabIndex = 6;
            this.btnExecQuery.Text = "Execute &query";
            this.btnExecQuery.UseVisualStyleBackColor = true;
            this.btnExecQuery.Click += new System.EventHandler(this.btnExecQuery_Click);
            // 
            // ucDBHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExecNonQuery);
            this.Controls.Add(this.btnExecQuery);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtNonQueryRes);
            this.Controls.Add(this.gridDBres);
            this.DoubleBuffered = true;
            this.Name = "ucDBHelper";
            this.Size = new System.Drawing.Size(936, 584);
            ((System.ComponentModel.ISupportInitialize)(this.gridDBres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridDBres;
        private System.Windows.Forms.TextBox txtNonQueryRes;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecNonQuery;
        private System.Windows.Forms.Button btnExecQuery;
    }
}
