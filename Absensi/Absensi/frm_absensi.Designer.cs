namespace Absensi
{
    partial class frm_absensi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_absensi));
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listAbsensi = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btntujuh = new System.Windows.Forms.Button();
            this.btndelapan = new System.Windows.Forms.Button();
            this.btnsembilan = new System.Windows.Forms.Button();
            this.btnenam = new System.Windows.Forms.Button();
            this.btnlima = new System.Windows.Forms.Button();
            this.btnempat = new System.Windows.Forms.Button();
            this.btntiga = new System.Windows.Forms.Button();
            this.btndua = new System.Windows.Forms.Button();
            this.bntsatu = new System.Windows.Forms.Button();
            this.btnnol = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_izin = new System.Windows.Forms.Button();
            this.LOG = new System.Windows.Forms.Button();
            this.btnPulang = new System.Windows.Forms.Button();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtjam = new System.Windows.Forms.Label();
            this.txtHari = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.grbAlasan = new System.Windows.Forms.GroupBox();
            this.batal = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlasan = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPengumuman = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbAlasan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(295, 38);
            this.txtID.MaxLength = 17;
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(238, 31);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Nik Karyawan";
            // 
            // listAbsensi
            // 
            this.listAbsensi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAbsensi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader2,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1});
            this.listAbsensi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAbsensi.FullRowSelect = true;
            this.listAbsensi.GridLines = true;
            this.listAbsensi.Location = new System.Drawing.Point(12, 159);
            this.listAbsensi.MultiSelect = false;
            this.listAbsensi.Name = "listAbsensi";
            this.listAbsensi.Size = new System.Drawing.Size(248, 389);
            this.listAbsensi.TabIndex = 9;
            this.listAbsensi.UseCompatibleStateImageBehavior = false;
            this.listAbsensi.View = System.Windows.Forms.View.Details;
            this.listAbsensi.SelectedIndexChanged += new System.EventHandler(this.listAbsensi_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nama";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Shift";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Jam Masuk";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Jam Pulang";
            this.columnHeader9.Width = 85;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Keterangan";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Alasan";
            this.columnHeader1.Width = 160;
            // 
            // btntujuh
            // 
            this.btntujuh.BackColor = System.Drawing.Color.DimGray;
            this.btntujuh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntujuh.FlatAppearance.BorderSize = 0;
            this.btntujuh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btntujuh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btntujuh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntujuh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntujuh.ForeColor = System.Drawing.Color.White;
            this.btntujuh.Location = new System.Drawing.Point(14, 14);
            this.btntujuh.Name = "btntujuh";
            this.btntujuh.Size = new System.Drawing.Size(35, 35);
            this.btntujuh.TabIndex = 3;
            this.btntujuh.Text = "7";
            this.btntujuh.UseVisualStyleBackColor = false;
            this.btntujuh.Click += new System.EventHandler(this.btntujuh_Click);
            // 
            // btndelapan
            // 
            this.btndelapan.BackColor = System.Drawing.Color.DimGray;
            this.btndelapan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelapan.FlatAppearance.BorderSize = 0;
            this.btndelapan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btndelapan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndelapan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelapan.ForeColor = System.Drawing.Color.White;
            this.btndelapan.Location = new System.Drawing.Point(55, 14);
            this.btndelapan.Name = "btndelapan";
            this.btndelapan.Size = new System.Drawing.Size(35, 35);
            this.btndelapan.TabIndex = 4;
            this.btndelapan.Text = "8";
            this.btndelapan.UseVisualStyleBackColor = false;
            this.btndelapan.Click += new System.EventHandler(this.btndelapan_Click);
            // 
            // btnsembilan
            // 
            this.btnsembilan.BackColor = System.Drawing.Color.DimGray;
            this.btnsembilan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsembilan.FlatAppearance.BorderSize = 0;
            this.btnsembilan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnsembilan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnsembilan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsembilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsembilan.ForeColor = System.Drawing.Color.White;
            this.btnsembilan.Location = new System.Drawing.Point(96, 14);
            this.btnsembilan.Name = "btnsembilan";
            this.btnsembilan.Size = new System.Drawing.Size(35, 35);
            this.btnsembilan.TabIndex = 5;
            this.btnsembilan.Text = "9";
            this.btnsembilan.UseVisualStyleBackColor = false;
            this.btnsembilan.Click += new System.EventHandler(this.btnsembilan_Click);
            // 
            // btnenam
            // 
            this.btnenam.BackColor = System.Drawing.Color.DimGray;
            this.btnenam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnenam.FlatAppearance.BorderSize = 0;
            this.btnenam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnenam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnenam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenam.ForeColor = System.Drawing.Color.White;
            this.btnenam.Location = new System.Drawing.Point(96, 55);
            this.btnenam.Name = "btnenam";
            this.btnenam.Size = new System.Drawing.Size(35, 35);
            this.btnenam.TabIndex = 8;
            this.btnenam.Text = "6";
            this.btnenam.UseVisualStyleBackColor = false;
            this.btnenam.Click += new System.EventHandler(this.btnenam_Click);
            // 
            // btnlima
            // 
            this.btnlima.BackColor = System.Drawing.Color.DimGray;
            this.btnlima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlima.FlatAppearance.BorderSize = 0;
            this.btnlima.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnlima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnlima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlima.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlima.ForeColor = System.Drawing.Color.White;
            this.btnlima.Location = new System.Drawing.Point(55, 55);
            this.btnlima.Name = "btnlima";
            this.btnlima.Size = new System.Drawing.Size(35, 35);
            this.btnlima.TabIndex = 7;
            this.btnlima.Text = "5";
            this.btnlima.UseVisualStyleBackColor = false;
            this.btnlima.Click += new System.EventHandler(this.btnlima_Click);
            // 
            // btnempat
            // 
            this.btnempat.BackColor = System.Drawing.Color.DimGray;
            this.btnempat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnempat.FlatAppearance.BorderSize = 0;
            this.btnempat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnempat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnempat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempat.ForeColor = System.Drawing.Color.White;
            this.btnempat.Location = new System.Drawing.Point(14, 55);
            this.btnempat.Name = "btnempat";
            this.btnempat.Size = new System.Drawing.Size(35, 35);
            this.btnempat.TabIndex = 6;
            this.btnempat.Text = "4";
            this.btnempat.UseVisualStyleBackColor = false;
            this.btnempat.Click += new System.EventHandler(this.btnempat_Click);
            // 
            // btntiga
            // 
            this.btntiga.BackColor = System.Drawing.Color.DimGray;
            this.btntiga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntiga.FlatAppearance.BorderSize = 0;
            this.btntiga.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btntiga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btntiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntiga.ForeColor = System.Drawing.Color.White;
            this.btntiga.Location = new System.Drawing.Point(96, 96);
            this.btntiga.Name = "btntiga";
            this.btntiga.Size = new System.Drawing.Size(35, 35);
            this.btntiga.TabIndex = 11;
            this.btntiga.Text = "3";
            this.btntiga.UseVisualStyleBackColor = false;
            this.btntiga.Click += new System.EventHandler(this.btntiga_Click);
            // 
            // btndua
            // 
            this.btndua.BackColor = System.Drawing.Color.DimGray;
            this.btndua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndua.FlatAppearance.BorderSize = 0;
            this.btndua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btndua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btndua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndua.ForeColor = System.Drawing.Color.White;
            this.btndua.Location = new System.Drawing.Point(55, 96);
            this.btndua.Name = "btndua";
            this.btndua.Size = new System.Drawing.Size(35, 35);
            this.btndua.TabIndex = 10;
            this.btndua.Text = "2";
            this.btndua.UseVisualStyleBackColor = false;
            this.btndua.Click += new System.EventHandler(this.btndua_Click);
            // 
            // bntsatu
            // 
            this.bntsatu.BackColor = System.Drawing.Color.DimGray;
            this.bntsatu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntsatu.FlatAppearance.BorderSize = 0;
            this.bntsatu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.bntsatu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.bntsatu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsatu.ForeColor = System.Drawing.Color.White;
            this.bntsatu.Location = new System.Drawing.Point(14, 96);
            this.bntsatu.Name = "bntsatu";
            this.bntsatu.Size = new System.Drawing.Size(35, 35);
            this.bntsatu.TabIndex = 9;
            this.bntsatu.Text = "1";
            this.bntsatu.UseVisualStyleBackColor = false;
            this.bntsatu.Click += new System.EventHandler(this.bntsatu_Click);
            // 
            // btnnol
            // 
            this.btnnol.BackColor = System.Drawing.Color.DimGray;
            this.btnnol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnol.FlatAppearance.BorderSize = 0;
            this.btnnol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnnol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnnol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnol.ForeColor = System.Drawing.Color.White;
            this.btnnol.Location = new System.Drawing.Point(137, 14);
            this.btnnol.Name = "btnnol";
            this.btnnol.Size = new System.Drawing.Size(84, 35);
            this.btnnol.TabIndex = 12;
            this.btnnol.Text = "0";
            this.btnnol.UseVisualStyleBackColor = false;
            this.btnnol.Click += new System.EventHandler(this.btnnol_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DimGray;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(137, 55);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(84, 35);
            this.btnDel.TabIndex = 13;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(137, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 35);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btntiga);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnnol);
            this.panel1.Controls.Add(this.btndua);
            this.panel1.Controls.Add(this.bntsatu);
            this.panel1.Controls.Add(this.btnenam);
            this.panel1.Controls.Add(this.btnlima);
            this.panel1.Controls.Add(this.btnempat);
            this.panel1.Controls.Add(this.btnsembilan);
            this.panel1.Controls.Add(this.btndelapan);
            this.panel1.Controls.Add(this.btntujuh);
            this.panel1.Location = new System.Drawing.Point(295, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 147);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(266, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 231);
            this.panel2.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btn_izin);
            this.groupBox2.Controls.Add(this.LOG);
            this.groupBox2.Controls.Add(this.btnPulang);
            this.groupBox2.Controls.Add(this.btnMasuk);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(539, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 213);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Menu";
            // 
            // btn_izin
            // 
            this.btn_izin.BackColor = System.Drawing.Color.Black;
            this.btn_izin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_izin.FlatAppearance.BorderSize = 0;
            this.btn_izin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_izin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_izin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izin.ForeColor = System.Drawing.Color.White;
            this.btn_izin.Location = new System.Drawing.Point(12, 109);
            this.btn_izin.Name = "btn_izin";
            this.btn_izin.Size = new System.Drawing.Size(175, 35);
            this.btn_izin.TabIndex = 69;
            this.btn_izin.Text = "Absen Tidak Masuk";
            this.btn_izin.UseVisualStyleBackColor = false;
            this.btn_izin.Click += new System.EventHandler(this.btn_izin_Click);
            // 
            // LOG
            // 
            this.LOG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LOG.BackColor = System.Drawing.Color.Maroon;
            this.LOG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOG.ForeColor = System.Drawing.Color.White;
            this.LOG.Location = new System.Drawing.Point(60, 179);
            this.LOG.Name = "LOG";
            this.LOG.Size = new System.Drawing.Size(80, 28);
            this.LOG.TabIndex = 4;
            this.LOG.Text = "LogIn";
            this.LOG.UseVisualStyleBackColor = false;
            this.LOG.Click += new System.EventHandler(this.LOG_Click);
            // 
            // btnPulang
            // 
            this.btnPulang.BackColor = System.Drawing.Color.Black;
            this.btnPulang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPulang.FlatAppearance.BorderSize = 0;
            this.btnPulang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPulang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPulang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPulang.ForeColor = System.Drawing.Color.White;
            this.btnPulang.Location = new System.Drawing.Point(12, 66);
            this.btnPulang.Name = "btnPulang";
            this.btnPulang.Size = new System.Drawing.Size(175, 35);
            this.btnPulang.TabIndex = 68;
            this.btnPulang.Text = "Absen Pulang";
            this.btnPulang.UseVisualStyleBackColor = false;
            this.btnPulang.Click += new System.EventHandler(this.btnPulang_Click);
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.Black;
            this.btnMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasuk.FlatAppearance.BorderSize = 0;
            this.btnMasuk.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMasuk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasuk.ForeColor = System.Drawing.Color.White;
            this.btnMasuk.Location = new System.Drawing.Point(12, 25);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(175, 35);
            this.btnMasuk.TabIndex = 15;
            this.btnMasuk.Text = "Absen Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Controls.Add(this.txtjam);
            this.panel3.Controls.Add(this.txtHari);
            this.panel3.Controls.Add(this.tanggal);
            this.panel3.Location = new System.Drawing.Point(0, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 147);
            this.panel3.TabIndex = 16;
            // 
            // txtjam
            // 
            this.txtjam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtjam.AutoSize = true;
            this.txtjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjam.ForeColor = System.Drawing.Color.White;
            this.txtjam.Location = new System.Drawing.Point(11, 26);
            this.txtjam.Name = "txtjam";
            this.txtjam.Size = new System.Drawing.Size(168, 44);
            this.txtjam.TabIndex = 20;
            this.txtjam.Text = "00:00:00";
            // 
            // txtHari
            // 
            this.txtHari.AutoSize = true;
            this.txtHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHari.ForeColor = System.Drawing.Color.White;
            this.txtHari.Location = new System.Drawing.Point(14, 101);
            this.txtHari.Name = "txtHari";
            this.txtHari.Size = new System.Drawing.Size(56, 30);
            this.txtHari.TabIndex = 21;
            this.txtHari.Text = "hari";
            // 
            // tanggal
            // 
            this.tanggal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tanggal.AutoSize = true;
            this.tanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal.ForeColor = System.Drawing.Color.White;
            this.tanggal.Location = new System.Drawing.Point(96, 101);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(96, 30);
            this.tanggal.TabIndex = 22;
            this.tanggal.Text = "tanggal";
            // 
            // grbAlasan
            // 
            this.grbAlasan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grbAlasan.Controls.Add(this.batal);
            this.grbAlasan.Controls.Add(this.btnOK);
            this.grbAlasan.Controls.Add(this.label3);
            this.grbAlasan.Controls.Add(this.txtAlasan);
            this.grbAlasan.Location = new System.Drawing.Point(252, 43);
            this.grbAlasan.Name = "grbAlasan";
            this.grbAlasan.Size = new System.Drawing.Size(294, 191);
            this.grbAlasan.TabIndex = 22;
            this.grbAlasan.TabStop = false;
            this.grbAlasan.Visible = false;
            // 
            // batal
            // 
            this.batal.BackColor = System.Drawing.Color.Gray;
            this.batal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal.ForeColor = System.Drawing.Color.White;
            this.batal.Location = new System.Drawing.Point(169, 155);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(53, 28);
            this.batal.TabIndex = 3;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = false;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Gray;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(228, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(53, 28);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alasan";
            // 
            // txtAlasan
            // 
            this.txtAlasan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlasan.Location = new System.Drawing.Point(10, 39);
            this.txtAlasan.Multiline = true;
            this.txtAlasan.Name = "txtAlasan";
            this.txtAlasan.Size = new System.Drawing.Size(275, 107);
            this.txtAlasan.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 53F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(-2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 84);
            this.label2.TabIndex = 21;
            this.label2.Text = "Absensi Karyawan";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(266, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "   Pengumuman    ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(266, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 138);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(80, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(576, 22);
            this.label8.TabIndex = 76;
            this.label8.Text = "Jl. BAsuki Rahamat 1 Madiun, Tlp 0351 464765, Mail : madya_fmradio@yahoo.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(499, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 75;
            this.label7.Text = "106.4 Mhz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(247, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 37);
            this.label5.TabIndex = 74;
            this.label5.Text = "Citra Swara Indnesia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(160, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(438, 90);
            this.label6.TabIndex = 73;
            this.label6.Text = "Radio Madya";
            // 
            // txtPengumuman
            // 
            this.txtPengumuman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPengumuman.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPengumuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPengumuman.Location = new System.Drawing.Point(266, 426);
            this.txtPengumuman.Multiline = true;
            this.txtPengumuman.Name = "txtPengumuman";
            this.txtPengumuman.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPengumuman.Size = new System.Drawing.Size(742, 124);
            this.txtPengumuman.TabIndex = 0;
            // 
            // frm_absensi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1020, 552);
            this.Controls.Add(this.grbAlasan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listAbsensi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPengumuman);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_absensi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Absensi Karyawan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_absensi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grbAlasan.ResumeLayout(false);
            this.grbAlasan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listAbsensi;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btntujuh;
        private System.Windows.Forms.Button btndelapan;
        private System.Windows.Forms.Button btnsembilan;
        private System.Windows.Forms.Button btnenam;
        private System.Windows.Forms.Button btnlima;
        private System.Windows.Forms.Button btnempat;
        private System.Windows.Forms.Button btntiga;
        private System.Windows.Forms.Button btndua;
        private System.Windows.Forms.Button bntsatu;
        private System.Windows.Forms.Button btnnol;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnPulang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grbAlasan;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlasan;
        public System.Windows.Forms.Button LOG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_izin;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label txtjam;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label txtHari;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPengumuman;
    }
}