using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace FORM2
{
    public partial class frmThemTD : Form
    {
        QLBD context = new QLBD();
        
        public frmThemTD()
        {
            InitializeComponent();
        }
        private void frmThemTD_Load(object sender, EventArgs e)
        {
            cboQG.DataSource = context.QuocGia.ToList();
            cboQG2.DataSource = context.QuocGia.ToList();
            cboQG.DisplayMember = "TenQG";
            cboQG.ValueMember = "MaQG";
            cboQG2.DisplayMember = "TenQG";
            cboQG2.ValueMember = "MaQG";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cboQG.Text==cboQG2.Text)
            {
                MessageBox.Show("Không thể thêm trận đấu","Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cboQG.SelectedIndex = 0;
                cboQG2.SelectedIndex = 0;
            }
            else
            {
                TranDau ct = new TranDau()
                {
                    MaQG = (cboQG.SelectedItem as QuocGia).MaQG,
                    MaQG2 = (cboQG2.SelectedItem as QuocGia).MaQG,
                    TySo1 = int.Parse(txtTySo1.Text),
                    TySo2 = int.Parse(txtTySo2.Text),
                    NgayDa = dtpNgay.Value,
                };
                
                context.TranDau.Add(ct);
                context.SaveChanges();
                UpdateData(ct);
                this.Hide();

            }
            
        }
        private void UpdateData(TranDau td)
        {
            var qg1 = context.XepHang.FirstOrDefault(o => o.MaQG == td.MaQG);
            var qg2 = context.XepHang.FirstOrDefault(o => o.MaQG == td.MaQG2);
            if (td.TySo1 > td.TySo2)
            {
                qg1.Diem += 3;
                qg1.BT += short.Parse(td.TySo1.ToString());
                qg1.SBT += short.Parse(td.TySo2.ToString());

                qg2.BT += short.Parse(td.TySo2.ToString());
                qg2.SBT += short.Parse(td.TySo1.ToString());
                qg1.Thang += 1;
                qg2.Thua += 1;
                qg1.HS = (short)(qg1.BT - qg1.SBT);
                qg2.HS = (short)(qg2.BT - qg2.SBT);
                context.SaveChanges();
            }
            else if (td.TySo1 < td.TySo2)
            {
                qg2.Diem += 3;
                qg2.BT += short.Parse(td.TySo2.ToString());
                qg2.SBT += short.Parse(td.TySo1.ToString());
                qg1.BT += short.Parse(td.TySo1.ToString());
                qg1.SBT += short.Parse(td.TySo2.ToString());
                qg2.Thang += 1;
                qg1.Thua += 1;
                qg1.HS = (short)(qg1.BT - qg1.SBT);
                qg2.HS = (short)(qg2.BT - qg2.SBT);
                context.SaveChanges();
            }
            else if(td.TySo1 == td.TySo2)
            {
                qg1.BT += short.Parse(td.TySo1.ToString());
                qg1.SBT += short.Parse(td.TySo2.ToString());
                qg1.Hoa += 1;
                qg1.Diem += 1;

                qg2.BT += short.Parse(td.TySo2.ToString());
                qg2.SBT += short.Parse(td.TySo1.ToString());
                qg2.Hoa += 1;
                qg2.Diem += 1;
                qg1.HS = (short)(qg1.BT - qg1.SBT);
                qg2.HS = (short)(qg2.BT - qg2.SBT);
                context.SaveChanges();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
