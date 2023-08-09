namespace WindowsFormsApp1
{
    partial class frmTKCT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTK = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboQG = new System.Windows.Forms.ComboBox();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTK = new System.Windows.Forms.ComboBox();
            this.dgvCauThu = new System.Windows.Forms.DataGridView();
            this.HinhAnhCT = new System.Windows.Forms.DataGridViewImageColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocKy = new System.Windows.Forms.DataGridViewImageColumn();
            this.QuocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboVT = new System.Windows.Forms.ComboBox();
            this.pcHinh = new System.Windows.Forms.PictureBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAnh = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTK
            // 
            this.btnTK.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Appearance.Options.UseFont = true;
            this.btnTK.Location = new System.Drawing.Point(281, 56);
            this.btnTK.Margin = new System.Windows.Forms.Padding(60);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(155, 51);
            this.btnTK.TabIndex = 22;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Quốc Gia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vị Trí";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên Cầu Thủ";
            // 
            // cboQG
            // 
            this.cboQG.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQG.FormattingEnabled = true;
            this.cboQG.Items.AddRange(new object[] {
            "Tên",
            "Vị Trí",
            "Quốc Gia"});
            this.cboQG.Location = new System.Drawing.Point(152, 244);
            this.cboQG.Name = "cboQG";
            this.cboQG.Size = new System.Drawing.Size(248, 32);
            this.cboQG.TabIndex = 18;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(152, 143);
            this.txtTen.Margin = new System.Windows.Forms.Padding(60);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(294, 30);
            this.txtTen.TabIndex = 16;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, -32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tìm Kiếm Theo";
            // 
            // cmbTK
            // 
            this.cmbTK.AutoCompleteCustomSource.AddRange(new string[] {
            "Tên Cầu Thủ",
            "Vị Trí",
            "Quốc Gia"});
            this.cmbTK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTK.FormattingEnabled = true;
            this.cmbTK.Items.AddRange(new object[] {
            "Tên",
            "Vị Trí",
            "Quốc Gia",
            "Tất Cả"});
            this.cmbTK.Location = new System.Drawing.Point(271, -35);
            this.cmbTK.Name = "cmbTK";
            this.cmbTK.Size = new System.Drawing.Size(248, 32);
            this.cmbTK.TabIndex = 14;
            // 
            // dgvCauThu
            // 
            this.dgvCauThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCauThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCauThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvCauThu.ColumnHeadersHeight = 30;
            this.dgvCauThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HinhAnhCT,
            this.Ten,
            this.ViTri,
            this.QuocKy,
            this.QuocGia,
            this.BT});
            this.dgvCauThu.Location = new System.Drawing.Point(473, 94);
            this.dgvCauThu.Name = "dgvCauThu";
            this.dgvCauThu.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCauThu.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCauThu.RowTemplate.Height = 24;
            this.dgvCauThu.Size = new System.Drawing.Size(762, 490);
            this.dgvCauThu.TabIndex = 13;
            this.dgvCauThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauThu_CellClick);
            // 
            // HinhAnhCT
            // 
            this.HinhAnhCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HinhAnhCT.FillWeight = 200.2F;
            this.HinhAnhCT.Frozen = true;
            this.HinhAnhCT.HeaderText = "";
            this.HinhAnhCT.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.HinhAnhCT.MinimumWidth = 6;
            this.HinhAnhCT.Name = "HinhAnhCT";
            this.HinhAnhCT.Width = 30;
            // 
            // Ten
            // 
            this.Ten.FillWeight = 101.6043F;
            this.Ten.HeaderText = "Tên Cầu Thủ";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ten.Width = 90;
            // 
            // ViTri
            // 
            this.ViTri.FillWeight = 101.6043F;
            this.ViTri.HeaderText = "Vị trí đá";
            this.ViTri.MinimumWidth = 6;
            this.ViTri.Name = "ViTri";
            this.ViTri.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ViTri.Width = 57;
            // 
            // QuocKy
            // 
            this.QuocKy.FillWeight = 101.6043F;
            this.QuocKy.HeaderText = "";
            this.QuocKy.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.QuocKy.MinimumWidth = 6;
            this.QuocKy.Name = "QuocKy";
            this.QuocKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.QuocKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.QuocKy.Width = 24;
            // 
            // QuocGia
            // 
            this.QuocGia.FillWeight = 101.6043F;
            this.QuocGia.HeaderText = "Quốc Gia";
            this.QuocGia.MinimumWidth = 6;
            this.QuocGia.Name = "QuocGia";
            this.QuocGia.Width = 92;
            // 
            // BT
            // 
            this.BT.HeaderText = "Số BT";
            this.BT.MinimumWidth = 6;
            this.BT.Name = "BT";
            this.BT.Width = 74;
            // 
            // cboLoai
            // 
            this.cboLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "Tên",
            "Vị Trí",
            "Quốc Gia"});
            this.cboLoai.Location = new System.Drawing.Point(16, 67);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(165, 33);
            this.cboLoai.TabIndex = 25;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // cboVT
            // 
            this.cboVT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVT.FormattingEnabled = true;
            this.cboVT.Items.AddRange(new object[] {
            "Tiền Đạo ",
            "Tiền Vệ",
            "Hậu Vệ ",
            "Trung Vệ ",
            "Thủ Môn"});
            this.cboVT.Location = new System.Drawing.Point(152, 197);
            this.cboVT.Name = "cboVT";
            this.cboVT.Size = new System.Drawing.Size(248, 32);
            this.cboVT.TabIndex = 26;
            // 
            // pcHinh
            // 
            this.pcHinh.Location = new System.Drawing.Point(83, 297);
            this.pcHinh.Name = "pcHinh";
            this.pcHinh.Size = new System.Drawing.Size(242, 198);
            this.pcHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcHinh.TabIndex = 27;
            this.pcHinh.TabStop = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(175, 1702);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(75);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(342, 125);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "Tìm Kiếm";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(844, 1702);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(75);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(342, 125);
            this.simpleButton2.TabIndex = 29;
            this.simpleButton2.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(16, 538);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(165, 46);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm/Cập Nhật";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(253, 538);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(165, 46);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAnh
            // 
            this.btnAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.Location = new System.Drawing.Point(371, 308);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(75, 59);
            this.btnAnh.TabIndex = 32;
            this.btnAnh.Text = "....";
            this.btnAnh.UseVisualStyleBackColor = true;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(521, 53);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 25);
            this.lbl.TabIndex = 33;
            this.lbl.Text = "label5";
            this.lbl.Visible = false;
            // 
            // frmTKCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 632);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAnh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pcHinh);
            this.Controls.Add(this.cboVT);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboQG);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTK);
            this.Controls.Add(this.dgvCauThu);
            this.Name = "frmTKCT";
            this.Text = "Tìm Kiếm Cầu Thủ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcHinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboQG;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTK;
        private System.Windows.Forms.DataGridView dgvCauThu;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.ComboBox cboVT;
        private System.Windows.Forms.DataGridViewImageColumn HinhAnhCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewImageColumn QuocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocGia;
        private System.Windows.Forms.PictureBox pcHinh;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn BT;
        private System.Windows.Forms.Label lbl;
    }
}