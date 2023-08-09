using DevExpress.XtraExport.Xls;
using FORM2;
using FORM2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class frmTD : Form
    {
        private QLBD context = new QLBD();
        public frmTD()
        {
            InitializeComponent();
        }

        private void frmTD_Load(object sender, EventArgs e)
        {
            BindControl(context.TranDau.ToList().OrderBy(o => o.NgayDa).ToList());
           
        }
       
        private void BindControl(List<TranDau> list)
        {

            int i = 1;

            foreach(TranDau td in list)
            {
                PictureBox ptB1 = new PictureBox();
                PictureBox ptB2 = new PictureBox();
                Label lblQG1 = new Label();
                Label lblQG2 = new Label();
                Label lblTS = new Label();
                DateTimePicker dtp = new DateTimePicker();
               
                dtp.Location = new System.Drawing.Point(12, 12 + 120 * i);
                dtp.Name = "dtp"+ i.ToString();
                dtp.Size = new System.Drawing.Size(700, 22);
                dtp.TabIndex = 0;
                dtp.Value = td.NgayDa;
                dtp.Enabled = false;
                dtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                // 
                // ptB1
                // 
                Byte[] MyData1 = new byte[0];
                MyData1 = (Byte[])td.QuocGia.QuocKy;
                MemoryStream stream1 = new MemoryStream(MyData1);
                stream1.Position = 0;

                ptB1.Location = new System.Drawing.Point(36, 63 + 120 * i);
                ptB1.Name = "ptB1" + i.ToString();
                ptB1.Size = new System.Drawing.Size(120, 50);
                ptB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                ptB1.TabIndex = 1;
                ptB1.TabStop = false;
                ptB1.Image = Image.FromStream(stream1);

                // 
                // ptB2
                // 
                Byte[] MyData2 = new byte[0];
                MyData2 = (Byte[])td.QuocGia2.QuocKy;
                MemoryStream stream2 = new MemoryStream(MyData2);
                stream2.Position = 0;
                ptB2.Location = new System.Drawing.Point(600, 63 + 120 * i);
                ptB2.Name = "ptB2" + i.ToString();
                ptB2.Size = new System.Drawing.Size(120, 50);
                ptB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                ptB2.TabIndex = 2;
                ptB2.TabStop = false;
                ptB2.Image = Image.FromStream(stream2);
                // 
                // lblQG1
                // 

                lblQG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblQG1.Location = new System.Drawing.Point(160, 77 + 120 * i);
                lblQG1.Name = "lblQG1" + i.ToString();
                lblQG1.Size = new System.Drawing.Size(64, 25);
                lblQG1.TabIndex = 3;
                lblQG1.Text = td.MaQG;
                // 
                // lblQG2
                // 
               
                lblQG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblQG2.Location = new System.Drawing.Point(548, 77 + 120 * i);
                lblQG2.Name = "lblQG2" + i.ToString();
                lblQG2.Size = new System.Drawing.Size(45, 25);
                lblQG2.TabIndex = 4;
                lblQG2.Text = td.MaQG2;
                // 
                // lblTS
                // 
                
                lblTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTS.Location = new System.Drawing.Point(334, 77 + 120 * i);
                lblTS.Name = "lblTS" + i.ToString();
                lblTS.Size = new System.Drawing.Size(64, 25);
                lblTS.TabIndex = 5;
                lblTS.Text = td.TySo1 + " - " + td.TySo2;
                Controls.Add(lblTS);
                Controls.Add(lblQG2);
                Controls.Add(lblQG1);
                Controls.Add(ptB2);
                Controls.Add(ptB1);
                Controls.Add(dtp);
                i++;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThemTD frm = new frmThemTD();
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
