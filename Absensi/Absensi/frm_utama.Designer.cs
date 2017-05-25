namespace Absensi
{
    partial class frm_utama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_utama));
            this.msUtama = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lapAbsensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapAbsensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengaturanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakAksesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.absensiKaryawan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dtKaryawan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.frmpengumuman = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.namaBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tangalBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msUtama.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msUtama
            // 
            this.msUtama.BackColor = System.Drawing.Color.SeaGreen;
            this.msUtama.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.laporanToolStripMenuItem,
            this.pengaturanToolStripMenuItem});
            this.msUtama.Location = new System.Drawing.Point(0, 0);
            this.msUtama.Name = "msUtama";
            this.msUtama.Size = new System.Drawing.Size(1350, 24);
            this.msUtama.TabIndex = 0;
            this.msUtama.Text = "msUtama";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logutToolStripMenuItem
            // 
            this.logutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logutToolStripMenuItem.Image")));
            this.logutToolStripMenuItem.Name = "logutToolStripMenuItem";
            this.logutToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.logutToolStripMenuItem.Text = "Logut";
            this.logutToolStripMenuItem.Click += new System.EventHandler(this.logutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absensiToolStripMenuItem,
            this.dataKaryawanToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // absensiToolStripMenuItem
            // 
            this.absensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lapAbsensiToolStripMenuItem,
            this.rekapAbsensiToolStripMenuItem});
            this.absensiToolStripMenuItem.Name = "absensiToolStripMenuItem";
            this.absensiToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.absensiToolStripMenuItem.Text = "Absensi Karyawan";
            // 
            // lapAbsensiToolStripMenuItem
            // 
            this.lapAbsensiToolStripMenuItem.Name = "lapAbsensiToolStripMenuItem";
            this.lapAbsensiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.lapAbsensiToolStripMenuItem.Text = "Laporan Absensi";
            this.lapAbsensiToolStripMenuItem.Click += new System.EventHandler(this.harianToolStripMenuItem_Click);
            // 
            // rekapAbsensiToolStripMenuItem
            // 
            this.rekapAbsensiToolStripMenuItem.Name = "rekapAbsensiToolStripMenuItem";
            this.rekapAbsensiToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rekapAbsensiToolStripMenuItem.Text = "Rekap Absensi";
            this.rekapAbsensiToolStripMenuItem.Click += new System.EventHandler(this.bulananToolStripMenuItem_Click);
            // 
            // dataKaryawanToolStripMenuItem
            // 
            this.dataKaryawanToolStripMenuItem.Name = "dataKaryawanToolStripMenuItem";
            this.dataKaryawanToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.dataKaryawanToolStripMenuItem.Text = "Data Karyawan";
            this.dataKaryawanToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // pengaturanToolStripMenuItem
            // 
            this.pengaturanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakAksesToolStripMenuItem});
            this.pengaturanToolStripMenuItem.Name = "pengaturanToolStripMenuItem";
            this.pengaturanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pengaturanToolStripMenuItem.Text = "Pengaturan";
            // 
            // hakAksesToolStripMenuItem
            // 
            this.hakAksesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakAksesToolStripMenuItem.Image")));
            this.hakAksesToolStripMenuItem.Name = "hakAksesToolStripMenuItem";
            this.hakAksesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hakAksesToolStripMenuItem.Text = "Akun Admin";
            this.hakAksesToolStripMenuItem.Click += new System.EventHandler(this.hakAksesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absensiKaryawan,
            this.toolStripSeparator2,
            this.dtKaryawan,
            this.toolStripSeparator3,
            this.frmpengumuman});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 70);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // absensiKaryawan
            // 
            this.absensiKaryawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.absensiKaryawan.Image = global::Absensi.Properties.Resources.Absensi_ico1;
            this.absensiKaryawan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.absensiKaryawan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.absensiKaryawan.Name = "absensiKaryawan";
            this.absensiKaryawan.Size = new System.Drawing.Size(106, 67);
            this.absensiKaryawan.Text = "Absensi Karyawan";
            this.absensiKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.absensiKaryawan.Click += new System.EventHandler(this.absensiKaryawan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // dtKaryawan
            // 
            this.dtKaryawan.Image = global::Absensi.Properties.Resources.data_karyawan;
            this.dtKaryawan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dtKaryawan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dtKaryawan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.dtKaryawan.Name = "dtKaryawan";
            this.dtKaryawan.Size = new System.Drawing.Size(89, 67);
            this.dtKaryawan.Text = "Data Karyawan";
            this.dtKaryawan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dtKaryawan.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // frmpengumuman
            // 
            this.frmpengumuman.Image = ((System.Drawing.Image)(resources.GetObject("frmpengumuman.Image")));
            this.frmpengumuman.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.frmpengumuman.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.frmpengumuman.Name = "frmpengumuman";
            this.frmpengumuman.Size = new System.Drawing.Size(87, 67);
            this.frmpengumuman.Text = "Pengumuman";
            this.frmpengumuman.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.frmpengumuman.Click += new System.EventHandler(this.frmpengumuman_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.namaBarLabel,
            this.tangalBar,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 667);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1350, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // namaBarLabel
            // 
            this.namaBarLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.namaBarLabel.ForeColor = System.Drawing.Color.White;
            this.namaBarLabel.Name = "namaBarLabel";
            this.namaBarLabel.Size = new System.Drawing.Size(56, 20);
            this.namaBarLabel.Text = "Status :";
            // 
            // tangalBar
            // 
            this.tangalBar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tangalBar.ForeColor = System.Drawing.Color.White;
            this.tangalBar.Name = "tangalBar";
            this.tangalBar.Size = new System.Drawing.Size(1248, 20);
            this.tangalBar.Spring = true;
            this.tangalBar.Text = "Hari";
            this.tangalBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frm_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1350, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msUtama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_utama";
            this.Text = "Program Absensi v1.0 Beta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_utama_FormClosed);
            this.Load += new System.EventHandler(this.frm_utama_Load);
            this.msUtama.ResumeLayout(false);
            this.msUtama.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUtama;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton absensiKaryawan;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton dtKaryawan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem pengaturanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakAksesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lapAbsensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapAbsensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel namaBarLabel;
        public System.Windows.Forms.ToolStripStatusLabel tangalBar;
        private System.Windows.Forms.ToolStripButton frmpengumuman;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;


    }
}