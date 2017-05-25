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
    public partial class Frm_pengumuman : Form
    {
        Modul db = new Modul();
        string sqlupdate;
        public Frm_pengumuman()
        {
            InitializeComponent();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_pengumuman_Load(object sender, EventArgs e)
        {
            Modul db=new Modul();
            DataTable dt=new DataTable();
            string sql = "Select * from tb_pengumuman";
            dt = db.BukaTabel(sql);
            txtPengumuman.Text = dt.Rows[0][0].ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string pgm = "Tidak Ada Pengumuman....";
            if (txtPengumuman.Text != "")
            {
                sqlupdate = "update tb_pengumuman set pengumuman='{0}'";
                sqlupdate = string.Format(sqlupdate, txtPengumuman.Text);
                
            }
            else
            {
                sqlupdate = "update tb_pengumuman set pengumuman='{0}'";
                sqlupdate = string.Format(sqlupdate, pgm);
            }
            db.AksiQuery(sqlupdate);
            MessageBox.Show("Pengumuman Tersimpan");
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtPengumuman.Text = "";
            txtPengumuman.Focus();
        }
    }
}
