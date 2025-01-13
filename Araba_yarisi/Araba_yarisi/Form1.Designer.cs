namespace Araba_yarisi
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.puan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yol2 = new System.Windows.Forms.PictureBox();
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.bizim_araba = new System.Windows.Forms.PictureBox();
            this.carpma = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yol1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizim_araba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.Location = new System.Drawing.Point(236, 442);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(38, 28);
            this.puan.TabIndex = 9;
            this.puan.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(140, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Skor:";
            // 
            // yol2
            // 
            this.yol2.Image = global::Araba_yarisi.Properties.Resources.yol;
            this.yol2.Location = new System.Drawing.Point(-2, -638);
            this.yol2.Name = "yol2";
            this.yol2.Size = new System.Drawing.Size(385, 630);
            this.yol2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol2.TabIndex = 3;
            this.yol2.TabStop = false;
            // 
            // araba1
            // 
            this.araba1.Image = global::Araba_yarisi.Properties.Resources.araba4;
            this.araba1.Location = new System.Drawing.Point(51, 48);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(60, 127);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.araba1.TabIndex = 4;
            this.araba1.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = global::Araba_yarisi.Properties.Resources.araba5;
            this.araba2.Location = new System.Drawing.Point(283, 114);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(58, 117);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.araba2.TabIndex = 5;
            this.araba2.TabStop = false;
            // 
            // bizim_araba
            // 
            this.bizim_araba.Image = global::Araba_yarisi.Properties.Resources.araba9;
            this.bizim_araba.Location = new System.Drawing.Point(166, 293);
            this.bizim_araba.Name = "bizim_araba";
            this.bizim_araba.Size = new System.Drawing.Size(65, 129);
            this.bizim_araba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bizim_araba.TabIndex = 6;
            this.bizim_araba.TabStop = false;
            // 
            // carpma
            // 
            this.carpma.Image = global::Araba_yarisi.Properties.Resources.explosion;
            this.carpma.Location = new System.Drawing.Point(198, 223);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(64, 64);
            this.carpma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.carpma.TabIndex = 12;
            this.carpma.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.carpma);
            this.panel1.Controls.Add(this.bizim_araba);
            this.panel1.Controls.Add(this.araba2);
            this.panel1.Controls.Add(this.araba1);
            this.panel1.Controls.Add(this.yol2);
            this.panel1.Controls.Add(this.yol1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 425);
            this.panel1.TabIndex = 1;
            // 
            // yol1
            // 
            this.yol1.Image = global::Araba_yarisi.Properties.Resources.yol;
            this.yol1.Location = new System.Drawing.Point(-2, -222);
            this.yol1.Name = "yol1";
            this.yol1.Size = new System.Drawing.Size(385, 630);
            this.yol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol1.TabIndex = 2;
            this.yol1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bizim_araba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpma)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox yol2;
        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.PictureBox bizim_araba;
        private System.Windows.Forms.PictureBox carpma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol1;
    }
}

