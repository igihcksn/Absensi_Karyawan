using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Absensi
{
    public partial class frm_dataKary : Form
    {
        string sql;
        Modul db = new Modul();
        DataTable dt = new DataTable();
        
        public frm_dataKary()
        {
            
            InitializeComponent();
            
        }
        private void TampilkanData()
        {
            Modul db = new Modul();
            string stts="1";
            sql = "select nik,nm_karyawan,tempat_lahir,tanggal_lahir,alamat,agama,if(jk=1, 'Laki-Laki','Perempuan') as jk,id_jabatan,notelp,tgl_masuk,if(status=1, 'Aktif','Non Aktif') as status from tb_karyawan where status='{0}'";
            sql = string.Format(sql, stts);
            dt = db.BukaTabel(sql);
            grid_karyawan.DataSource = dt;

            grid_karyawan.Font.Size.ToString("12");
            grid_karyawan.Columns[0].HeaderText = "NIK";
            grid_karyawan.Columns[0].Width = 150;
            grid_karyawan.Columns[1].HeaderText = "Nama Karyawan";
            grid_karyawan.Columns[1].Width = 150;
            grid_karyawan.Columns[2].HeaderText = "Tempat lahir";
            grid_karyawan.Columns[2].Width = 100;
            grid_karyawan.Columns[3].HeaderText = "Tanggal lahir";
            grid_karyawan.Columns[3].Width = 110;
            grid_karyawan.Columns[4].HeaderText = "Alamat";
            grid_karyawan.Columns[4].Width = 150;
            grid_karyawan.Columns[5].HeaderText = "Agama";
            grid_karyawan.Columns[5].Width = 100;
            grid_karyawan.Columns[6].HeaderText = "Jenis Kelamin";
            grid_karyawan.Columns[6].Width=110;
            grid_karyawan.Columns[7].HeaderText = "Jabatan";
            grid_karyawan.Columns[8].HeaderText = "No Telpon";
            grid_karyawan.Columns[8].Width = 130;
            grid_karyawan.Columns[9].HeaderText = "Tanggal masuk";
            grid_karyawan.Columns[9].Width = 130;
            grid_karyawan.Columns[10].HeaderText = "Status";
        }

        public void btn_tambah_Click(object sender, EventArgs e)
        {
        //    Modul db = new Modul();
        //    dt = db.BukaTabel("select nik from tb_karyawan");
        //    frm_TambahKary entri = new frm_TambahKary();
        //    if (dt.Rows.Count > 0)
        //    {
        //        string NikAuto = dt.Rows[dt.Rows.Count - 1][0].ToString();
        //        int no = int.Parse(NikAuto.Substring(4, 4)) + 1;
        //        NikAuto = "0000" + no.ToString();

        //        entri.txt_NIK.Text = DateTime.Now.Year.ToString() + NikAuto.Substring(NikAuto.Length - 4, 4);
        //    }
        //    else
        //    {
        //        entri.txt_NIK.Text = DateTime.Now.Year.ToString() + "0001";
        //    }
        //    entri.Text = "Tambah karyawan";
        //    entri.ShowDialog();
        //    TampilkanData();

        //    entri.txt_NIK.Focus();
            frm_TambahKary pang = new frm_TambahKary();
            pang.Text = "Tambah Karyawan";
            pang.ShowDialog();
            TampilkanData();
        }

        private void frm_dataKary_Load(object sender, EventArgs e)
        {
            txt_cari.Focus();
            TampilkanData();
            
        }

        private void txt_cari_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)grid_karyawan.DataSource).DefaultView.RowFilter = string.Format("nik like '%{0}%' or nm_karyawan like '%{0}%' or id_jabatan like '%{0}%' or alamat like '%{0}%'", txt_cari.Text.Trim().Replace("'", "''"));
        }
        private void enabledtrue()
        {
            foreach (Control enabled in Controls)
            {
                if (enabled is TextBox || enabled is ComboBox || enabled is RadioButton || enabled is DateTimePicker) enabled.Enabled = true;
            }
        }
        private void kosongkandata()
        {
            foreach (Control kosong in Controls)
            {
                if (kosong is TextBox || kosong is ComboBox) kosong.Text="";
                
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            kosongkandata();
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            
            if (this.Text != "Ubah karyawan")
            {
                frm_TambahKary es = new frm_TambahKary();
                es.Text = "Ubah Karyawan";
                es.txt_NIK.Text = grid_karyawan.CurrentRow.Cells[0].Value.ToString();
                es.txt_nama.Text = grid_karyawan.CurrentRow.Cells[1].Value.ToString();
                es.txt_tempatLahir.Text = grid_karyawan.CurrentRow.Cells[2].ValueType.ToString();
                es.pic_gambarjudul.Visible = false;
                es.rd_nonAktif.Enabled = true;
                es.ShowDialog();
                TampilkanData();
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_settjadwal pang = new frm_settjadwal();
            pang.Text = "Setting Masuk Karyawan";
            pang.ShowDialog();
        }

        private void btn_ubah_MouseHover(object sender, EventArgs e)
        {
            btn_ubah.ForeColor = Color.SeaGreen;
        }

        private void btn_ubah_MouseLeave(object sender, EventArgs e)
        {
            btn_ubah.ForeColor = Color.Black;
        }

        private void btn_tambah_MouseHover(object sender, EventArgs e)
        {
            btn_tambah.ForeColor = Color.SeaGreen;
        }

        private void btn_tambah_MouseLeave(object sender, EventArgs e)
        {
            btn_tambah.ForeColor = Color.Black;
        }

        private void btn_settShift_MouseHover(object sender, EventArgs e)
        {
            btn_settShift.ForeColor = Color.SeaGreen;
        }

        private void btn_settShift_MouseLeave(object sender, EventArgs e)
        {
            btn_settShift.ForeColor = Color.Black;
        }

    }
}
