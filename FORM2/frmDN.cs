using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace FORM2
{
    public partial class frmDN : Form
    {
        private QLBD context = new QLBD();
        public frmDN()
        {
            InitializeComponent();
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            txtmk.Properties.PasswordChar = '*';
            txtmk.Text = Properties.Settings.Default.mk;
            txttk.Text = Properties.Settings.Default.tk;
        }

        private void txttk_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttk.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txttk, "Vui lòng nhập vào tài khoản");
                txttk.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txttk, "");
            }
        }

        private void txtmk_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtmk, "Vui lòng nhập vào mật khẩu");
                txtmk.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmk, "");
            }
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == false)
                txtmk.Properties.PasswordChar = '*';
            else
                txtmk.Properties.PasswordChar = (char)0;
        }

        private void chkLuu_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLuu.Checked)
            {
                Properties.Settings.Default.tk = txttk.Text;
                Properties.Settings.Default.mk = txtmk.Text;
                Properties.Settings.Default.Save();
            }
            else
                Properties.Settings.Default.Reset();
        }

        private void lbldangky_Click(object sender, EventArgs e)
        {
            frmDK frm = new frmDK();
            frm.ShowDialog();
        }

        private void lblQuenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQMK frm = new frmQMK();
            frm.ShowDialog();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            var check = context.TaiKhoan.FirstOrDefault(o=>o.TaiKhoan1.Equals(txttk.Text));
            if(check != null)
            {
                if(check.TaiKhoan1 == "AdminN14" && txtmk.Text == "Nhom14@#1BQT4#@")
                {
                    MessageBox.Show("Quản lý đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMainAdmin frm = new frmMainAdmin();
                    frm.ShowDialog();
                    this.Hide();
                }
                else if(check.TaiKhoan1 != "AdminN14" && check.MauKhau == txtmk.Text)
                {
                    MessageBox.Show("Đăng nhập thành công","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm frm = new MainForm();
                    frm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản này không tồn tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
