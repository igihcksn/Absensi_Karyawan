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
    public partial class Lap_rekapAbsensi : Form
    {
        fyiReporting.RdlViewer.RdlViewer rdlView = new fyiReporting.RdlViewer.RdlViewer();
        public Lap_rekapAbsensi()
        {
            InitializeComponent();
        }

        private void Lap_bulanan_Load(object sender, EventArgs e)
        {
            rdlView.ShowParameterPanel = false;
            rdlView.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(rdlView);
            btnLihat_Click(null, null);
        }
        public void loadReport(string sourceFile, DataTable dt)
        {
            try
            {
                rdlView.SourceFile = string.Format("{0}\\{1}", Application.StartupPath, sourceFile, dt);
                rdlView.Report.DataSets["Data"].SetData(dt);
                rdlView.Rebuild();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void loadReport(string sourceFile, DataTable dt,string Param)
        {
            try
            {
                rdlView.SourceFile = string.Format("{0}\\{1}", Application.StartupPath, sourceFile, dt);
                rdlView.Report.DataSets["Data"].SetData(dt);
                rdlView.Parameters = Param;
                rdlView.Rebuild();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "PDF files(*.pdf)|*pdf|All files (*.*)|*.*";
            this.saveFileDialog1.ShowDialog();
            if (!(saveFileDialog1.FileName == string.Empty))
            { this.rdlView.SaveAs(this.saveFileDialog1.FileName, "pdf"); }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.printDocument1.DocumentName = this.Text;
                this.printDocument1.PrinterSettings.FromPage = 1;
                this.printDocument1.PrinterSettings.ToPage = this.rdlView.PageCount;
                this.printDocument1.PrinterSettings.MaximumPage = this.rdlView.PageCount;
                this.printDocument1.PrinterSettings.MinimumPage = 1;
                if (this.rdlView.PageWidth > this.rdlView.PageHeight)
                { this.printDocument1.DefaultPageSettings.Landscape = true; }
                else { this.printDocument1.DefaultPageSettings.Landscape = false; }

                this.printDialog1.Document = this.printDocument1;
                this.printDialog1.AllowSelection = true;
                this.printDialog1.AllowSomePages = true;
                if (this.printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (this.printDocument1.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
                    {
                        this.printDocument1.PrinterSettings.FromPage = this.rdlView.PageCurrent;
                    } this.rdlView.Print(this.printDocument1);
                }
            }
            catch (Exception ex) { MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            string param = String.Format("TanggalLaporan={0} s/d {1}", waktu1.Value.ToString("yyyy-MM-dd"), waktu2.Value.ToString("yyyy-MM-dd"));
            string sql = ("select tb_absensi.tgl_absensi,tb_karyawan.nm_karyawan,(select count(*) from tb_absensi where tb_absensi.ktrmasuk='Tidak Masuk' and tb_absensi.nik = tb_karyawan.nik and tb_absensi.tgl_absensi >='" + waktu1.Value.ToString("yyyy-MM-dd") + "' and tb_absensi.tgl_absensi <='" + waktu2.Value.ToString("yyyy-MM-dd") + "') as Tidak_Masuk,(select count(*) from tb_absensi where tb_absensi.ktrmasuk='Terlambat' and tb_absensi.tgl_absensi >='" + waktu1.Value.ToString("yyyy-MM-dd") + "' and tb_absensi.tgl_absensi <='" + waktu2.Value.ToString("yyyy-MM-dd") + "' and tb_absensi.nik = tb_karyawan.nik) as Terlambat,(select count(*) from tb_absensi where tb_absensi.ktrpulang='Pulang Awal' and tb_absensi.nik = tb_karyawan.nik and tb_absensi.tgl_absensi >='" + waktu1.Value.ToString("yyyy-MM-dd") + "'" + " and tb_absensi.tgl_absensi <='" + waktu2.Value.ToString("yyyy-MM-dd") + "')" + "as Pulang_Awal from tb_karyawan,tb_absensi where tb_karyawan.nik=tb_absensi.nik and tb_absensi.tgl_absensi >='" + waktu1.Value.ToString("yyyy-MM-dd") + "' and tb_absensi.tgl_absensi <='" + waktu2.Value.ToString("yyyy-MM-dd") + "' group by tb_karyawan.nm_karyawan");
            Modul mo = new Modul();
            DataTable dt = new DataTable();
            dt = mo.BukaTabel(sql);
            loadReport("rpt_Rekap.rdl",dt,param);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
