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
    public partial class frm_settjadwal : Form
    {
        Modul db = new Modul();
        DataTable dt = new DataTable();
        string sql;

        public frm_settjadwal()
        {
            InitializeComponent();
        }

        private void frm_settjadwal_Load(object sender, EventArgs e)
        {
            isicmbnik();
            if (this.Text == "Jadwal Masuk Karyawan")
            {
                btn_cancel.Visible = false;
                btn_save.Visible = false;
            }

        }
        private void isicmbnik()
        {
            string stts="1";
            sql = "select nik from tb_karyawan where status='{0}'";
            sql = string.Format(sql, stts);
            dt = db.BukaTabel(sql);
            for (int b = 0; b < dt.Rows.Count; b++)
            {
                this.cmbNik.Items.Add(dt.Rows[b][0].ToString());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cmbNik.Text =="")
            {
                db.pesanPemberitahuan("Pilih NIK karyawan");
            }
            else
            {
                sql = "UPDATE tb_jadwal set masuk='{0}',pulang='{1}' where nik='{2}'";
                sql = string.Format(sql, jamMasuk.Text, jamPulang.Text, cmbNik.Text);
                db.AksiQuery(sql);
                db.pesanPemberitahuan("Data Telah Tersimpan");
            }
        }

        private void cmbNik_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = "select masuk,pulang from tb_jadwal where nik='" + cmbNik.Text + "'";
            dt = db.BukaTabel(sql);
            jamMasuk.Text = dt.Rows[0][0].ToString();
            jamPulang.Text = dt.Rows[0][1].ToString();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {

        }

        private void cmbNik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
       
    }
}
