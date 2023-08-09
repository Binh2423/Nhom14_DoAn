using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                errorProvider1.SetError(txttk, "Vui long nhap vao tai khoan");
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
                errorProvider1.SetError(txtmk, "Vui long nhap vao mat khau");
                txtmk.Focus();
            }

            else if (!Regex.Match(txtmk.Text, pattern).Success)
            {
                errorProvider1.SetError(txtmk, "Vui long nhap mat khau theo dinh dang");
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
                errorProvider1.SetError(txtxnmk, "Vui long nhap vao mat khau");
                txtmk.Focus();
            }
            else if (!txtxnmk.Text.Equals(txtmk.Text)) {
                e.Cancel = true;
                errorProvider1.SetError(txtxnmk, "Mat khau khong trung khop");
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
                errorProvider1.SetError(txtgm, "Vui long nhap vao email");
                txtmk.Focus();
            }

            else if (!Regex.Match(txtgm.Text, pattern).Success)
            {
                errorProvider1.SetError(txtgm, "Vui long nhap email theo dinh dang");
                txtmk.Focus();
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtgm, "");
            }
        }
    }
}
