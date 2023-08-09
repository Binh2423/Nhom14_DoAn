using FORM2;
using FORM2.Data;
using FORM5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBXH : Form
    {
        private QLBD context = new QLBD();
        public frmBXH()
        {
            InitializeComponent();
        }

        private void frmBXH_Load(object sender, EventArgs e)
        {
            cboBang.DataSource = context.Bang.ToList();
            cboBang.DisplayMember = "TenBang";
            cboBang.ValueMember = "MaBang";
            cboNam.SelectedIndex = 2;
            cboBang.SelectedIndex = 0;
            lblBang.Text = cboBang.Text;
            BindGrid(context.XepHang.ToList().Where(o => o.MaBang == "A").OrderByDescending(o=> o.Diem).ToList());
       
        }
       
        private void BindGrid(List<XepHang> list)
        {
            lvBangXH.Items.Clear();
            foreach(XepHang xep in list)
            {
                
                ListViewItem item = lvBangXH.Items.Add((lvBangXH.Items.Count+1).ToString());
                item.SubItems.Add(xep.QuocGia.TenQG);
                item.SubItems.Add(xep.DD.ToString());
                item.SubItems.Add(xep.Thang.ToString());
                item.SubItems.Add(xep.Hoa.ToString());
                item.SubItems.Add(xep.Thua.ToString());
                item.SubItems.Add(xep.BT.ToString());
                item.SubItems.Add(xep.SBT.ToString());
                item.SubItems.Add(xep.HS.ToString());
                item.SubItems.Add(xep.Diem.ToString()); 
            }
        }

        private void cboBang_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblBang.Text = cboBang.Text;
            BindGrid(context.XepHang.ToList().Where(o => o.MaBang == (cboBang.SelectedItem as Bang).MaBang).OrderByDescending(o => o.Diem).ToList());
        }
    }
}
