namespace FORM1
{
    partial class frmDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDN));
            this.txttk = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblQuenmk = new System.Windows.Forms.LinkLabel();
            this.lbldangky = new System.Windows.Forms.LinkLabel();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.chkLuu = new System.Windows.Forms.CheckBox();
            this.btndangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txttk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(127, 60);
            this.txttk.Margin = new System.Windows.Forms.Padding(4);
            this.txttk.Name = "txttk";
            this.txttk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Properties.Appearance.Options.UseFont = true;
            this.txttk.Size = new System.Drawing.Size(250, 30);
            this.txttk.TabIndex = 0;
            this.txttk.Validating += new System.ComponentModel.CancelEventHandler(this.txttk_Validating);
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(760, 13);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(8, 22);
            this.textEdit2.TabIndex = 1;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(127, 118);
            this.txtmk.Margin = new System.Windows.Forms.Padding(5);
            this.txtmk.Name = "txtmk";
            this.txtmk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Properties.Appearance.Options.UseFont = true;
            this.txtmk.Size = new System.Drawing.Size(250, 30);
            this.txtmk.TabIndex = 2;
            this.txtmk.Validating += new System.ComponentModel.CancelEventHandler(this.txtmk_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(137, 2);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(233, 24);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl2.ImageOptions.SvgImage")));
            this.labelControl2.Location = new System.Drawing.Point(49, 50);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 40);
            this.labelControl2.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("labelControl3.ImageOptions.SvgImage")));
            this.labelControl3.Location = new System.Drawing.Point(49, 116);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 40);
            this.labelControl3.TabIndex = 5;
            // 
            // lblQuenmk
            // 
            this.lblQuenmk.AutoSize = true;
            this.lblQuenmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenmk.Location = new System.Drawing.Point(159, 367);
            this.lblQuenmk.Name = "lblQuenmk";
            this.lblQuenmk.Size = new System.Drawing.Size(144, 23);
            this.lblQuenmk.TabIndex = 6;
            this.lblQuenmk.TabStop = true;
            this.lblQuenmk.Text = "Quên Mật Khẩu";
            // 
            // lbldangky
            // 
            this.lbldangky.AutoSize = true;
            this.lbldangky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangky.Location = new System.Drawing.Point(321, 333);
            this.lbldangky.Name = "lbldangky";
            this.lbldangky.Size = new System.Drawing.Size(83, 23);
            this.lbldangky.TabIndex = 8;
            this.lbldangky.TabStop = true;
            this.lbldangky.Text = "Đăng Ký";
            this.lbldangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbldangky_LinkClicked);
            // 
            // chkHienThi
            // 
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienThi.Location = new System.Drawing.Point(156, 170);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(166, 26);
            this.chkHienThi.TabIndex = 9;
            this.chkHienThi.Text = "Hiện Mật Khẩu";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.chkHienThi_CheckedChanged);
            // 
            // chkLuu
            // 
            this.chkLuu.AutoSize = true;
            this.chkLuu.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLuu.Location = new System.Drawing.Point(156, 202);
            this.chkLuu.Name = "chkLuu";
            this.chkLuu.Size = new System.Drawing.Size(165, 25);
            this.chkLuu.TabIndex = 10;
            this.chkLuu.Text = "Lưu Đăng Nhập";
            this.chkLuu.UseVisualStyleBackColor = true;
            this.chkLuu.CheckedChanged += new System.EventHandler(this.chkLuu_CheckedChanged);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndangnhap.Appearance.Options.UseFont = true;
            this.btndangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndangnhap.ImageOptions.Image")));
            this.btndangnhap.Location = new System.Drawing.Point(156, 262);
            this.btndangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(162, 29);
            this.btndangnhap.TabIndex = 11;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chưa có tài khoản?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.chkLuu);
            this.Controls.Add(this.chkHienThi);
            this.Controls.Add(this.lbldangky);
            this.Controls.Add(this.lblQuenmk);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.txttk);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDN";
            this.Load += new System.EventHandler(this.frmDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txttk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txttk;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit txtmk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.LinkLabel lblQuenmk;
        private System.Windows.Forms.LinkLabel lbldangky;
        private System.Windows.Forms.CheckBox chkHienThi;
        private System.Windows.Forms.CheckBox chkLuu;
        private DevExpress.XtraEditors.SimpleButton btndangnhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

