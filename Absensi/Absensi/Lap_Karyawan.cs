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
    public partial class Lap_Karyawan : Form
    {
        fyiReporting.RdlViewer.RdlViewer rdlView = new fyiReporting.RdlViewer.RdlViewer();
        public Lap_Karyawan()
        {
            InitializeComponent();
        }
        public void loadReport(string sourceFile,DataTable dt)
        {
            try {
                rdlView.SourceFile = string.Format("{0}\\{1}", Application.StartupPath, sourceFile,dt);
                rdlView.Report.DataSets["Data"].SetData(dt);
                rdlView.Rebuild();
                this.Show();
            }
            catch(Exception e) {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void Lap_KaryawanAktif_Load(object sender, EventArgs e)
        {
            rdAll.Checked=true;
            rdlView.ShowParameterPanel = false;
            rdlView.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(rdlView);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try {
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
            catch (Exception ex) { MessageBox.Show(this,ex.Message,this.Text,MessageBoxButtons.OK,MessageBoxIcon.Information); }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.DefaultExt = "pdf";
            this.saveFileDialog1.Filter = "PDF files(*.pdf)|*pdf|All files (*.*)|*.*";
            this.saveFileDialog1.ShowDialog();
            if (!(saveFileDialog1.FileName == string.Empty))
            { this.rdlView.SaveAs(this.saveFileDialog1.FileName, "pdf"); }
        }

        private void rdAktif_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modul db = new Modul();
            string sql = ("SELECT nik,nm_karyawan,tanggal_lahir,alamat,jk,id_jabatan,notelp,tgl_masuk FROM tb_karyawan where status=1");
            dt = db.BukaTabel(sql);
            loadReport("rpt_karyawanAktif.rdl", dt);
        }

        private void rdNonAktif_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modul db = new Modul();
            string sql = ("SELECT nik,nm_karyawan,tanggal_lahir,alamat,jk,id_jabatan,notelp,tgl_masuk FROM tb_karyawan where status=2");
            dt = db.BukaTabel(sql);
            loadReport("rpt_karyawanNonAktif.rdl", dt);
        }

        private void rdAll_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Modul db = new Modul();
            string sql = ("SELECT nik,nm_karyawan,tanggal_lahir,alamat,jk,id_jabatan,notelp,tgl_masuk FROM tb_karyawan");
            dt = db.BukaTabel(sql);
            loadReport("rpt_karyawan.rdl", dt);
           
           
        }
    }
}
