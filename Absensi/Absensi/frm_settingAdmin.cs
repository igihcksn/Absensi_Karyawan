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
    public partial class frm_settingAdmin : Form
    {
     
        Modul db = new Modul();
        DataTable dt = new DataTable();
        string sql;
        string datauser;
        string datapass;

        public frm_settingAdmin()
        {
            InitializeComponent();

        }

        private void frm_settingAdmin_Load(object sender, EventArgs e)
        {
            datalama();
            timer1.Start();
            kosongkantext();
        }
        private void kosongkantext()
        {
            txt_userlama.Clear();
            txt_passlama.Clear();
            txt_userbaru.Clear();
            txt_passbaru.Clear();
        }
        private void datalama()
        {
           
            DataTable dt = new DataTable();
            dt = db.BukaTabel("Select nm_admin,password from tb_admin");
            datauser = dt.Rows[0][0].ToString();
            datapass = dt.Rows[0][1].ToString();
            
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
           
            
            if (txt_userbaru.Text != "" && txt_passbaru.Text != "")
            {

                if (this.Text == "Ubah admin")
                {
                    sql = "insert into tb_admin (nm_admin,password)";
                    sql += "Values ('{0}','{1}')";
                    sql = string.Format(sql, txt_userbaru.Text, txt_passbaru.Text);
                }
                else
                {
                    sql = "Update tb_admin set nm_admin='{0}',password='{1}'";
                    sql = string.Format(sql, txt_userbaru.Text, txt_passbaru.Text);
                }
                db.AksiQuery(sql);
                db.pesanPemberitahuan("User dan Password berhasil disimpan");
                this.Close();

            }
            else
            {
                db.pesanPemberitahuan("User dan Password tidak boleh kosong");
            }
            
        }

        private void frm_settingAdmin_Activated(object sender, EventArgs e)
        {
            txt_userlama.Focus();
            sql="select nm_admin,password from tb_admin";
            DataTable dt=new DataTable();
            Modul db=new Modul();
            dt=db.BukaTabel(sql);

            if (dt.Rows.Count == 0)
            {
                sql = "Insert Into tb_admin SET nm_admin='admin',password='admin',status='Administrator'";
                db.AksiQuery(sql);
            }

        }

        private void txt_userlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_passlama.Focus(); }
        }

        private void txt_passlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_userbaru.Focus(); }
        }

        private void txt_userbaru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txt_passbaru.Focus(); }
        }

        private void txt_passbaru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_simpan.Focus(); }
        }

        private void txt_userlama_TextChanged(object sender, EventArgs e)
        {
            if (txt_userlama.Text == datauser)
            {
                txt_userbaru.Enabled = true;
            }
            else
            {
                txt_userbaru.Enabled = false;
            }
        }

        private void txt_passlama_TextChanged(object sender, EventArgs e)
        {
            if (txt_passlama.Text == datapass)
            {
                txt_passbaru.Enabled = true;
            }
            else
            {
                txt_passbaru.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txt_userlama.Text == datauser && txt_passlama.Text == datapass)
            {
                btn_simpan.Enabled = true;
            }
            else
            {
                btn_simpan.Enabled = false;
            }
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {

        }
       
    }
}
