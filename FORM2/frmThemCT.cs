using FORM2.Data;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FORM5
{
    public partial class frmThemCT : DevExpress.XtraEditors.XtraForm
    {
        private QLBD context = new QLBD();
        public frmThemCT()
        {
            InitializeComponent();
        }

        private void frmThemCT_Load(object sender, System.EventArgs e)
        {
           FillComboBox(context.QuocGia.ToList());
          cmbVT.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            if(pbn14.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pbn14.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] bytBLOBData = new Byte[ms.Length];
                ms.Position = 0;
                ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
                CauThu ct = new CauThu()
                {

                    TenCauThu = txthoten.Text,
                    HinhAnhCT = bytBLOBData,
                    ViTri = cmbVT.Text,
                    MaQG = (cmbQG.SelectedItem as QuocGia).MaQG,
                };
                txthoten.Text = "";
                pbn14.Image = null;
                context.CauThu.Add(ct);
                context.SaveChanges();
            }

           
        }
        private void FillComboBox(List<QuocGia> a)
        {
            cmbQG.DataSource = a;
            cmbQG.DisplayMember = "TenQG";
            cmbQG.ValueMember = "MaQG";
        }
        private void txthoten_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txthoten.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txthoten, "Vui long nhap vao ten");
                //txthoten.Focus();
            }
            else
            {
                e.Cancel= false;
                errorProvider1.SetError(txthoten, "");
            }
        }

        private void btnThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void pbn14_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.JPG)| *.JPG | GIF Files(*.GIF) | *.GIF | PNG Files(*.PNG) | *.PNG"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image anh = Image.FromFile(ofd.FileName);
                pbn14.Image = anh;
                pbn14.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txthoten_TextChanged(object sender, EventArgs e)
        {
            CauThu ct = context.CauThu.FirstOrDefault(o=> o.TenCauThu.Equals(txthoten.Text));
            if(ct != null)
            {
                txthoten.Text = "";
                MessageBox.Show("Cầu thủ này đã tồn tại","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
