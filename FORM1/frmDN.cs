using FORM2;
using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Windows.Forms;

namespace FORM1
{
    public partial class frmDN : DevExpress.XtraEditors.XtraForm
    {
        private QLBD context = new QLBD();
        public frmDN()
        {
            InitializeComponent();
        }

        private void frmDN_Load(object sender, EventArgs e)
        {
            txtmk.Properties.PasswordChar = '*';
            txttk.Text = Properties.Settings.Default.tk;
            txtmk.Text = Properties.Settings.Default.mk;
            if (Properties.Settings.Default.tk != "")
            {
                chkLuu.Checked = true;
            }
            Properties.Settings.Default.Reset();
        }
        private bool KT(List<TaiKhoan> a)
        {
            foreach (TaiKhoan t in a)
            {
                if (t.TaiKhoan1 == txttk.Text)
                    return true;
            }
            return false;
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //List<TaiKhoan> tk = context.TaiKhoans.ToList();
            //if (!KT(tk))
            //{
            //    txtmk.Text = "";
            //    txttk.Text = "";
            //    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txttk.Focus();
            //}
            //TaiKhoan a = context.TaiKhoans.FirstOrDefault(p => p.TaiKhoan1 == txttk.Text);
            //if (a.MauKhau == txtmk.Text)
            //{
            //    txtmk.Text = "";
            //    txttk.Text = "";
            //    MessageBox.Show("Chào mừng User đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtmk.Text = "";
            //    txttk.Text = "";
            //    txttk.Focus();
            //}
        }

        private void txttk_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtmk_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtmk, "Vui long nhap vao mat khau");
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
            if (chkHienThi.Checked==false)
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

        private void lbldangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDK frm = new frmDK();
            frm.ShowDialog();
        }
    }
}
