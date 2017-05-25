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
    public partial class frm_login : Form
    {
        DataTable dt = new DataTable();
        

        public frm_login()
        {
            
            InitializeComponent();
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
           
            string strlogin = "select nm_admin,password from tb_admin where nm_admin='{0}' and password ='{1}'";
            strlogin = string.Format(strlogin, txtuser.Text, txtpass.Text);
            Modul db = new Modul();
            dt = db.BukaTabel(strlogin);
            if (dt.Rows.Count > 0)
            {
                txtuser.Text = "";
                txtpass.Text = "";
                this.Hide();
                
                frm_utama fr = new frm_utama();
                fr.Show();  
                Modul.login = "login";
                Modul.status = "Administrator";
            }
            else
            {
                MessageBox.Show("Password salah", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtuser.Text = "";
                txtpass.Text = "";
                txtuser.Focus();
            }

        }

        private void frm_login_Activated(object sender, EventArgs e)
        {
            txtuser.Focus();
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { txtpass.Focus(); }
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btn_login_Click(null, null); }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}