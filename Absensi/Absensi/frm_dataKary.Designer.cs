namespace Absensi
{
    partial class frm_dataKary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dataKary));
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.grid_karyawan = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btn_settShift = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_karyawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cari
            // 
            this.txt_cari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.Location = new System.Drawing.Point(12, 115);
            this.txt_cari.MaxLength = 55;
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(292, 24);
            this.txt_cari.TabIndex = 1;
            this.txt_cari.TextChanged += new System.EventHandler(this.txt_cari_TextChanged);
            // 
            // grid_karyawan
            // 
            this.grid_karyawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_karyawan.BackgroundColor = System.Drawing.Color.White;
            this.grid_karyawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_karyawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grid_karyawan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid_karyawan.Location = new System.Drawing.Point(12, 148);
            this.grid_karyawan.Name = "grid_karyawan";
            this.grid_karyawan.ReadOnly = true;
            this.grid_karyawan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_karyawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_karyawan.Size = new System.Drawing.Size(1317, 386);
            this.grid_karyawan.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btn_settShift
            // 
            this.btn_settShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_settShift.BackColor = System.Drawing.Color.White;
            this.btn_settShift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_settShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settShift.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_settShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_settShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settShift.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_settShift.Image = ((System.Drawing.Image)(resources.GetObject("btn_settShift.Image")));
            this.btn_settShift.Location = new System.Drawing.Point(958, 114);
            this.btn_settShift.Name = "btn_settShift";
            this.btn_settShift.Size = new System.Drawing.Size(139, 31);
            this.btn_settShift.TabIndex = 66;
            this.btn_settShift.Text = " Setting Shift";
            this.btn_settShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_settShift.UseVisualStyleBackColor = true;
            this.btn_settShift.Click += new System.EventHandler(this.button1_Click);
            this.btn_settShift.MouseLeave += new System.EventHandler(this.btn_settShift_MouseLeave);
            this.btn_settShift.MouseHover += new System.EventHandler(this.btn_settShift_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 24);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ubah
            // 
            this.btn_ubah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ubah.BackColor = System.Drawing.Color.White;
            this.btn_ubah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ubah.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ubah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ubah.Image = ((System.Drawing.Image)(resources.GetObject("btn_ubah.Image")));
            this.btn_ubah.Location = new System.Drawing.Point(1224, 115);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(100, 30);
            this.btn_ubah.TabIndex = 4;
            this.btn_ubah.Text = " Ubah";
            this.btn_ubah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ubah.UseVisualStyleBackColor = true;
            this.btn_ubah.Click += new System.EventHandler(this.btn_ubah_Click);
            this.btn_ubah.MouseLeave += new System.EventHandler(this.btn_ubah_MouseLeave);
            this.btn_ubah.MouseHover += new System.EventHandler(this.btn_ubah_MouseHover);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tambah.BackColor = System.Drawing.Color.White;
            this.btn_tambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tambah.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_tambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_tambah.Image = ((System.Drawing.Image)(resources.GetObject("btn_tambah.Image")));
            this.btn_tambah.Location = new System.Drawing.Point(1103, 115);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(115, 30);
            this.btn_tambah.TabIndex = 3;
            this.btn_tambah.Text = "Tambah ";
            this.btn_tambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            this.btn_tambah.MouseLeave += new System.EventHandler(this.btn_tambah_MouseLeave);
            this.btn_tambah.MouseHover += new System.EventHandler(this.btn_tambah_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 54);
            this.label1.TabIndex = 67;
            this.label1.Text = "Radio Madya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 27);
            this.label2.TabIndex = 68;
            this.label2.Text = "Citra Swara Indnesia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "106.4 Mhz";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 107);
            this.panel1.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SeaGreen;
            this.label4.Font = new System.Drawing.Font("Verdana", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(548, 80);
            this.label4.TabIndex = 71;
            this.label4.Text = "Data Karyawan";
            // 
            // frm_dataKary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 542);
            this.Controls.Add(this.btn_settShift);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.grid_karyawan);
            this.Controls.Add(this.txt_cari);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_dataKary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Karyawan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_dataKary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_karyawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.DataGridView grid_karyawan;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_settShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}