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
    public partial class frm_settingHost : Form
    {
        public frm_settingHost()
        {
            InitializeComponent();
        }

        private void frm_settingHost_Load(object sender, EventArgs e)
        {
            tampil();  
        }
        private void tampil()
        {
            this.txtHost.Text = Modul.getAppSetting("host").ToString();
            this.txtUser.Text = Modul.getAppSetting("user").ToString();
            this.txtPass.Text = Modul.getAppSetting("pass").ToString();
            this.txtdb.Text = Modul.getAppSetting("db").ToString();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            Modul.setAppSetting("host", txtHost.Text);
            Modul.setAppSetting("user", txtUser.Text);
            Modul.setAppSetting("pass", txtPass.Text);
            Modul.setAppSetting("db", txtdb.Text);
            tampil();
        }

    }
}
