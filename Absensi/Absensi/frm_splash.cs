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
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value++;
            if (this.progressBar1.Value > 20)
            {
                timer1.Enabled = false;
                Hide();
                frm_absensi i = new frm_absensi();
                i.ShowDialog();
            }
        }
    }
}
