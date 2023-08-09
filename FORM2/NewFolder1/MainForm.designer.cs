
namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXHCT = new System.Windows.Forms.Button();
            this.btnCauThu = new System.Windows.Forms.Button();
            this.btnBXH = new System.Windows.Forms.Button();
            this.btnTranDau = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnXHCT);
            this.panel1.Controls.Add(this.btnCauThu);
            this.panel1.Controls.Add(this.btnBXH);
            this.panel1.Controls.Add(this.btnTranDau);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 139);
            this.panel1.TabIndex = 0;
            // 
            // btnXHCT
            // 
            this.btnXHCT.BackColor = System.Drawing.Color.Yellow;
            this.btnXHCT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnXHCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXHCT.ForeColor = System.Drawing.Color.Blue;
            this.btnXHCT.Location = new System.Drawing.Point(657, 42);
            this.btnXHCT.Name = "btnXHCT";
            this.btnXHCT.Size = new System.Drawing.Size(339, 97);
            this.btnXHCT.TabIndex = 3;
            this.btnXHCT.Text = "Xếp hạng cầu thủ";
            this.btnXHCT.UseVisualStyleBackColor = false;
            this.btnXHCT.Click += new System.EventHandler(this.btnXHCT_Click);
            // 
            // btnCauThu
            // 
            this.btnCauThu.BackColor = System.Drawing.Color.Yellow;
            this.btnCauThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCauThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauThu.ForeColor = System.Drawing.Color.Blue;
            this.btnCauThu.Location = new System.Drawing.Point(470, 42);
            this.btnCauThu.Name = "btnCauThu";
            this.btnCauThu.Size = new System.Drawing.Size(187, 97);
            this.btnCauThu.TabIndex = 2;
            this.btnCauThu.Text = "Cầu thủ";
            this.btnCauThu.UseVisualStyleBackColor = false;
            this.btnCauThu.Click += new System.EventHandler(this.btnCauThu_Click);
            // 
            // btnBXH
            // 
            this.btnBXH.BackColor = System.Drawing.Color.Yellow;
            this.btnBXH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBXH.ForeColor = System.Drawing.Color.Blue;
            this.btnBXH.Location = new System.Drawing.Point(207, 42);
            this.btnBXH.Name = "btnBXH";
            this.btnBXH.Size = new System.Drawing.Size(263, 97);
            this.btnBXH.TabIndex = 1;
            this.btnBXH.Text = "Bảng xếp hạng";
            this.btnBXH.UseVisualStyleBackColor = false;
            this.btnBXH.Click += new System.EventHandler(this.btnBXH_Click);
            // 
            // btnTranDau
            // 
            this.btnTranDau.BackColor = System.Drawing.Color.Yellow;
            this.btnTranDau.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTranDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranDau.ForeColor = System.Drawing.Color.Blue;
            this.btnTranDau.Location = new System.Drawing.Point(0, 42);
            this.btnTranDau.Name = "btnTranDau";
            this.btnTranDau.Size = new System.Drawing.Size(207, 97);
            this.btnTranDau.TabIndex = 0;
            this.btnTranDau.Text = "Trận Đấu";
            this.btnTranDau.UseVisualStyleBackColor = false;
            this.btnTranDau.Click += new System.EventHandler(this.btnTranDau_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải Vô Địch Đông Nam Á";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 555);
            this.panel2.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTranDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCauThu;
        private System.Windows.Forms.Button btnBXH;
        private System.Windows.Forms.Button btnXHCT;
    }
}