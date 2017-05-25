using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absensi
{
    public partial class frm_utama : Form
    {
        frm_absensi fab = new frm_absensi();
        frm_login flogin = new frm_login();
        frm_TambahKary fTambah = new frm_TambahKary();
        frm_dataKary fData = new frm_dataKary();
        frm_settingAdmin fsettadmin = new frm_settingAdmin();
        public frm_utama()
        {
            InitializeComponent();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var pesan= MessageBox.Show("Keluar Aplikasi", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (pesan==DialogResult.OK)
            {
                Application.Exit();
            }

        }
        private void hideUtama()
        {
            this.Hide();
        }

        private void dataKarywanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (fData.IsDisposed)
            { 
                fData = new frm_dataKary();
            } fData.MdiParent = this;
            fData.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] hari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jum\'at", "Sabtu" };
            string[] bulan = { "Desember", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November","Desember" };

            string hariIni = hari[(int)DateTime.Today.DayOfWeek];
            string bulanIni = bulan[DateTime.Today.Month];
            string TglIndonesia = string.Format("{0}, {1}-{2}-{3}", hariIni, DateTime.Today.Day, bulanIni, DateTime.Today.Year);
            this.tangalBar.Text = "Hari :" + " " + TglIndonesia;
            this.namaBarLabel.Text = "Status :" + " " + Modul.status;

            

        }

        private void logutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Modul.status = "Karyawan";
            Modul.login = "";

        }

        private void hakAksesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fsettadmin.IsDisposed)
            fsettadmin = new frm_settingAdmin();
            fsettadmin.ShowDialog();
        }

        private void frm_utama_Activated(object sender, EventArgs e)
        {
            if (fab.IsDisposed)
                fab = new frm_absensi();
            fab.MdiParent = this;
            fab.Show();
            timer1.Start();
        }

        private void absensiKaryawan_Click(object sender, EventArgs e)
        {
            Modul.login = "";
            Modul.status = "Administrator";
            frm_absensi frm = new frm_absensi();
            if (frm.IsDisposed)
                   
                frm = new frm_absensi();
                frm.MdiParent = this;
                frm.Show();
        }

        private void frm_utama_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void settingHostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm_settingHost pang = new frm_settingHost();
            //pang.ShowDialog();
        }

        private void tentagToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void frmpengumuman_Click(object sender, EventArgs e)
        {
            Frm_pengumuman fr = new Frm_pengumuman();
            if(fr.IsDisposed)
            fr=new Frm_pengumuman();
            fr.ShowDialog();
        }

        private void frm_utama_FormClosed(object sender, FormClosedEventArgs e)
        {
            Modul.login = "";
            Modul.status = "Karyawan"; 
            this.Hide();
            frm_absensi frab = new frm_absensi();
            frab.Show();
        }

        private void aktifToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void harianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lap_absensi LapHarian = new Lap_absensi();
            if (LapHarian.IsDisposed)
                LapHarian = new Lap_absensi();
            LapHarian.MdiParent = this;
            LapHarian.Show();
            LapHarian.LoadReport("rpt_harian.rdl",null);
        }

        private void bulananToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lap_rekapAbsensi lapBulanan = new Lap_rekapAbsensi();
            if (lapBulanan.IsDisposed)
                lapBulanan = new Lap_rekapAbsensi();
            lapBulanan.MdiParent = this;
            lapBulanan.Show();
            lapBulanan.loadReport("rpt_Rekap.rdl", null);
        }

        private void dataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lap_Karyawan lapKarAkt = new Lap_Karyawan();
            if (lapKarAkt.IsDisposed)
                lapKarAkt = new Lap_Karyawan();
            lapKarAkt.MdiParent = this;
            lapKarAkt.Show();
            lapKarAkt.loadReport("rpt_karyawan.rdl", null);
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

