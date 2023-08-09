namespace FORM2
{
    partial class frmQMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQMK));
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtLayMK = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.errP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtgm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(48, 157);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(101, 24);
            this.lblKetQua.TabIndex = 10;
            this.lblKetQua.Text = "Mật Khẩu:";
            // 
            // txtLayMK
            // 
            this.txtLayMK.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLayMK.Appearance.Options.UseFont = true;
            this.txtLayMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtLayMK.ImageOptions.Image")));
            this.txtLayMK.Location = new System.Drawing.Point(131, 212);
            this.txtLayMK.Margin = new System.Windows.Forms.Padding(6);
            this.txtLayMK.Name = "txtLayMK";
            this.txtLayMK.Size = new System.Drawing.Size(257, 53);
            this.txtLayMK.TabIndex = 9;
            this.txtLayMK.Text = "Lấy lại mật khẩu";
            this.txtLayMK.Click += new System.EventHandler(this.txtLayMK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUÊN MẬT KHẨU";
            // 
            // txtgm
            // 
            this.txtgm.Location = new System.Drawing.Point(131, 94);
            this.txtgm.Margin = new System.Windows.Forms.Padding(6);
            this.txtgm.Name = "txtgm";
            this.txtgm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgm.Properties.Appearance.Options.UseFont = true;
            this.txtgm.Size = new System.Drawing.Size(274, 30);
            this.txtgm.TabIndex = 7;
            this.txtgm.Validating += new System.ComponentModel.CancelEventHandler(this.txtgm_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(52, 93);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 32);
            this.labelControl1.TabIndex = 6;
            // 
            // errP
            // 
            this.errP.ContainerControl = this;
            // 
            // lblMK
            // 
            this.lblMK.AutoSize = true;
            this.lblMK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMK.Location = new System.Drawing.Point(177, 170);
            this.lblMK.Name = "lblMK";
            this.lblMK.Size = new System.Drawing.Size(0, 24);
            this.lblMK.TabIndex = 11;
            // 
            // frmQMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 326);
            this.Controls.Add(this.lblMK);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtLayMK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgm);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmQMK";
            this.Text = "frmQMK";
            this.Load += new System.EventHandler(this.frmQMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtgm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private DevExpress.XtraEditors.SimpleButton txtLayMK;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtgm;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ErrorProvider errP;
        private System.Windows.Forms.Label lblMK;
    }
}