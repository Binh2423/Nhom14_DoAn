using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FORM2
{
    
    public partial class frmDK : DevExpress.XtraEditors.XtraForm
    {
        private QLBD context = new QLBD();
        public frmDK()
        {
            InitializeComponent();
        }

        private void frmDK_Load(object sender, EventArgs e)
        {
            txtmk.Properties.PasswordChar = '*';
            txtxnmk.Properties.PasswordChar = '*';
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan()
            {
                TaiKhoan1 = txttk.Text,
                MauKhau = txtmk.Text,
                Email = txtgm.Text,
            };
            context.TaiKhoan.Add(tk);
            context.SaveChanges();
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
            string pattern = "(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*]).{6,}";
            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtmk, "Vui lòng nhập mật khẩu");
                txtmk.Focus();
            }

            else if (!Regex.Match(txtmk.Text, pattern).Success)
            {
                errorProvider1.SetError(txtmk, "Vui lòng nhập lại mật khẩu theo định dạng");
                txtmk.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtmk, "");
            }
        }

        private void txtxnmk_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtxnmk.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtxnmk, "Vui lòng nhập lại mật khẩu");
                txtmk.Focus();
            }
            else if (!txtxnmk.Text.Equals(txtmk.Text)) {
                e.Cancel = true;
                errorProvider1.SetError(txtxnmk, "Mật khẩu không trùng khớp");
                txtmk.Focus();
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtxnmk, "");
            }
        }

        private void txtgm_Validating(object sender, CancelEventArgs e)
        {
            string pattern = "^[\\w\\-\\.]+@([\\w-]+\\.)+[\\w-]{2,}$";
            if (string.IsNullOrWhiteSpace(txtgm.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtgm, "Vui lòng nhập vào email");
                txtmk.Focus();
            }

            else if (!Regex.Match(txtgm.Text, pattern).Success)
            {
                errorProvider1.SetError(txtgm, "Vui lòng nhập email theo định dạng");
                txtmk.Focus();
                e.Cancel = true;
            }
            else if (context.TaiKhoan.FirstOrDefault(o => o.Email == txtgm.Text) != null)
            {
                errorProvider1.SetError(txtgm, "Email đã tồn tại!! Vui lòng nhập lại email?");
                txtmk.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtgm, "");
            }

        }

        private void cbkHMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkHMK.Checked == false)
            {
                txtmk.Properties.PasswordChar = '*';
                txtxnmk.Properties.PasswordChar = '*';
            }
            else
            {
                txtmk.Properties.PasswordChar = (char)0;
                txtxnmk.Properties.PasswordChar = (char)0;
            }
        }
    }
}
