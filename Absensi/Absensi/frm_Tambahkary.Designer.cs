namespace Absensi
{
    partial class frm_TambahKary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TambahKary));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NIK = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_noTelp = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.txt_tempatLahir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rd_aktif = new System.Windows.Forms.RadioButton();
            this.rd_nonAktif = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tglAktif = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.cmb_agama = new System.Windows.Forms.ComboBox();
            this.cmb_jabatan = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rd_perempuan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_laki = new System.Windows.Forms.RadioButton();
            this.btn_cariFoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.pic_gambarjudul = new System.Windows.Forms.PictureBox();
            this.pic_fotokary = new System.Windows.Forms.PictureBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.pic_judulUbah = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_gambarjudul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotokary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_judulUbah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jabatan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No.Telpon";
            // 
            // txt_NIK
            // 
            this.txt_NIK.Location = new System.Drawing.Point(310, 98);
            this.txt_NIK.Name = "txt_NIK";
            this.txt_NIK.Size = new System.Drawing.Size(134, 20);
            this.txt_NIK.TabIndex = 4;
            this.txt_NIK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NIK_KeyDown);
            this.txt_NIK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NIK_KeyPress);
            this.txt_NIK.Leave += new System.EventHandler(this.txt_NIK_Leave);
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(310, 125);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(177, 20);
            this.txt_nama.TabIndex = 5;
            this.txt_nama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nama_KeyDown);
            // 
            // txt_noTelp
            // 
            this.txt_noTelp.Location = new System.Drawing.Point(310, 320);
            this.txt_noTelp.Name = "txt_noTelp";
            this.txt_noTelp.Size = new System.Drawing.Size(134, 20);
            this.txt_noTelp.TabIndex = 13;
            this.txt_noTelp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_noTelp_KeyDown);
            // 
            // btn_simpan
            // 
            this.btn_simpan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_simpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan.Image = global::Absensi.Properties.Resources.ok_16_seaGreen;
            this.btn_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan.Location = new System.Drawing.Point(394, 461);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(94, 33);
            this.btn_simpan.TabIndex = 17;
            this.btn_simpan.Text = "   Simpan";
            this.btn_simpan.UseVisualStyleBackColor = false;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // txt_tempatLahir
            // 
            this.txt_tempatLahir.Location = new System.Drawing.Point(310, 151);
            this.txt_tempatLahir.Name = "txt_tempatLahir";
            this.txt_tempatLahir.Size = new System.Drawing.Size(178, 20);
            this.txt_tempatLahir.TabIndex = 6;
            this.txt_tempatLahir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_tempatLahir_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tempat lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status";
            // 
            // rd_aktif
            // 
            this.rd_aktif.AutoSize = true;
            this.rd_aktif.Location = new System.Drawing.Point(5, 12);
            this.rd_aktif.Name = "rd_aktif";
            this.rd_aktif.Size = new System.Drawing.Size(46, 17);
            this.rd_aktif.TabIndex = 14;
            this.rd_aktif.TabStop = true;
            this.rd_aktif.Text = "Aktif";
            this.rd_aktif.UseVisualStyleBackColor = true;
            this.rd_aktif.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rd_aktif_KeyDown);
            // 
            // rd_nonAktif
            // 
            this.rd_nonAktif.AutoSize = true;
            this.rd_nonAktif.Enabled = false;
            this.rd_nonAktif.Location = new System.Drawing.Point(5, 55);
            this.rd_nonAktif.Name = "rd_nonAktif";
            this.rd_nonAktif.Size = new System.Drawing.Size(69, 17);
            this.rd_nonAktif.TabIndex = 20;
            this.rd_nonAktif.TabStop = true;
            this.rd_nonAktif.Text = "Non-Aktif";
            this.rd_nonAktif.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tglAktif);
            this.groupBox2.Controls.Add(this.rd_aktif);
            this.groupBox2.Controls.Add(this.rd_nonAktif);
            this.groupBox2.Location = new System.Drawing.Point(309, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 83);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // txt_tglAktif
            // 
            this.txt_tglAktif.CustomFormat = "yyyy-MM-dd";
            this.txt_tglAktif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_tglAktif.Location = new System.Drawing.Point(80, 12);
            this.txt_tglAktif.Name = "txt_tglAktif";
            this.txt_tglAktif.Size = new System.Drawing.Size(92, 20);
            this.txt_tglAktif.TabIndex = 15;
            this.txt_tglAktif.Value = new System.DateTime(2014, 6, 13, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Agama";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(310, 208);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(178, 20);
            this.txt_alamat.TabIndex = 8;
            this.txt_alamat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_alamat_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(265, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Alamat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Tanggal lahir";
            // 
            // txt_TanggalLahir
            // 
            this.txt_TanggalLahir.CustomFormat = "yyyy-MM-dd";
            this.txt_TanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_TanggalLahir.Location = new System.Drawing.Point(310, 177);
            this.txt_TanggalLahir.Name = "txt_TanggalLahir";
            this.txt_TanggalLahir.Size = new System.Drawing.Size(99, 20);
            this.txt_TanggalLahir.TabIndex = 7;
            this.txt_TanggalLahir.Value = new System.DateTime(2014, 6, 13, 0, 0, 0, 0);
            this.txt_TanggalLahir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTanggalLahir_KeyDown);
            // 
            // cmb_agama
            // 
            this.cmb_agama.FormattingEnabled = true;
            this.cmb_agama.Items.AddRange(new object[] {
            "Islam",
            "Hindu",
            "Katolik",
            "Protestan",
            "Budha"});
            this.cmb_agama.Location = new System.Drawing.Point(310, 234);
            this.cmb_agama.Name = "cmb_agama";
            this.cmb_agama.Size = new System.Drawing.Size(121, 21);
            this.cmb_agama.TabIndex = 9;
            this.cmb_agama.Text = "Pilih Agama";
            this.cmb_agama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_agama_KeyDown);
            // 
            // cmb_jabatan
            // 
            this.cmb_jabatan.FormattingEnabled = true;
            this.cmb_jabatan.Items.AddRange(new object[] {
            "Manager",
            "Staf",
            "Penyiar",
            "Security"});
            this.cmb_jabatan.Location = new System.Drawing.Point(310, 290);
            this.cmb_jabatan.Name = "cmb_jabatan";
            this.cmb_jabatan.Size = new System.Drawing.Size(121, 21);
            this.cmb_jabatan.TabIndex = 12;
            this.cmb_jabatan.Text = "Pilih jabatan";
            this.cmb_jabatan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_jabatan_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rd_perempuan
            // 
            this.rd_perempuan.AutoSize = true;
            this.rd_perempuan.Location = new System.Drawing.Point(90, 9);
            this.rd_perempuan.Name = "rd_perempuan";
            this.rd_perempuan.Size = new System.Drawing.Size(79, 17);
            this.rd_perempuan.TabIndex = 11;
            this.rd_perempuan.TabStop = true;
            this.rd_perempuan.Text = "Perempuan";
            this.rd_perempuan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_laki);
            this.groupBox1.Controls.Add(this.rd_perempuan);
            this.groupBox1.Location = new System.Drawing.Point(310, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 30);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rd_laki
            // 
            this.rd_laki.AutoSize = true;
            this.rd_laki.Location = new System.Drawing.Point(6, 9);
            this.rd_laki.Name = "rd_laki";
            this.rd_laki.Size = new System.Drawing.Size(68, 17);
            this.rd_laki.TabIndex = 10;
            this.rd_laki.TabStop = true;
            this.rd_laki.Text = "Laki-Laki";
            this.rd_laki.UseVisualStyleBackColor = true;
            // 
            // btn_cariFoto
            // 
            this.btn_cariFoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cariFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cariFoto.FlatAppearance.BorderSize = 0;
            this.btn_cariFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cariFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cariFoto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cariFoto.Location = new System.Drawing.Point(45, 274);
            this.btn_cariFoto.Name = "btn_cariFoto";
            this.btn_cariFoto.Size = new System.Drawing.Size(160, 32);
            this.btn_cariFoto.TabIndex = 16;
            this.btn_cariFoto.Text = "Cari foto";
            this.btn_cariFoto.UseVisualStyleBackColor = false;
            this.btn_cariFoto.Click += new System.EventHandler(this.btn_cariFoto_Click);
            this.btn_cariFoto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_cariFoto_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.pic_judulUbah);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 82);
            this.panel1.TabIndex = 34;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(511, 506);
            this.shapeContainer1.TabIndex = 35;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.SeaGreen;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(37, 94);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(176, 218);
            // 
            // pic_gambarjudul
            // 
            this.pic_gambarjudul.BackColor = System.Drawing.Color.SeaGreen;
            this.pic_gambarjudul.Image = ((System.Drawing.Image)(resources.GetObject("pic_gambarjudul.Image")));
            this.pic_gambarjudul.Location = new System.Drawing.Point(119, 8);
            this.pic_gambarjudul.Name = "pic_gambarjudul";
            this.pic_gambarjudul.Size = new System.Drawing.Size(312, 69);
            this.pic_gambarjudul.TabIndex = 33;
            this.pic_gambarjudul.TabStop = false;
            // 
            // pic_fotokary
            // 
            this.pic_fotokary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_fotokary.ErrorImage = global::Absensi.Properties.Resources.administrator_icon1;
            this.pic_fotokary.Image = global::Absensi.Properties.Resources.administrator_icon1;
            this.pic_fotokary.Location = new System.Drawing.Point(45, 100);
            this.pic_fotokary.Name = "pic_fotokary";
            this.pic_fotokary.Size = new System.Drawing.Size(160, 168);
            this.pic_fotokary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fotokary.TabIndex = 8;
            this.pic_fotokary.TabStop = false;
            // 
            // btn_batal
            // 
            this.btn_batal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_batal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_batal.Image = ((System.Drawing.Image)(resources.GetObject("btn_batal.Image")));
            this.btn_batal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_batal.Location = new System.Drawing.Point(272, 461);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(94, 33);
            this.btn_batal.TabIndex = 18;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = false;
            // 
            // pic_judulUbah
            // 
            this.pic_judulUbah.BackColor = System.Drawing.Color.SeaGreen;
            this.pic_judulUbah.Image = ((System.Drawing.Image)(resources.GetObject("pic_judulUbah.Image")));
            this.pic_judulUbah.Location = new System.Drawing.Point(119, 10);
            this.pic_judulUbah.Name = "pic_judulUbah";
            this.pic_judulUbah.Size = new System.Drawing.Size(312, 69);
            this.pic_judulUbah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_judulUbah.TabIndex = 36;
            this.pic_judulUbah.TabStop = false;
            // 
            // frm_TambahKary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 506);
            this.Controls.Add(this.pic_gambarjudul);
            this.Controls.Add(this.pic_fotokary);
            this.Controls.Add(this.btn_cariFoto);
            this.Controls.Add(this.cmb_jabatan);
            this.Controls.Add(this.cmb_agama);
            this.Controls.Add(this.txt_TanggalLahir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_alamat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tempatLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.txt_noTelp);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_NIK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TambahKary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Karyawan";
            this.Load += new System.EventHandler(this.frm_TambahKary_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_gambarjudul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fotokary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_judulUbah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button btn_simpan;
        public System.Windows.Forms.TextBox txt_NIK;
        public System.Windows.Forms.TextBox txt_nama;
        public System.Windows.Forms.TextBox txt_noTelp;
        public System.Windows.Forms.TextBox txt_tempatLahir;
        public System.Windows.Forms.RadioButton rd_aktif;
        public System.Windows.Forms.RadioButton rd_nonAktif;
        public System.Windows.Forms.TextBox txt_alamat;
        public System.Windows.Forms.DateTimePicker txt_TanggalLahir;
        public System.Windows.Forms.ComboBox cmb_agama;
        public System.Windows.Forms.ComboBox cmb_jabatan;
        public System.Windows.Forms.RadioButton rd_perempuan;
        public System.Windows.Forms.RadioButton rd_laki;
        public System.Windows.Forms.DateTimePicker txt_tglAktif;
        private System.Windows.Forms.PictureBox pic_fotokary;
        private System.Windows.Forms.Button btn_cariFoto;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        public System.Windows.Forms.PictureBox pic_gambarjudul;
        public System.Windows.Forms.PictureBox pic_judulUbah;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}