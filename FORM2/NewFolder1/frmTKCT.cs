using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmTKCT : Form
    {
        private QLBD context = new QLBD();
        public frmTKCT()
        {
            InitializeComponent();
        }

        public frmTKCT(int i)
        {
            InitializeComponent();
            lbl.Text = i.ToString();
            if (i == 1)
            {
                btnThem.Visible = false;
                btnThem.Enabled = false;
                btnXoa.Visible = false;
                btnXoa.Enabled = false;
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            FillComboBox(context.QuocGia.ToList());
            BindGrid(context.CauThu.ToList());
            cboQG.SelectedIndex = 0;
            cboVT.SelectedIndex = 0;
            cboLoai.SelectedIndex = 0;
        }
        private void FillComboBox(List<QuocGia> list)
        {
            cboQG.DataSource = list;
            cboQG.DisplayMember = "TenQG";
            cboQG.ValueMember = "MaQG";
        }
        private void BindGrid(List<CauThu> list)
        {
            dgvCauThu.Rows.Clear(); 
            foreach(CauThu thu in list)
            {
                int i = dgvCauThu.Rows.Add();
                dgvCauThu.Rows[i].Cells[0].Value = thu.HinhAnhCT;
                dgvCauThu.Rows[i].Cells[1].Value = thu.TenCauThu;
                dgvCauThu.Rows[i].Cells[2].Value = thu.ViTri;
                dgvCauThu.Rows[i].Cells[3].Value = thu.QuocGia.QuocKy;
                dgvCauThu.Rows[i].Cells[4].Value = thu.QuocGia.TenQG;
                dgvCauThu.Rows[i].Cells[5].Value = thu.SoBanThang;
            }
        }

        private void btnTK_Click(object sender, EventArgs e)
        {

            if (cboLoai.SelectedIndex == 1)
            {
                BindGrid(context.CauThu.ToList().Where(o => o.ViTri == (cboVT.Text)).ToList());
            }
            else
            {
                BindGrid(context.CauThu.ToList().Where(o => o.MaQG == (cboQG.SelectedItem as QuocGia).MaQG).ToList());
            }
            txtTen.Text = "";
            cboQG.SelectedIndex = 0;
            cboVT.SelectedIndex = 0;
            pcHinh.Image = null;
        }


        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboLoai.SelectedIndex == 0)
            //{
            //    txtTen.Enabled = true;
            //    cboVT.Enabled = false;
            //    cboQG.Enabled = false;
            //}
            //else if(cboLoai.SelectedIndex == 1)
            //{
            //    txtTen.Enabled = false;
            //    cboVT.Enabled = true;
            //    cboQG.Enabled = false;
            //}
            //else
            //{
            //    txtTen.Enabled = false;
            //    cboVT.Enabled = false;
            //    cboQG.Enabled = true;
            //}    
        }

        private void dgvCauThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCauThu.Rows.Count > 0 && e.RowIndex > -1)
            {
                Byte[] MyData1 = new byte[0];
                MyData1 = (Byte[])(dgvCauThu.Rows[e.RowIndex].Cells[0].Value);
                MemoryStream stream1 = new MemoryStream(MyData1);
                stream1.Position = 0;
                pcHinh.Image = Image.FromStream(stream1);
      
                txtTen.Text = dgvCauThu.Rows[e.RowIndex].Cells[1].Value.ToString();
                var ct = context.CauThu.FirstOrDefault(o => o.TenCauThu == txtTen.Text);
                cboQG.Text = ct.QuocGia.TenQG;
                cboVT.Text = ct.ViTri;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (pcHinh.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                pcHinh.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Byte[] bytBLOBData = new Byte[ms.Length];
                ms.Position = 0;
                ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));
                var check = context.CauThu.FirstOrDefault(o => o.TenCauThu.ToLower().Contains(txtTen.Text.ToLower()));
                if(check != null)
                {
                    check.TenCauThu = txtTen.Text;
                    check.MaQG = (cboQG.SelectedItem as QuocGia).MaQG;
                    check.HinhAnhCT = bytBLOBData;
                    check.ViTri = cboVT.Text;
                    context.SaveChanges();
                    MessageBox.Show("Cập nhật cầu thủ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CauThu ct = new CauThu()
                    {
                        TenCauThu = txtTen.Text,
                        HinhAnhCT = bytBLOBData,
                        ViTri = cboVT.Text,
                        MaQG = (cboQG.SelectedItem as QuocGia).MaQG,
                     };
                    context.CauThu.Add(ct);
                    context.SaveChanges();
                    MessageBox.Show("Thêm cầu thủ thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtTen.Text = "";
                pcHinh.Image = null;

                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var check = context.CauThu.FirstOrDefault(o => o.TenCauThu == txtTen.Text);
            if (check != null)
            {
                context.CauThu.Remove(check);
                context.SaveChanges();
                txtTen.Text = "";
                pcHinh.Image = null;
            }
            BindGrid(context.CauThu.ToList());
        }

       
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files(*.JPG)| *.JPG | GIF Files(*.GIF) | *.GIF | PNG Files(*.PNG) | *.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image anh = Image.FromFile(ofd.FileName);
                pcHinh.Image = anh;
                pcHinh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (cboLoai.SelectedIndex == 0)
            {
                BindGrid(context.CauThu.ToList().Where(o => o.TenCauThu.ToLower().Contains(txtTen.Text.ToLower())).ToList());
            }
        }
    }
}
 