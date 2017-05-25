using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
////////////////////////////////////////LAPORAN PERSISWA////////////////////////////////////////////////
namespace SMA_Negri_5_Madiun
{
    public partial class LaporanPelanggaranPerSiswa : Form
    {
        fyiReporting.RdlViewer.RdlViewer rdlView = new fyiReporting.RdlViewer.RdlViewer();

        public LaporanPelanggaranPerSiswa()
        {
            InitializeComponent();
        }

        private void LaporanPelanggaranPerSiswa_Load(object sender, EventArgs e)
        {
            rdlView.ShowParameterPanel = false;
            rdlView.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(rdlView);
        }

        public void LoadReport(string sourceFile)
        {
            try
            {
                rdlView.SourceFile = string.Format("{0}\\{1}", Application.StartupPath, sourceFile);
                rdlView.Rebuild();
                this.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void LoadReport(string sourceFile, DataTable dt)
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

        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                this.printDocument1.DocumentName = this.Text;
                this.printDocument1.PrinterSettings.FromPage = 1;
                this.printDocument1.PrinterSettings.ToPage = this.rdlView.PageCount;
                this.printDocument1.PrinterSettings.MaximumPage = this.rdlView.PageCount;
                this.printDocument1.PrinterSettings.MinimumPage = 1;

                if (this.rdlView.PageWidth > this.rdlView.PageHeight)
                {
                    this.printDocument1.DefaultPageSettings.Landscape = true;
                }
                else
                {
                    this.printDocument1.DefaultPageSettings.Landscape = false;
                }
                this.printDialog1.Document = this.printDocument1;
                this.printDialog1.AllowSelection = true;
                this.printDialog1.AllowSomePages = true;

                if (this.printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (this.printDocument1.PrinterSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
                    {
                        this.printDocument1.PrinterSettings.FromPage = this.rdlView.PageCurrent;
                    }
                    this.rdlView.Print(this.printDocument1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fl;
            DataTable dataT = new DataTable();
            Modul db = new Modul();
            fl = " WHERE (nama like '%" + this.txtCari.Text.Replace("'", "''") + "%')";
            dataT = db.BukaTabel("Select nis,nama,kelas,tanggal,nm_pelanggaran,jenis_pelanggaran,point From t_pelanggaran" + fl);
            LoadReport("ReportPealanggaranSiswa.rdl",dataT);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string fl;
            DataTable dataT = new DataTable();
            Modul db = new Modul();
            fl = " WHERE (nama like '%" + this.txtCari.Text.Replace("'", "''") + "%')";
            dataT = db.BukaTabel("Select nis,nama,kelas,tanggal,nm_pelanggaran,jenis_pelanggaran,point From t_pelanggaran" + fl);
            ExportExcel xlx = new ExportExcel();
            xlx.ExExcel(dataT, "Laporan ");

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modul db = new Modul();
            dt = db.BukaTabel("select * from t_pelanggaran");
            ExportExcel xlx = new ExportExcel();
            xlx.ExExcel(dt, "Laporan Pelanggaran Siswa ");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.saveFileDialog1.ShowDialog();
            if (!(this.saveFileDialog1.FileName == string.Empty))
            {
                this.rdlView.SaveAs(this.saveFileDialog1.FileName, "pdf");
            }
        }
    }
}
