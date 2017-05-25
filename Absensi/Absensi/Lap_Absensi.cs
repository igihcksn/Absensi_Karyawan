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
    public partial class Lap_absensi : Form
    {
        fyiReporting.RdlViewer.RdlViewer rdlView = new fyiReporting.RdlViewer.RdlViewer();
        public Lap_absensi()
        {
            InitializeComponent();
        }

        private void Lap_Harian_Load(object sender, EventArgs e)
        {
            rdlView.ShowParameterPanel = false;
            rdlView.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(rdlView);
        }
        public void LoadReport(string sourceFile,DataTable dt)
        {
            try
            {
                rdlView.SourceFile = string.Format("{0}\\{1}", Application.StartupPath, sourceFile,dt);
                rdlView.Report.DataSets["Data"].SetData(dt);
                rdlView.Rebuild();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void btnLihat_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modul db = new Modul();
            string sql = ("select tb_absensi.tgl_absensi, tb_karyawan.nm_karyawan,concat(tb_jadwal.masuk,' - ',tb_jadwal.pulang) as Jadwal_masuk,concat(tb_absensi.jamMasuk,' - ',tb_absensi.jamPulang) as Jam_Masuk,tb_absensi.ktrmasuk as Ktr_Masuk,tb_absensi.ktrpulang as Ktr_Pulang,tb_absensi.alasanIzin from tb_absensi,tb_jadwal,tb_karyawan WHERE tb_jadwal.nik= tb_absensi.nik and tb_absensi.nik = tb_karyawan.nik and tb_absensi.tgl_absensi >='" + waktu1.Value.ToString("yyyy-MM-dd") + "' and tgl_absensi <='" + waktu2.Value.ToString("yyyy-MM-dd") + "'order by tgl_absensi");
            string date1 = waktu1.Value.ToString();
            string date2 = waktu2.Value.ToString();
            dt = db.BukaTabel(sql);
            LoadReport("rpt_harian.rdl", dt);
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "PDF files(*.pdf)|*pdf|All files (*.*)|*.*";
            this.saveFileDialog1.ShowDialog();
            if (!(saveFileDialog1.FileName == string.Empty))
            { this.rdlView.SaveAs(this.saveFileDialog1.FileName, "pdf"); }
        }

       
    }
}
