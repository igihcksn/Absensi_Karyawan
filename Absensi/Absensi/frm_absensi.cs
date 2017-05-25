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
    public partial class frm_absensi : Form
    {
        Modul db = new Modul();
        DataTable dt = new DataTable();
        string tglSekarang = DateTime.Now.Date.ToString("yyyy-MM-dd");
        string Simpan;

        Modul db0 = new Modul();
        DataTable dt0 = new DataTable();

        public frm_absensi()
        {
            InitializeComponent();
            
        }

        private void frm_absensi_Load(object sender, EventArgs e)
        {
            tampilAbsenMasuk();
            txtID.Focus();
            timer1.Start();

        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            txtID.MaxLength = 15;
        }

        private void bntsatu_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;

        }

        private void btndua_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btntiga_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btnempat_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btnlima_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btnenam_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btntujuh_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btndelapan_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btnsembilan_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID.Focus();
        }

        private void btnnol_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtID.Text = txtID.Text + b.Text;
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Modul.status == "Administrator")
            { btn_izin.Visible = true; LOG.Visible = false; }
            else { btn_izin.Visible = false; LOG.Visible = true; }
            if (grbAlasan.Visible == false)
            {
                btnMasuk.Enabled = true;
                btnPulang.Enabled = true;
                btn_izin.Enabled = true;
            }
            else
            {
                btnMasuk.Enabled = false;
                btnPulang.Enabled = false;
                btn_izin.Enabled = false;
            }

            Modul db = new Modul();
            DataTable dt = new DataTable();
            string pengumuman = "select tb_admin.nm_admin,tb_pengumuman.pengumuman from tb_admin,tb_pengumuman";
            dt = db.BukaTabel(pengumuman);
            if (dt.Rows.Count > 0)
            {
                txtPengumuman.Text = dt.Rows[0][0].ToString() + " : " +Environment.NewLine + dt.Rows[0][1].ToString();
            }
            string[] hari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jum\'at", "Sabtu" };
            string hariIni = hari[(int)DateTime.Today.DayOfWeek];
            string hariIndonesia = string.Format("{0}", hariIni);
            txtHari.Text = hariIndonesia;
            tanggal.Text = DateTime.Now.Date.ToString("dd-MMM-yyyy");
            txtjam.Text = DateTime.Now.ToString("HH:mm:ss tt");
            if (Modul.login == "login")
            {
                this.Hide();
            }
            
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                txtID.Clear();
                txtID.Focus();
            }
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string keterangan = "Tepat Waktu";
            string ktr = "Terlambat";
            if (txtID.Text == "")
            {
                MessageBox.Show("Masukan NIK Anda...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else
            {
                DataTable dt = new DataTable();
                string nik = "Select nik from tb_karyawan where nik='{0}'";
                nik = string.Format(nik, txtID.Text);
                dt = db.BukaTabel(nik);
                if (dt.Rows.Count > 0)
                {
                    
                    DataTable dt1 = new DataTable();
                    string NikSudahada = "select * from tb_absensi where tgl_absensi='{0}' and nik='{1}'";
                    NikSudahada = string.Format(NikSudahada, tglSekarang, txtID.Text);
                    dt1 = db.BukaTabel(NikSudahada);
                    if (dt1.Rows.Count > 0)
                    {
                        MessageBox.Show("Anda Telah Absen...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtID.Clear();
                        txtID.Focus();
                    }
                    else
                    {
                        Modul md1 = new Modul();
                        DataTable tb1 = new DataTable();
                        string sqlJamMasuk = "Select masuk from tb_jadwal where nik='{0}'";
                        sqlJamMasuk = string.Format(sqlJamMasuk, txtID.Text);
                        tb1 = md1.BukaTabel(sqlJamMasuk);
                        string masuk = tb1.Rows[0][0].ToString();
                        DateTime jamMasuk = DateTime.Parse(masuk);

                        Modul md2 = new Modul();
                        DataTable tb2 = new DataTable();
                        string sqlJamPulang = "Select pulang from tb_jadwal where nik='{0}'";
                        sqlJamPulang = string.Format(sqlJamPulang, txtID.Text);
                        tb2 = md2.BukaTabel(sqlJamPulang);
                        string pulang = tb2.Rows[0][0].ToString();
                        DateTime jamPulang = DateTime.Parse(pulang);
                        TimeSpan perbandingan = jamMasuk.Subtract(jamPulang);

                        Modul md3 = new Modul();
                        DataTable tb3 = new DataTable();
                        string jabatan = "select id_jabatan from tb_karyawan where nik='{0}'";
                        jabatan = String.Format(jabatan, txtID.Text);
                        tb3 = md3.BukaTabel(jabatan);
                        if (tb3.Rows[0][0].ToString() == "Security")
                        {
                            jamMasuk = jamMasuk.AddMinutes(05);
                        }
                        if (tb3.Rows[0][0].ToString() == "Karyawan")
                        {
                            jamMasuk = jamMasuk.AddMinutes(10);
                            if (txtHari.Text == "Sabtu")
                            {
                                jamPulang = jamPulang.AddHours(-2);
                            }
                        }
                        TimeSpan selisihmasuk = DateTime.Now.Subtract(jamMasuk);
                        TimeSpan selisihPulang = DateTime.Now.Subtract(jamPulang);
                        

                        //Penyimpanan absen lewat hari.......
                        if (perbandingan.TotalMinutes > 0)
                        {
                            
                            if (selisihmasuk.TotalMinutes > 0 || selisihPulang.TotalMinutes < 0)
                            {
                                //Terlambat...
                                Simpan = "insert into tb_absensi (tgl_absensi,nik,jamMasuk,ktrmasuk,status)";
                                Simpan += "values ('{0}','{1}','{2}','{3}','{4}')";
                                Simpan = string.Format(Simpan, tglSekarang, txtID.Text, txtjam.Text, ktr,ktr);
                                db.AksiQuery(Simpan);
                                listAbsensi.Items.Clear();
                                tampilAbsenMasuk();
                                txtID.Text = null;
                                txtID.Focus();
                            }
                            else {
                                //Tepat waktu...
                                Simpan = "insert into tb_absensi (tgl_absensi,nik,jamMasuk,ktrmasuk,status)";
                                Simpan += "values ('{0}','{1}','{2}','{3}','{4}')";
                                Simpan = string.Format(Simpan, tglSekarang, txtID.Text, txtjam.Text, keterangan,keterangan);
                                db.AksiQuery(Simpan);
                                listAbsensi.Items.Clear();
                                tampilAbsenMasuk();
                                txtID.Text = null;
                                txtID.Focus();
                            }
                        }//Penyimpanan absen lewat hari.......
                        else
                        {
                            
                            if (selisihmasuk.TotalMinutes > 0)
                            {   
                                //Terlambat...
                                Simpan = "insert into tb_absensi (tgl_absensi,nik,jamMasuk,ktrmasuk,status)";
                                Simpan += "values ('{0}','{1}','{2}','{3}','{4}')";
                                Simpan = string.Format(Simpan, tglSekarang, txtID.Text, txtjam.Text, ktr, ktr);
                                db.AksiQuery(Simpan);
                                listAbsensi.Items.Clear();
                                tampilAbsenMasuk();
                                txtID.Text = null;
                                txtID.Focus();
                            }
                            else
                            {
                                //Tepat waktu...
                                Simpan = "insert into tb_absensi (tgl_absensi,nik,jamMasuk,ktrmasuk,status)";
                                Simpan += "values ('{0}','{1}','{2}','{3}','{4}')";
                                Simpan = string.Format(Simpan, tglSekarang, txtID.Text, txtjam.Text, keterangan, keterangan);
                                db.AksiQuery(Simpan);
                                listAbsensi.Items.Clear();
                                tampilAbsenMasuk();
                                txtID.Text = null;
                                txtID.Focus();
                            }
                        } Modul.keterangan = "Masuk";
                    } 
                }
                else
                {
                    MessageBox.Show("Nik Tidak Terdaftar...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Clear();
                    txtID.Focus();
                }
            } Modul.keterangan = "Masuk";
        }
        private void btnPulang_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Masukan NIK Anda...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else
            {
                DataTable dt3 = new DataTable();
                string nikBenar = "select nik from tb_karyawan where nik='{0}'";
                nikBenar = string.Format(nikBenar, txtID.Text);
                dt3 = db.BukaTabel(nikBenar);

                if (dt3.Rows.Count > 0)
                {
                    Modul m = new Modul();
                    DataTable d = new DataTable();
                    string s = "select nik from tb_absensi where tgl_absensi='{0}' and nik='{1}'";
                    s = string.Format(s, tglSekarang, txtID.Text);
                    d = m.BukaTabel(s);
                    if (d.Rows.Count > 0)
                    {
                        DataTable dt4 = new DataTable();
                        string cek = "select ktrmasuk from tb_absensi where tgl_absensi='{0}' and nik='{1}'";
                        cek = string.Format(cek, tglSekarang, txtID.Text);
                        dt4 = db.BukaTabel(cek);
                        if (dt4.Rows.Count !=0 && dt4.Rows[0][0].ToString() == "Tidak Masuk")
                        {
                            MessageBox.Show("Anda Telah Absen...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtID.Focus();
                        }
                        else
                        {
                            Modul mo = new Modul();
                            DataTable dt2 = new DataTable();
                            string sqlPulang;
                            string cekket = "select ktrmasuk from tb_absensi where tgl_absensi='{0}' and nik='{1}'";
                            cekket = string.Format(cekket, tglSekarang, txtID.Text);
                            dt2 = mo.BukaTabel(cekket);
                            if (dt2.Rows.Count != 0 && dt2.Rows[0][0].ToString() == "Terlambat" || dt2.Rows[0][0].ToString() == "Tepat Waktu")
                            {
                                Modul m0 = new Modul();
                                DataTable d0 = new DataTable();
                                string sq = "select jamPulang from tb_absensi where tgl_absensi='{0}' and nik='{1}'";
                                sq = string.Format(sq, tglSekarang, txtID.Text);
                                d0 = m0.BukaTabel(sq);
                                if (d0.Rows[0][0].ToString() == "")
                                {
                                    Modul md1 = new Modul();
                                    DataTable tb1 = new DataTable();
                                    string sqlJamMasuk = "Select masuk from tb_jadwal where nik='{0}'";
                                    sqlJamMasuk = string.Format(sqlJamMasuk, txtID.Text);
                                    tb1 = md1.BukaTabel(sqlJamMasuk);
                                    string masuk = tb1.Rows[0][0].ToString();
                                    DateTime jamMasuk = DateTime.Parse(masuk);

                                    Modul md2 = new Modul();
                                    DataTable tb2 = new DataTable();
                                    string sqlJamPulang = "Select pulang from tb_jadwal where nik='{0}'";
                                    sqlJamPulang = string.Format(sqlJamPulang, txtID.Text);
                                    tb2 = md2.BukaTabel(sqlJamPulang);
                                    string pulang = tb2.Rows[0][0].ToString();
                                    DateTime jamPulang = DateTime.Parse(pulang);

                                    Modul md3 = new Modul();
                                    DataTable tb3 = new DataTable();
                                    string jabatan = "select id_jabatan from tb_karyawan where nik='{0}'";
                                    jabatan = String.Format(jabatan, txtID.Text);
                                    tb3 = md3.BukaTabel(jabatan);
                                    if (tb3.Rows[0][0].ToString() == "Karyawan")
                                    {
                                        if (txtHari.Text == "Sabtu")
                                        {
                                            jamPulang = jamPulang.AddHours(-2);
                                        }
                                    }

                                    TimeSpan perbandingan = jamMasuk.Subtract(jamPulang);
                                    TimeSpan selisihmasuk = DateTime.Now.Subtract(jamMasuk);
                                    TimeSpan selisihPulang = DateTime.Now.Subtract(jamPulang);
                                    string ktrpulang = "Tepat Waktu";

                                    
                                    if (perbandingan.TotalMinutes > 0)
                                    {
                                        
                                        if(selisihmasuk.TotalMinutes > 0 && selisihPulang.TotalMinutes < 0)
                                        {
                                            sqlPulang = "update tb_absensi set jamPulang=now(),ktrpulang='{1}',status='{2}' where nik='{3}' and tgl_absensi='{4}'";
                                            sqlPulang = string.Format(sqlPulang, txtjam.Text, ktrpulang, ktrpulang, txtID.Text, tglSekarang);
                                            mo.AksiQuery(sqlPulang);
                                            listAbsensi.Items.Clear();
                                            tampilAbsenMasuk();
                                            txtID.Text = null;
                                            txtID.Focus();
                                        }
                                        else
                                        {
                                            Modul.izin = "Pulang Cepat";
                                            label3.Text = "Alasan Pulang Lebih Awal";
                                            grbAlasan.Show();
                                            txtAlasan.Focus();
                                        }
                                    }
                                    else {
                                        if (selisihPulang.TotalMinutes > 0 )
                                        {
                                            sqlPulang = "update tb_absensi set jamPulang=now(),ktrpulang='{1}',status='{2}' where nik='{3}' and tgl_absensi='{4}'";
                                            sqlPulang = string.Format(sqlPulang, txtjam.Text, ktrpulang, ktrpulang, txtID.Text, tglSekarang);
                                            mo.AksiQuery(sqlPulang);
                                            listAbsensi.Items.Clear();
                                            tampilAbsenMasuk();
                                            txtID.Text = null;
                                            txtID.Focus();
                                        }
                                        else
                                        {
                                            Modul.izin = "Pulang Cepat";
                                            label3.Text = "Alasan Pulang Lebih Awal";
                                            grbAlasan.Show();
                                            txtAlasan.Focus();
                                        }
                                    } Modul.keterangan = "Pulang";
                                }
                                else
                                {
                                    MessageBox.Show("Anda Telah Absen Pulang...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txtID.Clear();
                                    txtID.Focus();
                                } 
                            }
                            else
                            {
                                MessageBox.Show("Anda Telah Absen Pulang...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtID.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Anda Belum Absen Sebelumnya...!!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtID.Focus();
                    }
                }
                else {
                    MessageBox.Show("Maaf NIK Tidak Terdaftar..!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Text = "";
                    txtID.Focus();
                }
            } Modul.keterangan = "Masuk";
        }
        private void tampilAbsenMasuk()
        {
            Modul mo = new Modul();
            DataTable dt = new DataTable();
            string sqlJam = "";
            string sqlJabatan = "select id_jabatan from tb_karyawan where nik='{0}'";
            sqlJabatan = string.Format(sqlJabatan, txtID.Text);
            dt = mo.BukaTabel(sqlJabatan);

            sqlJam = "select tb_karyawan.nm_karyawan,concat(tb_jadwal.masuk,' - ',tb_jadwal.pulang) as jadwal,tb_absensi.jamMasuk,tb_absensi.jamPulang,tb_absensi.status,tb_absensi.alasanIzin from tb_absensi,tb_jadwal,tb_karyawan WHERE tb_jadwal.nik= tb_absensi.nik and tb_absensi.nik = tb_karyawan.nik and tb_absensi.tgl_absensi = date(now())";

            dt = mo.BukaTabel(sqlJam);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem ls = new ListViewItem(dt.Rows[i][0].ToString());
                ls.SubItems.Add(dt.Rows[i][1].ToString());
                ls.SubItems.Add(dt.Rows[i][2].ToString());
                ls.SubItems.Add(dt.Rows[i][3].ToString());
                ls.SubItems.Add(dt.Rows[i][4].ToString());
                ls.SubItems.Add(dt.Rows[i][5].ToString());
                listAbsensi.Items.Add(ls);
            }
        }

        private void btn_jdwalKary_Click(object sender, EventArgs e)
        {
        }

        private void btn_izin_Click(object sender, EventArgs e)
        {
            label3.Text = "Alasan Tidak Masuk";
            Modul.izin = "Izin";
            if (txtID.Text != "")
            {
                string niksudahAbsen = "select * from tb_absensi where tgl_absensi='{0}' and nik='{1}'";
                niksudahAbsen = string.Format(niksudahAbsen, tglSekarang, txtID.Text);
                dt = db.BukaTabel(niksudahAbsen);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Maaf Anda Sudah Absen Hari Ini...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string nik = "Select nik from tb_karyawan where nik='{0}'";
                    nik = string.Format(nik, txtID.Text);
                    dt = db.BukaTabel(nik);
                    if (dt.Rows.Count > 0)
                    {
                        grbAlasan.Visible = true;
                        txtAlasan.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Maaf NIK Anda Tidak Terdaftar...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtID.Clear();
                        txtID.Focus();
                    }
                }
            }
            else { MessageBox.Show("Masukan NIK Anda...!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtID.Focus(); }
        }

        private void LOG_Click(object sender, EventArgs e)
        {
            frm_login fr = new frm_login();
            fr.Show();
        }

        private void batal_Click(object sender, EventArgs e)
        {
            grbAlasan.Visible = false;
            txtID.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                txtID.Text = txtID.Text.Remove(txtID.Text.Length - 1);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string alasan = txtAlasan.Text;
            string Simpan;
            string kterangan = "Pulang Awal";
            if (txtAlasan.Text == "")
            {
                MessageBox.Show("Masukan Alasan Tidak Masuk..!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAlasan.Focus();
            }
            else
            {
                if (Modul.izin == "Pulang Cepat")
                {
                    Simpan = "update tb_absensi set jamPulang='{0}',ktrpulang='{1}',status='{2}', alasanIzin='{3}' where tgl_absensi='{4}' and nik='{5}'";
                    Simpan = string.Format(Simpan, txtjam.Text, kterangan, kterangan, alasan, tglSekarang, txtID.Text);
                    db.AksiQuery(Simpan);
                }
                else
                {
                    string ktr = "Tidak Masuk";
                    Simpan = "insert into tb_absensi (tgl_absensi,nik,ktrmasuk,status,alasanIzin)";
                    Simpan += "values ('{0}','{1}','{2}','{3}','{4}')";
                    Simpan = string.Format(Simpan, tglSekarang, txtID.Text, ktr,ktr, alasan);
                    db.AksiQuery(Simpan);
                }
                Modul.keterangan = "Pulang";
                txtAlasan.Text = "";
                grbAlasan.Visible = false;
                listAbsensi.Items.Clear();
                tampilAbsenMasuk();
                txtID.Text = null;
                txtID.Focus();
            }
        }

        private void listAbsensi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
