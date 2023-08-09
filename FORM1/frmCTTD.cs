using FORM2.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FORM2
{
    public static class IEnumerable
    {
        public static IEnumerable<TSource> TopWithTies<TSource, TValue>(
    this IEnumerable<TSource> source,
    int count,
    Func<TSource, TValue> selector)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (selector == null) throw new ArgumentNullException("selector");
            if (count < 0) throw new ArgumentOutOfRangeException("count");
            if (count == 0) yield break;
            using (var iter = source.OrderByDescending(selector).GetEnumerator())
            {
                if (iter.MoveNext())
                {
                    yield return iter.Current;
                    while (--count >= 0)
                    {
                        if (!iter.MoveNext()) yield break;
                        yield return iter.Current;
                    }
                    var lastVal = selector(iter.Current);
                    var eq = EqualityComparer<TValue>.Default;
                    while (iter.MoveNext() && eq.Equals(lastVal, selector(iter.Current)))
                    {
                        yield return iter.Current;
                    }
                }
            }
        }
    }
    public partial class frmCTTD : Form
    {
        public frmCTTD()
        {
            InitializeComponent();
        }
        private QLBD context = new QLBD();


        private void frmCTTD_Load(object sender, EventArgs e)
        {

            var list = context.CauThu.ToList().TopWithTies(4, o => o.SoBanThang).ToList();
            BindData(list);
        }

        private void BindData(List<CauThu> list)
        {
            var a = context.CauThu.ToList().TopWithTies(4, o => o.SoBanThang).ToList();
            int i = 0;
            foreach (CauThu ct in list)
            {
                Label lblXH = new Label();
                Label lblTen = new Label();
                Label lblQG = new Label();
                Label lblBT = new Label();
                PictureBox ptbCT = new PictureBox();
                PictureBox ptbQK = new PictureBox();
                //lblXH.AutoSize = true;
                //lblXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //lblXH.Location = new System.Drawing.Point(37, 138 + 100*i);
                //lblXH.Name = "label4"+i.ToString();
                //lblXH.Size = new System.Drawing.Size(31, 32);
                //lblXH.TabIndex = 3;
                //lblXH.Text = "";
                // 
                // label5
                // 
                lblTen.AutoSize = true;
                lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblTen.Location = new System.Drawing.Point(228, 125 + 100 * i);
                lblTen.Name = "label5" + i.ToString();
                lblTen.Size = new System.Drawing.Size(59, 29);
                lblTen.TabIndex = 4;
                lblTen.Text = ct.TenCauThu;
                // 
                // label6
                // 
                lblQG.AutoSize = true;
                lblQG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblQG.Location = new System.Drawing.Point(293, 179 + 100 * i);
                lblQG.Name = "label6" + i.ToString();
                lblQG.Size = new System.Drawing.Size(99, 25);
                lblQG.TabIndex = 5;
                lblQG.Text = ct.QuocGia.TenQG;
                // 
                // label7
                // 
                lblBT.AutoSize = true;
                lblBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblBT.Location = new System.Drawing.Point(874, 138 + 100 * i);
                lblBT.Name = "label7" + i.ToString();
                lblBT.Size = new System.Drawing.Size(31, 32);
                lblBT.TabIndex = 6;
                lblBT.Text = ct.SoBanThang.ToString();
                // 
                // ptbCT
                // 
                Byte[] MyData1 = new byte[0];
                MyData1 = (Byte[])ct.HinhAnhCT;
                MemoryStream stream1 = new MemoryStream(MyData1);
                stream1.Position = 0;
                ptbCT.Image = Image.FromStream(stream1);
                ptbCT.Location = new System.Drawing.Point(111, 115 + 100 * i);
                ptbCT.Name = "ptbCT" + i.ToString();
                ptbCT.Size = new System.Drawing.Size(90, 89);
                ptbCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                ptbCT.TabIndex = 7;
                ptbCT.TabStop = false;
                Rectangle r = new Rectangle(0, 0, ptbCT.Width, ptbCT.Height);
                System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

                gp.AddEllipse(0, 0, ptbCT.Width - 3, ptbCT.Height - 3);
                Region rg = new Region(gp);
                ptbCT.Region = rg;
                // 
                // pictureBox2
                // 
                Byte[] MyData2 = new byte[0];
                MyData2 = (Byte[])ct.QuocGia.QuocKy;
                MemoryStream stream2 = new MemoryStream(MyData2);
                stream2.Position = 0;
                ptbQK.Image = Image.FromStream(stream2);
                ptbQK.Location = new System.Drawing.Point(228, 173 + 100 * i);
                ptbQK.Name = "pictureBox2" + i.ToString();
                ptbQK.Size = new System.Drawing.Size(59, 31);
                ptbQK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                ptbQK.TabIndex = 8;
                ptbQK.TabStop = false;

                this.Controls.Add(ptbQK);
                this.Controls.Add(ptbCT);
                this.Controls.Add(lblBT);
                this.Controls.Add(lblQG);
                this.Controls.Add(lblTen);
                this.Controls.Add(lblXH);
                i++;
            }
        }
    }
}
