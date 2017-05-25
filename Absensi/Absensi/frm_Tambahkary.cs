using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Absensi
{
    public partial class frm_TambahKary : Form
    {
        Modul db = new Modul();
        DataTable dt = new DataTable();
        string sqlSimpan;
        
        public frm_TambahKary()
        {

            InitializeComponent();
        }

        private void tampildata()
        {
            txt_NIK.Text = dt.Rows[0][0].ToString();
            txt_nama.Text = dt.Rows[0][1].ToString();
            txt_tempatLahir.Text = dt.Rows[0][2].ToString();
            txt_TanggalLahir.Text = dt.Rows[0][3].ToString();
            txt_alamat.Text = dt.Rows[0][4].ToString();
            cmb_agama.Text = dt.Rows[0][5].ToString();
            rd_laki.Checked = dt.Rows[0][6].ToString() == "1" ? true : false;
            rd_perempuan.Checked = dt.Rows[0][6].ToString() == "2" ? true : false;
            cmb_jabatan.Text = dt.Rows[0][7].ToString();
            txt_noTelp.Text = dt.Rows[0][8].ToString();
            txt_tglAktif.Text = dt.Rows[0][9].ToString();
            rd_aktif.Checked = dt.Rows[0][11].ToString() == "1" ? true : false;
            rd_nonAktif.Checked = dt.Rows[0][11].ToString() == "2" ? true : false;
            if (dt.Rows[0][12].ToString() != "")
            {
                pic_fotokary.Image = db.Base64ToImage(dt.Rows[0][12].ToString());
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string strFoto = db.ImageToBase64(pic_fotokary.Image);
            string jk = rd_laki.Checked == true ? "1" : "2";
            string status = rd_aktif.Checked == true ? "1" : "2";
            string simpanNIktoJadwal;
            if (this.Text == "Tambah Karyawan")
            {
                rd_aktif.Checked = true;
                rd_laki.Checked = true;
                simpanNIktoJadwal = "insert into tb_jadwal(nik)";
                simpanNIktoJadwal += " value ('{0}')";
                simpanNIktoJadwal = string.Format(simpanNIktoJadwal, txt_NIK.Text);
                db.AksiQuery(simpanNIktoJadwal);
                sqlSimpan = "insert into tb_karyawan (nik,nm_karyawan,tempat_lahir,tanggal_lahir,alamat,agama,jk,id_jabatan,notelp,tgl_masuk,status,foto)";
                sqlSimpan += " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')";
                sqlSimpan = string.Format(sqlSimpan, txt_NIK.Text, txt_nama.Text, txt_tempatLahir.Text, txt_TanggalLahir.Text, txt_alamat.Text, cmb_agama.Text, jk, cmb_jabatan.Text, txt_noTelp.Text, txt_tglAktif.Text, status, strFoto);
                string sql2="UPDATE tb_jadwal set masuk='{0}',pulang='{1}' where nik='{2}'";
                sql2 = string.Format(sql2, Modul.kirimanJamMasuk, Modul.kirimanJamPulang,txt_NIK.Text);
                db.AksiQuery(sql2);
            }
            else
            {
                if (rd_aktif.Checked == true)
                {
                    sqlSimpan = "update tb_karyawan set nm_karyawan='{0}',tempat_lahir='{1}',tanggal_lahir='{2}',alamat='{3}',agama='{4}',jk='{5}',id_jabatan='{6}',notelp='{7}',tgl_masuk='{8}',status='{9}',foto='{10}' where nik='{11}'";
                    sqlSimpan = string.Format(sqlSimpan, txt_nama.Text, txt_tempatLahir.Text, txt_TanggalLahir.Text, txt_alamat.Text, cmb_agama.Text, jk, cmb_jabatan.Text, txt_noTelp.Text, txt_tglAktif.Text, status, strFoto, txt_NIK.Text);
                }
                else
                {
                    sqlSimpan = "update tb_karyawan set nm_karyawan='{0}',tempat_lahir='{1}',tanggal_lahir='{2}',alamat='{3}',agama='{4}',jk='{5}',id_jabatan='{6}',notelp='{7}',tgl_masuk='{8}',tgl_keluar='{9}',status='{10}',foto='{11}' where nik='{12}'";
                    sqlSimpan = string.Format(sqlSimpan, txt_nama.Text, txt_tempatLahir.Text, txt_TanggalLahir.Text, txt_alamat.Text, cmb_agama.Text, jk, cmb_jabatan.Text, txt_noTelp.Text, txt_tglAktif.Text, DateTime.Now.Date.ToString("yyyy-MM-dd"), status, strFoto, txt_NIK.Text);

                }

            }
            db.AksiQuery(sqlSimpan);
            MessageBox.Show("Data tersimpan");
            this.Close();
        }

        private void frm_TambahKary_Load(object sender, EventArgs e)
        {
            if (this.Text == "Ubah Karyawan")
            {
                string strTampil = "select * from tb_karyawan where nik='" + txt_NIK.Text + "'";
                dt = db.BukaTabel(strTampil);
                this.txt_NIK.Enabled = false;
                tampildata();
                txt_nama.Focus();
            }
            else {
                txt_NIK.Focus();
            }

        }

        private void btn_cariFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Cari Foto Karyawan";
            openFileDialog1.Filter = "File jpg(*.jpeg)|*.jpg|File bmp(*.bmp)|*.bmp|File png(*.png)|*.png|All files(*.*)|*.*";
            openFileDialog1.FileName = "Cari foto";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pic_fotokary.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void txt_nama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_tempatLahir.Focus(); }
        }

        private void txt_tempatLahir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_TanggalLahir.Focus(); }
        }

        private void dateTanggalLahir_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_alamat.Focus(); }
        }

        private void txt_alamat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { cmb_agama.Focus(); }
        }

        private void cmb_agama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { rd_laki.Focus(); }
        }

        private void rd_laki_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { cmb_jabatan.Focus(); }
        }

        private void cmb_jabatan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_noTelp.Focus(); }
        }

        private void txt_noTelp_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txt_shift_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { rd_aktif.Focus(); }
        }

        private void rd_aktif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_cariFoto_Click(null, null); }
        }

        private void btn_cariFoto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_simpan_Click(null, null); }
        }
                
        private void txt_NIK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void txt_NIK_KeyDown(object sender, KeyEventArgs e)
        {
            Modul db1 = new Modul();
            DataTable dt1 = new DataTable();
            string sql = "select nik from tb_karyawan where nik='{0}'";
            sql = string.Format(sql, txt_NIK.Text);
            dt1 = db1.BukaTabel(sql);
            string nik = txt_NIK.Text;
            if (dt1.Rows.Count >0)
            {
                MessageBox.Show("Maaf NIK Sudah Ada..!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NIK.Focus();
                txt_NIK.Clear();
            }
            else
            {
                if (e.KeyCode == Keys.Enter) { txt_nama.Focus(); }
            }
        }

        private void txt_NIK_Leave(object sender, EventArgs e)
        {
            Modul db1 = new Modul();
            DataTable dt1 = new DataTable();
            string sql = "select nik from tb_karyawan where nik='{0}'";
            sql = string.Format(sql, txt_NIK.Text);
            dt1 = db1.BukaTabel(sql);
            string nik = txt_NIK.Text;
            if (dt1.Rows.Count > 0)
            {
                MessageBox.Show("Maaf NIK Sudah Ada..!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NIK.Focus();
                txt_NIK.Clear();
            }
            else
            {
                txt_nama.Focus();
            }
        }

    }
}
