using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//////////////////////////////////////////LAPORAN PERHARI//////////////////////////////////////////
namespace SMA_Negri_5_Madiun
{
    public partial class LaporanPelanggaranPerHari : Form
    {
        fyiReporting.RdlViewer.RdlViewer rdlView = new fyiReporting.RdlViewer.RdlViewer();
        DataTable dt = new DataTable();
        Modul db = new Modul();

        public LaporanPelanggaranPerHari()
        {
            InitializeComponent();
        }

        private void LaporanPelanggaranPerHari_Load(object sender, EventArgs e)
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

        private void DateTime_ValueChanged(object sender, EventArgs e)
        {
            //DataTable dataT = new DataTable();
            //Modul db = new Modul();
            //dataT = db.BukaTabel("Select * From t_pelanggaran where tanggal='" + DateTime.Value.ToString("yyyy-MM-dd") + "'");
            //LoadReport("ReportPealanggaranSiswa.rdl", dataT);
        }

        private void toolExcel_Click(object sender, EventArgs e)
        {
            dt = db.BukaTabel("select * from t_pelanggaran");
            ExportExcel xlx = new ExportExcel();
            xlx.ExExcel(dt, "Laporan Pelanggaran Siswa ");
        }

        private void BtnLihat_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modul db = new Modul();
            ExportExcel excel = new ExportExcel();
            string date1 = waktu1.Value.ToString();
              string date2 = waktu2.Value.ToString();
            //dataT = db.BukaTabel("Select * From t_pelanggaran where tanggal='" + DateTime.Value.ToString("yyyy-MM-dd") + "'");
            dt =db.BukaTabel( "select * from t_pelanggaran where tanggal >='" + waktu1.Value.ToString("yyyy-MM-dd") + "' and tanggal <='" + waktu2.Value.ToString("yyyy-MM-dd") + "'");
            LoadReport("ReportPelanggaran.rdl", dt); 
            
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
