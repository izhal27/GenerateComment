/***************************************
*                                      *
*                                      *
*  Program : Generate Comment Pembuat  *
*  Pembuat : Risal Walangadi           *
*  Tahun : 2015                        *
*                                      *
*                                      *
***************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GenerateCommentAboutAuthor
{
   public partial class FrmMain : Form
   {

      #region >> Fields <<

      private static int panjang, lebar;
      private static string temp;
      private static List<string> hasil;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmMain()
      {
         InitializeComponent();
         btnGenerate.Enabled = false;
         btnClear.Enabled = false;
         saveSumberToolStripMenuItem.Enabled = false;
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void mainForm_Load(object sender, EventArgs e)
      {
         SetControlFocus(rtBoxHeader);
      }

      private void tblGenerate_Click(object sender, EventArgs e)
      {
         if (rtBoxSumber.TextLength != 0)
         {
            rtBoxHasil.Lines = Generate(rtBoxSumber.Lines).ToArray();
            SetControlFocus(btnCopy);
         }
      }

      private void tblClear_Click(object sender, EventArgs e)
      {
         ClearControls(this);
         SetControlFocus(rtBoxHeader);
      }

      private void SetControlFocus(Control control)
      {
         ActiveControl = control;
      }

      private void ClearControls(Control control)
      {
         foreach (Control ctrl in control.Controls)
         {
            if (ctrl is RichTextBox) ((RichTextBox)ctrl).Clear();

            ClearControls(ctrl);
         }
      }

      private void rchSumber_TextChanged(object sender, EventArgs e)
      {
         if (rtBoxSumber.TextLength != 0)
         {
            btnGenerate.Enabled = true;
            btnClear.Enabled = true;
            saveSumberToolStripMenuItem.Enabled = true;
         }
         else
         {
            btnGenerate.Enabled = false;
            btnClear.Enabled = false;
            saveSumberToolStripMenuItem.Enabled = false;
         }
      }

      private void muatSumberToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MuatSumber();
      }

      private void saveSumberToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveSumber();
      }

      private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Generate Comment Author\nBy: Risal Walangadi ©2015 - " + DateTime.Now.Year,
            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      private void exitToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void rtBoxHasil_TextChanged(object sender, EventArgs e)
      {
         btnCopy.Enabled = rtBoxHasil.Text.Length != 0;
      }

      private void btnCopy_Click(object sender, EventArgs e)
      {
         rtBoxHasil.SelectAll();
         rtBoxHasil.Copy();
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         Close();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region methods

      /// <summary>
      /// Menggenerate teks data sumber
      /// </summary>
      /// <param name="data">data yang ingin digenerate</param>
      /// <returns>Mengembalikan data yang sudah digenerate</returns>
      private static List<string> Generate(string[] data)
      {
         panjang = KataTerpanjang(data) + 6;

         lebar = data.Length + 6;

         hasil = new List<string>();

         for (int baris = 1; baris <= lebar; baris++)
         {
            temp = "";
            if (baris == 1 || baris == lebar)
            {
               // buat * sebanyak teks yang terpanjang panjang               
               for (int kolom = 1; kolom <= panjang; kolom++)
               {
                  if ((baris == 1 && kolom == 1) && kolom != panjang)
                  {
                     temp += "/";
                     continue;
                  }
                  if (baris == lebar && kolom == panjang)
                  {
                     temp += "/";
                     continue;
                  }
                  temp += "*";

               }
               hasil.Add(temp);
               temp = "";
            }
            else
            {
               if (baris == 4)
               {
                  for (int barisData = 1; barisData <= data.Length; barisData++)
                  {
                     if (data.Length > 1)
                     {
                        if (barisData == data.Length)
                        {
                           temp += string.Format("*  {0,-" + (panjang - 4) + "}*", data[barisData - 1]);
                           continue;
                        }
                        temp += string.Format("*  {0,-" + (panjang - 4) + "}*\n", data[barisData - 1]);
                     }
                     else
                     {
                        temp += string.Format("*  {0,-" + (panjang - 4) + "}*", data[barisData - 1]);
                     }
                  }
                  baris += data.Length - 1;
                  hasil.Add(temp);
                  temp = "";
               }
               else
               {
                  // buat * di ujung kiri
                  temp += "*";
                  for (int kolom = 2; kolom < panjang; kolom++)
                     temp += " ";
                  // buat * di ujung kanan
                  temp += "*";
                  hasil.Add(temp);
                  temp = "";
               }
            }
         }

         return hasil;
      }

      /// <summary>
      /// Mencari kata yang terpanjang
      /// </summary>
      /// <param name="data">Data yang ingin di proses</param>
      /// <returns>Mengembalikan panjang kata</returns>
      private static int KataTerpanjang(string[] data)
      {
         panjang = 0;

         for (int i = 0; i < data.Length; i++)
         {
            if (data[i].Length > panjang)
               panjang = data[i].Length;
         }

         return panjang;
      }

      /// <summary>
      /// Perintah untuk menyimpan
      /// text sumber
      /// </summary>
      private void SaveSumber()
      {
         if (!string.IsNullOrEmpty(rtBoxSumber.Text) && rtBoxSumber.Text.Trim().Length != 0)
         {
            int lokasi = LokasiEnter(rtBoxSumber.Text);
            var saveFileDialog = new SaveFileDialog();

            if (lokasi != 0)
               saveFileDialog.FileName = rtBoxSumber.Text.Substring(0, lokasi);
            else
               saveFileDialog.FileName = rtBoxSumber.Text.Trim();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            DialogResult result = saveFileDialog.ShowDialog();
            string file = saveFileDialog.FileName;
            string data = rtBoxSumber.Text;
            try
            {
               if (result == DialogResult.OK)
                  SaveFile(file, data);
            }
            catch (IOException ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }

      /// <summary>
      /// Perintah untuk memuat data sumber
      /// </summary>
      private void MuatSumber()
      {
         var openFileDialog = new OpenFileDialog();
         openFileDialog.InitialDirectory = Environment.CurrentDirectory;
         openFileDialog.FileName = "";

         if (openFileDialog.ShowDialog() == DialogResult.OK)
         {
            try
            {
               rtBoxSumber.Text = ReadFile(openFileDialog.FileName);
               if (rtBoxHasil.Text.Length != 0)
                  rtBoxHasil.Clear();
               ActiveControl = btnGenerate;
            }
            catch (IOException ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }

      /// <summary>
      /// Membaca teks dari file yang dipilih
      /// </summary>
      /// <param name="lokasiFile">Tempat penyimpanan file</param>
      /// <returns></returns>
      private static string ReadFile(string lokasiFile)
      {
         using (StreamReader reader = new StreamReader(lokasiFile))
         {
            return reader.ReadToEnd();
         }
      }

      /// <summary>
      /// Menyimpan file ke lokasi yang dipilih
      /// </summary>
      /// <param name="lokasiFile">Lokasi penyimpanan file</param>
      /// <param name="data">Data yang akan disimpan</param>
      private static void SaveFile(string lokasiFile, string data)
      {
         using (StreamWriter writer = new StreamWriter(lokasiFile))
         {
            writer.Write(data);
         }
      }

      /// <summary>
      /// Mencari lokasi enter pertama
      /// </summary>
      /// <param name="data">Data teks</param>
      /// <returns>Mengembalikan lokasi enter</returns>
      private static int LokasiEnter(string data)
      {
         int lokasi = data.IndexOf('\n');

         if (lokasi != -1)
            return lokasi;

         return 0;
      }

      #endregion

   }
}
