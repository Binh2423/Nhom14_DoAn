using FORM2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private Form ChildFrm;
        private void OpenForm(Form Child)
        {
             if(ChildFrm!= null)
            {
                ChildFrm.Close();
            }
            ChildFrm = Child;
            ChildFrm.TopLevel = false;
            ChildFrm.FormBorderStyle = FormBorderStyle.None;
            ChildFrm.Dock = DockStyle.Fill;
            panel2.Controls.Add(ChildFrm);
            panel2.Tag = ChildFrm;
            ChildFrm.BringToFront();
            ChildFrm.Show();

        }
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btnTranDau_Click(object sender, EventArgs e)
        {

            //this.Hide();
            //frmTD td = new frmTD();
            //td.ShowDialog();
            OpenForm(new frmTD());
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmBXH BXH = new frmBXH();
            //BXH.ShowDialog();
            OpenForm(new frmBXH());
        }

        private void btnCauThu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmTKCT ct  = new frmTKCT();
            //ct.ShowDialog();
            OpenForm(new frmTKCT(1));
        }

        private void btnTinTuc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmTinTuc tt = new frmTinTuc();
            //tt.ShowDialog();
            OpenForm(new frmTinTuc());
        }

        private void btnXHCT_Click(object sender, EventArgs e)
        {
            OpenForm(new frmXHCT());
        }
    }
}
