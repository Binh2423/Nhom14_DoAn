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
    public partial class frmQLTK : Form
    {
        QLBD context = new QLBD();
        public frmQLTK()
        {
            InitializeComponent();
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            BindGrid(context.TaiKhoan.ToList());
        }
        private void BindGrid(List<TaiKhoan> list)
        {
            foreach(TaiKhoan item in list)
            {
                ListViewItem item2 = lvTK.Items.Add(item.TaiKhoan1);
                item2.SubItems.Add(item.MauKhau);
                item2.SubItems.Add(item.Email);
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            var tk = context.TaiKhoan.ToList();
            lvTK.Items.Clear();
            BindGrid(tk.Where(o => o.TaiKhoan1.Contains(txtTim.Text)).ToList());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var tk = context.TaiKhoan.FirstOrDefault(o=>o.TaiKhoan1.Equals(txtTim.Text));
            if (tk != null)
            {
                context.TaiKhoan.Remove(tk);
                context.SaveChanges();
                MessageBox.Show("Xóa tài khoản thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lvTK.Items.Clear();
            BindGrid(context.TaiKhoan.ToList());
        }

        private void lvTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvTK.SelectedItems.Count > 0)
            {
                txtTim.Text = lvTK.SelectedItems[0].SubItems[0].Text;
            }
        }
    }
}
