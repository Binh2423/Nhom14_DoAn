namespace FORM2
{
    partial class frmQLTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTK));
            this.lvTK = new System.Windows.Forms.ListView();
            this.usename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lvTK
            // 
            this.lvTK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.usename,
            this.password,
            this.email});
            this.lvTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTK.FullRowSelect = true;
            this.lvTK.GridLines = true;
            this.lvTK.HideSelection = false;
            this.lvTK.Location = new System.Drawing.Point(13, 111);
            this.lvTK.Name = "lvTK";
            this.lvTK.Size = new System.Drawing.Size(828, 268);
            this.lvTK.TabIndex = 4;
            this.lvTK.UseCompatibleStateImageBehavior = false;
            this.lvTK.View = System.Windows.Forms.View.Details;
            this.lvTK.SelectedIndexChanged += new System.EventHandler(this.lvTK_SelectedIndexChanged);
            // 
            // usename
            // 
            this.usename.Text = "Tên tài khoản";
            this.usename.Width = 194;
            // 
            // password
            // 
            this.password.Text = "Mật khẩu";
            this.password.Width = 152;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 224;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(332, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(320, 35);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(35, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(232, 28);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Tìm Kiếm Tài Khoản";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(296, 62);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(247, 34);
            this.txtTim.TabIndex = 7;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(601, 58);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(270, 38);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa Tài Khoản";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 429);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lvTK);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmQLTK";
            this.Text = "frmQLTK";
            this.Load += new System.EventHandler(this.frmQLTK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvTK;
        private System.Windows.Forms.ColumnHeader usename;
        private System.Windows.Forms.ColumnHeader password;
        private System.Windows.Forms.ColumnHeader email;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox txtTim;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
    }
}