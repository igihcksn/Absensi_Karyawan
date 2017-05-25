using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Absensi
{
     class Modul
    {
         string strKoneksi = "host="+getAppSetting("127.0.0.1")+";user="+getAppSetting("root")+";password="+getAppSetting("")+";database="+getAppSetting("absensi")+";Convert Zero Datetime="+getAppSetting("dt")+"";
        
         MySqlConnection koneksi = null;
         MySqlCommand cmd = null;
         MySqlDataReader dr = null;
         public static string status = "Karyawan";
         public static string strproses = "tambah";
         public static string izin="Izin";
         public static string login="";
         public static string keterangan="Masuk";
         public static string kirimanJamMasuk = "00:00";
         public static string kirimanJamPulang = "00:00";

         public static void autoref()
         {
             ConfigurationManager.RefreshSection("appSettings");
         }

         public static string getAppSetting(string key)
         {
             Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);

             return config.AppSettings.Settings[key].Value;
         }

         public static void setAppSetting(string key, string value)
         {
             Configuration config = ConfigurationManager.OpenExeConfiguration(System.Reflection.Assembly.GetExecutingAssembly().Location);

             if (config.AppSettings.Settings[key] != null)
             {
                 config.AppSettings.Settings.Remove(key);
             }
             config.AppSettings.Settings.Add(key, value);
             config.Save(ConfigurationSaveMode.Modified);
         }
         public DataTable BukaTabel(string isiSql)
         {
             koneksi = new MySqlConnection(strKoneksi);
             try
             {
                 koneksi.Open();
                 cmd = new MySqlCommand(isiSql, koneksi);
                 //cmd.ExecuteNonQuery();
                 dr = cmd.ExecuteReader();
             }
             catch
             {
                 pesanKesalahan("Koneksi database gagal..");
             }
             DataTable dt = new DataTable();
             dt.Load(dr);
             dr.Close();
             koneksi.Close();
             return dt;
         }
         
         public bool AksiQuery(string strSql)
         {
             koneksi = new MySqlConnection(strKoneksi);
             koneksi.Open();
             cmd = new MySqlCommand(strSql, koneksi);
             cmd.ExecuteNonQuery();
             koneksi.Close();
             
             return true;
         }

         public string ImageToBase64(Image image)
         {
             using (MemoryStream ms = new MemoryStream())
             {
                 //convert image menjadi byte
                 image.Save(ms, image.RawFormat);
                 byte[] imageByte = ms.ToArray();
                  
                 //convert byte menjadi base64string
                 string base64String = Convert.ToBase64String(imageByte);
                 return base64String;
             }
         }
         public Image Base64ToImage(string base64String)
         {
             // Convert Base64 String to byte[]
             byte[] imageBytes = Convert.FromBase64String(base64String);
             MemoryStream ms = new MemoryStream(imageBytes, 0,
             imageBytes.Length);

             // Convert byte[] to Image
             ms.Write(imageBytes, 0, imageBytes.Length);
             Image image = Image.FromStream(ms, true);
             return image;
         }

         public void pesanKesalahan(string judul)
        {
            MessageBox.Show(judul, "SIPU v 0.1", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void PesanBenar(string judul)
        {
            MessageBox.Show(judul, "SIPU v 0.1", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void pesanPemberitahuan(string judul)
        {
            MessageBox.Show(judul, "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
