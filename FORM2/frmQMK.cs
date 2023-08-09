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

namespace FORM2
{
    public partial class frmQMK : Form
    {
        private QLBD context = new QLBD();
        public frmQMK()
        {
            InitializeComponent();
        }

        private void frmQMK_Load(object sender, EventArgs e)
        {

        }

        private void txtLayMK_Click(object sender, EventArgs e)
        {
            var tk = context.TaiKhoan.FirstOrDefault(o => o.Email.Equals(txtgm.Text));
            lblMK.Text = tk.MauKhau.ToString();
            txtgm.Text = "";
        }

        private void txtgm_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtgm.Text))
            {
                e.Cancel = true;
                errP.SetError(txtgm, "Vui lòng nhập vào email");
                txtgm.Focus();
                lblMK.Text = null;
            }
            else if (context.TaiKhoan.FirstOrDefault(o => o.Email.Equals(txtgm.Text)) == null)
            {
                e.Cancel = true;
                MessageBox.Show("Email này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblMK.Text = null;
            }
            else
            {
                e.Cancel = false;
                errP.SetError(txtgm, "");
                lblMK.Text = null;
            }
        }
    }
}
