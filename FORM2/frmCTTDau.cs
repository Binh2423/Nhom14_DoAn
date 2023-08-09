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
    public partial class frmCTTDau : Form
    {
        public frmCTTDau()
        {
            InitializeComponent();
        }

        public frmCTTDau(string QG1,string QG2,DateTime dt,int TS1,int TS2) : this() 
        {
            InitializeComponent();
            dtp.Value = dt;
            lblQG1.Text = QG1;
            lblQG2.Text = QG2;
            lblTS1.Text = TS1.ToString();
            lblTS2.Text = TS2.ToString();
        }

        private void frmCTTDau_Load(object sender, EventArgs e)
        {

        }
    }
}
