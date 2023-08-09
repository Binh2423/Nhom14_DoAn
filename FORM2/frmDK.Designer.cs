namespace FORM2
{
    partial class frmDK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDK));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txttk = new DevExpress.XtraEditors.TextEdit();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            this.txtxnmk = new DevExpress.XtraEditors.TextEdit();
            this.txtgm = new DevExpress.XtraEditors.TextEdit();
            this.btnDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbkHMK = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txttk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxnmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(141, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(324, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(141, 64);
            this.txttk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txttk.Name = "txttk";
            this.txttk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Properties.Appearance.Options.UseFont = true;
            this.txttk.Size = new System.Drawing.Size(318, 30);
            this.txttk.TabIndex = 1;
            this.txttk.Validating += new System.ComponentModel.CancelEventHandler(this.txttk_Validating);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(141, 135);
            this.txtmk.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtmk.Name = "txtmk";
            this.txtmk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Properties.Appearance.Options.UseFont = true;
            this.txtmk.Size = new System.Drawing.Size(318, 30);
            this.txtmk.TabIndex = 2;
            this.txtmk.Validating += new System.ComponentModel.CancelEventHandler(this.txtmk_Validating);
            // 
            // txtxnmk
            // 
            this.txtxnmk.Location = new System.Drawing.Point(141, 208);
            this.txtxnmk.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtxnmk.Name = "txtxnmk";
            this.txtxnmk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxnmk.Properties.Appearance.Options.UseFont = true;
            this.txtxnmk.Size = new System.Drawing.Size(318, 30);
            this.txtxnmk.TabIndex = 3;
            this.txtxnmk.Validating += new System.ComponentModel.CancelEventHandler(this.txtxnmk_Validating);
            // 
            // txtgm
            // 
            this.txtgm.Location = new System.Drawing.Point(141, 282);
            this.txtgm.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtgm.Name = "txtgm";
            this.txtgm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgm.Properties.Appearance.Options.UseFont = true;
            this.txtgm.Size = new System.Drawing.Size(318, 30);
            this.txtgm.TabIndex = 4;
            this.txtgm.Validating += new System.ComponentModel.CancelEventHandler(this.txtgm_Validating);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Appearance.Options.UseFont = true;
            this.btnDangKy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangKy.ImageOptions.SvgImage")));
            this.btnDangKy.Location = new System.Drawing.Point(188, 392);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(235, 45);
            this.btnDangKy.TabIndex = 9;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl2.ImageOptions.SvgImage")));
            this.labelControl2.Location = new System.Drawing.Point(60, 59);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 40);
            this.labelControl2.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl3.ImageOptions.Image")));
            this.labelControl3.Location = new System.Drawing.Point(68, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 32);
            this.labelControl3.TabIndex = 11;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl4.ImageOptions.Image")));
            this.labelControl4.Location = new System.Drawing.Point(68, 216);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 32);
            this.labelControl4.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl5.ImageOptions.Image")));
            this.labelControl5.Location = new System.Drawing.Point(68, 290);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 32);
            this.labelControl5.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbkHMK
            // 
            this.cbkHMK.AutoSize = true;
            this.cbkHMK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbkHMK.Location = new System.Drawing.Point(219, 333);
            this.cbkHMK.Name = "cbkHMK";
            this.cbkHMK.Size = new System.Drawing.Size(163, 28);
            this.cbkHMK.TabIndex = 14;
            this.cbkHMK.Text = "Hiện mật khẩu";
            this.cbkHMK.UseVisualStyleBackColor = true;
            this.cbkHMK.CheckedChanged += new System.EventHandler(this.cbkHMK_CheckedChanged);
            // 
            // frmDK
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 479);
            this.Controls.Add(this.cbkHMK);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtgm);
            this.Controls.Add(this.txtxnmk);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDK";
            this.Text = "Đăng Ký Tài Khoản";
            this.Load += new System.EventHandler(this.frmDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtxnmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txttk;
        private DevExpress.XtraEditors.TextEdit txtmk;
        private DevExpress.XtraEditors.TextEdit txtxnmk;
        private DevExpress.XtraEditors.TextEdit txtgm;
        private DevExpress.XtraEditors.SimpleButton btnDangKy;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbkHMK;
    }
}

