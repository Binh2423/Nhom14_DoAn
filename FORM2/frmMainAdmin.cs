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
using WindowsFormsApp1;

namespace FORM2
{
    public partial class frmMainAdmin : Form
    {
        private Form ChildFrm;
        private void OpenForm(Form Child)
        {
            if (ChildFrm != null)
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
        public frmMainAdmin()
        {
            InitializeComponent();
        }


        private void btnTranDau_Click(object sender, EventArgs e)
        {
            OpenForm(new frmTD());
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            OpenForm(new frmBXH());
        }

        private void btnCauThu_Click(object sender, EventArgs e)
        {
            OpenForm(new frmTKCT());
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            OpenForm(new frmThemCT());
        }

        private void btnThemTD_Click(object sender, EventArgs e)
        {
            OpenForm(new frmThemTD());
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            OpenForm(new frmQLTK());
        }

        private void btnXHCT_Click(object sender, EventArgs e)
        {
            OpenForm(new frmXHCT());
        }
    }
}
