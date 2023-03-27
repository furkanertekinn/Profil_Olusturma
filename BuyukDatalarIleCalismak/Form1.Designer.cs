namespace BuyukDatalarIleCalismak
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_resimekle = new System.Windows.Forms.Button();
            this.pic_resim = new System.Windows.Forms.PictureBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_kisilistesi = new System.Windows.Forms.ComboBox();
            this.txt_dg_isim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pic_dg_resim = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dg_tel = new System.Windows.Forms.TextBox();
            this.txt_dg_eposta = new System.Windows.Forms.TextBox();
            this.txt_dg_soyisim = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dg_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_kaydet);
            this.groupBox2.Controls.Add(this.btn_resimekle);
            this.groupBox2.Controls.Add(this.pic_resim);
            this.groupBox2.Controls.Add(this.txt_tel);
            this.groupBox2.Controls.Add(this.txt_soyisim);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_eposta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_isim);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 267);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kayıt Ekle";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(24, 213);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(189, 23);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_resimekle
            // 
            this.btn_resimekle.Location = new System.Drawing.Point(237, 213);
            this.btn_resimekle.Name = "btn_resimekle";
            this.btn_resimekle.Size = new System.Drawing.Size(126, 23);
            this.btn_resimekle.TabIndex = 4;
            this.btn_resimekle.Text = "Resim Ekle";
            this.btn_resimekle.UseVisualStyleBackColor = true;
            this.btn_resimekle.Click += new System.EventHandler(this.btn_resimekle_Click);
            // 
            // pic_resim
            // 
            this.pic_resim.Location = new System.Drawing.Point(237, 46);
            this.pic_resim.Name = "pic_resim";
            this.pic_resim.Size = new System.Drawing.Size(126, 161);
            this.pic_resim.TabIndex = 2;
            this.pic_resim.TabStop = false;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(72, 148);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(141, 20);
            this.txt_tel.TabIndex = 3;
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(72, 96);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(141, 20);
            this.txt_soyisim.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyisim";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(72, 122);
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(141, 20);
            this.txt_eposta.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "E-mail";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(72, 70);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(141, 20);
            this.txt_isim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_kisilistesi);
            this.groupBox4.Controls.Add(this.txt_dg_isim);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.pic_dg_resim);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txt_dg_tel);
            this.groupBox4.Controls.Add(this.txt_dg_eposta);
            this.groupBox4.Controls.Add(this.txt_dg_soyisim);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(414, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 267);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kayıt Görüntüle";
            // 
            // cmb_kisilistesi
            // 
            this.cmb_kisilistesi.FormattingEnabled = true;
            this.cmb_kisilistesi.Location = new System.Drawing.Point(7, 20);
            this.cmb_kisilistesi.Name = "cmb_kisilistesi";
            this.cmb_kisilistesi.Size = new System.Drawing.Size(359, 21);
            this.cmb_kisilistesi.TabIndex = 0;
            this.cmb_kisilistesi.SelectedIndexChanged += new System.EventHandler(this.cmb_kisilistesi_SelectedIndexChanged);
            // 
            // txt_dg_isim
            // 
            this.txt_dg_isim.Location = new System.Drawing.Point(75, 74);
            this.txt_dg_isim.Name = "txt_dg_isim";
            this.txt_dg_isim.Size = new System.Drawing.Size(141, 20);
            this.txt_dg_isim.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İsim";
            // 
            // pic_dg_resim
            // 
            this.pic_dg_resim.Location = new System.Drawing.Point(240, 50);
            this.pic_dg_resim.Name = "pic_dg_resim";
            this.pic_dg_resim.Size = new System.Drawing.Size(126, 161);
            this.pic_dg_resim.TabIndex = 2;
            this.pic_dg_resim.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "E-mail";
            // 
            // txt_dg_tel
            // 
            this.txt_dg_tel.Location = new System.Drawing.Point(75, 152);
            this.txt_dg_tel.Name = "txt_dg_tel";
            this.txt_dg_tel.Size = new System.Drawing.Size(141, 20);
            this.txt_dg_tel.TabIndex = 4;
            // 
            // txt_dg_eposta
            // 
            this.txt_dg_eposta.Location = new System.Drawing.Point(75, 126);
            this.txt_dg_eposta.Name = "txt_dg_eposta";
            this.txt_dg_eposta.Size = new System.Drawing.Size(141, 20);
            this.txt_dg_eposta.TabIndex = 3;
            // 
            // txt_dg_soyisim
            // 
            this.txt_dg_soyisim.Location = new System.Drawing.Point(75, 100);
            this.txt_dg_soyisim.Name = "txt_dg_soyisim";
            this.txt_dg_soyisim.Size = new System.Drawing.Size(141, 20);
            this.txt_dg_soyisim.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Soyisim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Telefon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 291);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Büyük Datalar İle Çlışmak";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dg_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_resimekle;
        private System.Windows.Forms.PictureBox pic_resim;
        private System.Windows.Forms.ComboBox cmb_kisilistesi;
        private System.Windows.Forms.TextBox txt_dg_isim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_dg_resim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_dg_tel;
        private System.Windows.Forms.TextBox txt_dg_eposta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_dg_soyisim;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

