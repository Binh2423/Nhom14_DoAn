namespace FORM2
{
    partial class test
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
            this.QG = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenQG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QK = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.QG)).BeginInit();
            this.SuspendLayout();
            // 
            // QG
            // 
            this.QG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.TenQG,
            this.QK});
            this.QG.Location = new System.Drawing.Point(72, 115);
            this.QG.Name = "QG";
            this.QG.RowHeadersWidth = 51;
            this.QG.RowTemplate.Height = 24;
            this.QG.Size = new System.Drawing.Size(640, 258);
            this.QG.TabIndex = 0;
            // 
            // Ma
            // 
            this.Ma.HeaderText = "MaQG";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 125;
            // 
            // TenQG
            // 
            this.TenQG.HeaderText = "TenQG";
            this.TenQG.MinimumWidth = 6;
            this.TenQG.Name = "TenQG";
            this.TenQG.Width = 125;
            // 
            // QK
            // 
            this.QK.HeaderText = "QK";
            this.QK.MinimumWidth = 6;
            this.QK.Name = "QK";
            this.QK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QK.Width = 125;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QG);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView QG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenQG;
        private System.Windows.Forms.DataGridViewImageColumn QK;
    }
}