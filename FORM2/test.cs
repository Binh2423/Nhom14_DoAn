using DevExpress.XtraPrintingLinks;
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
using System.Xml.Serialization;

namespace FORM2
{
    public partial class test : Form
    {
        private QLBD context = new QLBD();
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            BindGrid(context.QuocGia.ToList());
        }
        private void BindGrid(List<QuocGia> l)
        {
            foreach (QuocGia q in l)
            {
                int i = QG.Rows.Add();
                QG.Rows[i].Cells[0].Value = q.MaQG;
                QG.Rows[i].Cells[1].Value = q.TenQG;
                QG.Rows[i].Cells[2].Value = q.QuocKy;
            }
        }
    }
}
