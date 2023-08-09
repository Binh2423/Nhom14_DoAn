using FORM2.Data;
using System.Collections.Generic;
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
          
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            CauThu ct = new CauThu()
            {
                TenCauThu = txthoten.Text,
            };
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
                txthoten.Focus();
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
            ofd.Filter = "| *.jpg || *.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbn14.Load(ofd.FileName);
            }
        }
    }
}
