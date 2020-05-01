/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Kader Miyanyedi
**				ÖĞRENCİ NUMARASI.......: B191210380
**              DERSİN ALINDIĞI GRUP...: 1C
****************************************************************************/
namespace Atik_Projesi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonYeniOyun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSure = new System.Windows.Forms.Label();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxOrganik = new System.Windows.Forms.ListBox();
            this.progressBarOrganik = new System.Windows.Forms.ProgressBar();
            this.buttonBosaltOrganik = new System.Windows.Forms.Button();
            this.buttonEkleOrganik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBoxKagit = new System.Windows.Forms.ListBox();
            this.progressBarKagit = new System.Windows.Forms.ProgressBar();
            this.buttonBosaltKagit = new System.Windows.Forms.Button();
            this.buttonEkleKagit = new System.Windows.Forms.Button();
            this.listBoxCam = new System.Windows.Forms.ListBox();
            this.progressBarCam = new System.Windows.Forms.ProgressBar();
            this.buttonBosaltCam = new System.Windows.Forms.Button();
            this.buttonEkleCam = new System.Windows.Forms.Button();
            this.listBoxMetal = new System.Windows.Forms.ListBox();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.buttonBosaltMetal = new System.Windows.Forms.Button();
            this.buttonEkleMetal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 280);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(13, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.buttonYeniOyun);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.labelPuan);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelSure);
            this.panel2.Controls.Add(this.buttonCikis);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 464);
            this.panel2.TabIndex = 1;
            // 
            // buttonYeniOyun
            // 
            this.buttonYeniOyun.BackColor = System.Drawing.Color.Teal;
            this.buttonYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonYeniOyun.ForeColor = System.Drawing.Color.White;
            this.buttonYeniOyun.Location = new System.Drawing.Point(13, 8);
            this.buttonYeniOyun.Name = "buttonYeniOyun";
            this.buttonYeniOyun.Size = new System.Drawing.Size(224, 70);
            this.buttonYeniOyun.TabIndex = 11;
            this.buttonYeniOyun.Text = "YENİ OYUN";
            this.buttonYeniOyun.UseVisualStyleBackColor = false;
            this.buttonYeniOyun.Click += new System.EventHandler(this.buttonYeniOyun_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = "PUAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPuan
            // 
            this.labelPuan.BackColor = System.Drawing.Color.White;
            this.labelPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuan.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelPuan.Location = new System.Drawing.Point(13, 308);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(224, 76);
            this.labelPuan.TabIndex = 9;
            this.labelPuan.Text = "0";
            this.labelPuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 63);
            this.label3.TabIndex = 8;
            this.label3.Text = "SÜRE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSure
            // 
            this.labelSure.BackColor = System.Drawing.Color.White;
            this.labelSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSure.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelSure.Location = new System.Drawing.Point(13, 148);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(224, 76);
            this.labelSure.TabIndex = 7;
            this.labelSure.Text = "60";
            this.labelSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Teal;
            this.buttonCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCikis.ForeColor = System.Drawing.Color.White;
            this.buttonCikis.Location = new System.Drawing.Point(13, 392);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(224, 64);
            this.buttonCikis.TabIndex = 6;
            this.buttonCikis.Text = "CIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.listBoxOrganik);
            this.panel3.Controls.Add(this.progressBarOrganik);
            this.panel3.Controls.Add(this.buttonBosaltOrganik);
            this.panel3.Controls.Add(this.buttonEkleOrganik);
            this.panel3.Location = new System.Drawing.Point(290, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 350);
            this.panel3.TabIndex = 2;
            // 
            // listBoxOrganik
            // 
            this.listBoxOrganik.FormattingEnabled = true;
            this.listBoxOrganik.Location = new System.Drawing.Point(20, 60);
            this.listBoxOrganik.Name = "listBoxOrganik";
            this.listBoxOrganik.Size = new System.Drawing.Size(165, 199);
            this.listBoxOrganik.TabIndex = 10;
            // 
            // progressBarOrganik
            // 
            this.progressBarOrganik.Location = new System.Drawing.Point(20, 263);
            this.progressBarOrganik.Name = "progressBarOrganik";
            this.progressBarOrganik.Size = new System.Drawing.Size(165, 23);
            this.progressBarOrganik.TabIndex = 9;
            // 
            // buttonBosaltOrganik
            // 
            this.buttonBosaltOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBosaltOrganik.Location = new System.Drawing.Point(20, 292);
            this.buttonBosaltOrganik.Name = "buttonBosaltOrganik";
            this.buttonBosaltOrganik.Size = new System.Drawing.Size(165, 46);
            this.buttonBosaltOrganik.TabIndex = 8;
            this.buttonBosaltOrganik.Text = "BOŞALT";
            this.buttonBosaltOrganik.UseVisualStyleBackColor = true;
            this.buttonBosaltOrganik.Click += new System.EventHandler(this.buttonBosaltOrganik_Click);
            // 
            // buttonEkleOrganik
            // 
            this.buttonEkleOrganik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkleOrganik.Location = new System.Drawing.Point(20, 15);
            this.buttonEkleOrganik.Name = "buttonEkleOrganik";
            this.buttonEkleOrganik.Size = new System.Drawing.Size(165, 39);
            this.buttonEkleOrganik.TabIndex = 7;
            this.buttonEkleOrganik.Text = "ORGANİK ATIK";
            this.buttonEkleOrganik.UseVisualStyleBackColor = true;
            this.buttonEkleOrganik.Click += new System.EventHandler(this.buttonEkleOrganik_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.listBoxKagit);
            this.panel4.Controls.Add(this.buttonEkleKagit);
            this.panel4.Controls.Add(this.progressBarKagit);
            this.panel4.Controls.Add(this.buttonBosaltKagit);
            this.panel4.Location = new System.Drawing.Point(498, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 350);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Controls.Add(this.listBoxMetal);
            this.panel5.Controls.Add(this.buttonEkleMetal);
            this.panel5.Controls.Add(this.progressBarMetal);
            this.panel5.Controls.Add(this.buttonBosaltMetal);
            this.panel5.Location = new System.Drawing.Point(498, 421);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 350);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.listBoxCam);
            this.panel6.Controls.Add(this.buttonEkleCam);
            this.panel6.Controls.Add(this.progressBarCam);
            this.panel6.Controls.Add(this.buttonBosaltCam);
            this.panel6.Location = new System.Drawing.Point(290, 421);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 350);
            this.panel6.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBoxKagit
            // 
            this.listBoxKagit.FormattingEnabled = true;
            this.listBoxKagit.Location = new System.Drawing.Point(19, 60);
            this.listBoxKagit.Name = "listBoxKagit";
            this.listBoxKagit.Size = new System.Drawing.Size(165, 199);
            this.listBoxKagit.TabIndex = 14;
            // 
            // progressBarKagit
            // 
            this.progressBarKagit.Location = new System.Drawing.Point(19, 263);
            this.progressBarKagit.Name = "progressBarKagit";
            this.progressBarKagit.Size = new System.Drawing.Size(165, 23);
            this.progressBarKagit.TabIndex = 13;
            // 
            // buttonBosaltKagit
            // 
            this.buttonBosaltKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBosaltKagit.Location = new System.Drawing.Point(19, 292);
            this.buttonBosaltKagit.Name = "buttonBosaltKagit";
            this.buttonBosaltKagit.Size = new System.Drawing.Size(165, 46);
            this.buttonBosaltKagit.TabIndex = 12;
            this.buttonBosaltKagit.Text = "BOŞALT";
            this.buttonBosaltKagit.UseVisualStyleBackColor = true;
            this.buttonBosaltKagit.Click += new System.EventHandler(this.buttonBosaltKagit_Click);
            // 
            // buttonEkleKagit
            // 
            this.buttonEkleKagit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkleKagit.Location = new System.Drawing.Point(19, 15);
            this.buttonEkleKagit.Name = "buttonEkleKagit";
            this.buttonEkleKagit.Size = new System.Drawing.Size(165, 39);
            this.buttonEkleKagit.TabIndex = 11;
            this.buttonEkleKagit.Text = "KAĞIT";
            this.buttonEkleKagit.UseVisualStyleBackColor = true;
            this.buttonEkleKagit.Click += new System.EventHandler(this.buttonEkleKagit_Click);
            // 
            // listBoxCam
            // 
            this.listBoxCam.FormattingEnabled = true;
            this.listBoxCam.Location = new System.Drawing.Point(20, 63);
            this.listBoxCam.Name = "listBoxCam";
            this.listBoxCam.Size = new System.Drawing.Size(165, 199);
            this.listBoxCam.TabIndex = 14;
            // 
            // progressBarCam
            // 
            this.progressBarCam.Location = new System.Drawing.Point(20, 266);
            this.progressBarCam.Name = "progressBarCam";
            this.progressBarCam.Size = new System.Drawing.Size(165, 23);
            this.progressBarCam.TabIndex = 13;
            // 
            // buttonBosaltCam
            // 
            this.buttonBosaltCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBosaltCam.Location = new System.Drawing.Point(20, 295);
            this.buttonBosaltCam.Name = "buttonBosaltCam";
            this.buttonBosaltCam.Size = new System.Drawing.Size(165, 46);
            this.buttonBosaltCam.TabIndex = 12;
            this.buttonBosaltCam.Text = "BOŞALT";
            this.buttonBosaltCam.UseVisualStyleBackColor = true;
            this.buttonBosaltCam.Click += new System.EventHandler(this.buttonBosaltCam_Click);
            // 
            // buttonEkleCam
            // 
            this.buttonEkleCam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkleCam.Location = new System.Drawing.Point(20, 18);
            this.buttonEkleCam.Name = "buttonEkleCam";
            this.buttonEkleCam.Size = new System.Drawing.Size(165, 39);
            this.buttonEkleCam.TabIndex = 11;
            this.buttonEkleCam.Text = "CAM";
            this.buttonEkleCam.UseVisualStyleBackColor = true;
            this.buttonEkleCam.Click += new System.EventHandler(this.buttonEkleCam_Click);
            // 
            // listBoxMetal
            // 
            this.listBoxMetal.FormattingEnabled = true;
            this.listBoxMetal.Location = new System.Drawing.Point(19, 63);
            this.listBoxMetal.Name = "listBoxMetal";
            this.listBoxMetal.Size = new System.Drawing.Size(165, 199);
            this.listBoxMetal.TabIndex = 18;
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(19, 266);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(165, 23);
            this.progressBarMetal.TabIndex = 17;
            // 
            // buttonBosaltMetal
            // 
            this.buttonBosaltMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBosaltMetal.Location = new System.Drawing.Point(19, 295);
            this.buttonBosaltMetal.Name = "buttonBosaltMetal";
            this.buttonBosaltMetal.Size = new System.Drawing.Size(165, 46);
            this.buttonBosaltMetal.TabIndex = 16;
            this.buttonBosaltMetal.Text = "BOŞALT";
            this.buttonBosaltMetal.UseVisualStyleBackColor = true;
            this.buttonBosaltMetal.Click += new System.EventHandler(this.buttonBosaltMetal_Click);
            // 
            // buttonEkleMetal
            // 
            this.buttonEkleMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEkleMetal.Location = new System.Drawing.Point(19, 18);
            this.buttonEkleMetal.Name = "buttonEkleMetal";
            this.buttonEkleMetal.Size = new System.Drawing.Size(165, 39);
            this.buttonEkleMetal.TabIndex = 15;
            this.buttonEkleMetal.Text = "METAL";
            this.buttonEkleMetal.UseVisualStyleBackColor = true;
            this.buttonEkleMetal.Click += new System.EventHandler(this.buttonEkleMetal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(710, 783);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.ListBox listBoxOrganik;
        private System.Windows.Forms.ProgressBar progressBarOrganik;
        private System.Windows.Forms.Button buttonBosaltOrganik;
        private System.Windows.Forms.Button buttonEkleOrganik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Button buttonYeniOyun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBoxKagit;
        private System.Windows.Forms.Button buttonEkleKagit;
        private System.Windows.Forms.ProgressBar progressBarKagit;
        private System.Windows.Forms.Button buttonBosaltKagit;
        private System.Windows.Forms.ListBox listBoxMetal;
        private System.Windows.Forms.Button buttonEkleMetal;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.Button buttonBosaltMetal;
        private System.Windows.Forms.ListBox listBoxCam;
        private System.Windows.Forms.Button buttonEkleCam;
        private System.Windows.Forms.ProgressBar progressBarCam;
        private System.Windows.Forms.Button buttonBosaltCam;
    }
}

