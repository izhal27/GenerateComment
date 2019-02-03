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
using System.Linq;

namespace GenerateCommentAboutAuthor
{
   public partial class FrmMain : Form
   {

      #region >> Fields <<

      private string _rawXml = "<header></header><data></data>";

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Properties <<

      public int Lebar { get { return (int)nmUpDwnLebar.Value; } }

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
         rtBoxHasil.Text = Generate().ToString();
         SetControlFocus(btnCopy);
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

      private void rtBox_TextChanged(object sender, EventArgs e)
      {
         var status = rtBoxHeader.TextLength != 0 && rtBoxData.TextLength != 0;

         btnGenerate.Enabled = status;
         btnClear.Enabled = rtBoxHeader.TextLength != 0 || rtBoxData.TextLength != 0;
         saveSumberToolStripMenuItem.Enabled = status;
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
      /// <returns>Mengembalikan data yang sudah digenerate</returns>
      private StringBuilder Generate()
      {
         var sb = new StringBuilder();

         AppendTop(sb);
         AppendString(" ", sb);
         AppendHeader(sb);
         AppendString(" ", sb);
         AppendString("-", sb);
         AppendString(" ", sb);
         AppendDataDetail(sb);
         AppendString(" ", sb);
         AppendBottom(sb);
                  
         return sb;
      }
      
      /// <summary>
      /// Garis paling atas
      /// </summary>
      /// <param name="sbHasil"></param>
      private void AppendTop(StringBuilder sbHasil)
      {
         for (int c = 0; c < Lebar; c++)
         {
               if (c == 0)
               {
                  // Start
                  sbHasil.Append("/");
                  continue;
               }
            
            sbHasil.Append("*");
         }

         sbHasil.AppendLine();
      }      

      /// <summary>
      /// Garis paling bawah
      /// </summary>
      /// <param name="sbHasil"></param>
      private void AppendBottom(StringBuilder sbHasil)
      {
         for (int c = 0; c < Lebar; c++)
         {
               if (c == (Lebar - 1))
               {
                  // End
                  sbHasil.Append("/");
                  continue;
               }

            sbHasil.Append("*");
         }

         sbHasil.AppendLine();
      }
      
      /// <summary>
      /// Tambahkan spasi atau karakter
      /// </summary>
      /// <param name="str">Space atau karakter lainnya</param>
      /// <param name="sbHasil"></param>
      private void AppendString(string str, StringBuilder sbHasil)
      {
         for (int c = 0; c < Lebar; c++)
         {
            if (c == 0 || c == (Lebar - 3))
            {
               sbHasil.Append("**");
            }
            else if (c >= 1 && c <= (Lebar - 3))
            {
               sbHasil.Append(str);
            }
         }

         sbHasil.AppendLine();
      }

      /// <summary>
      /// Tambahkan data header
      /// </summary>
      /// <param name="sb"></param>
      private void AppendHeader(StringBuilder sb)
      {
         var headerLinesLength = rtBoxHeader.Lines.Count(t => !string.IsNullOrWhiteSpace(t));
         var textQueue = new Queue<char>();

         for (int i = 0; i < headerLinesLength; i++)
         {
            foreach (var c in CenterText(rtBoxHeader.Lines[i]))
            {
               textQueue.Enqueue(c);
            }

            for (int c = 0; c < Lebar; c++)
            {
               if (c <= 1 || c >= (Lebar - 2))
               {
                  sb.Append("*");
               }
               else if (c >= 2 && textQueue.Any())
               {
                  sb.Append(textQueue.Dequeue());
               }
               else
               {
                  sb.Append(" ");
               }
            }

            sb.AppendLine();
         }
      }

      /// <summary>
      /// Tambahkan data detail
      /// </summary>
      /// <param name="sb"></param>
      private void AppendDataDetail(StringBuilder sb)
      {
         var dataLinesLength = rtBoxData.Lines.Count(t => !string.IsNullOrWhiteSpace(t));
         var textQueue = new Queue<char>();

         for (int i = 0; i < dataLinesLength; i++)
         {
            foreach (var s in rtBoxData.Lines[i])
            {
               textQueue.Enqueue(s);
            }

            for (int c = 0; c < Lebar; c++)
            {
               if (c <= 1 || c >= (Lebar - 2))
               {
                  sb.Append("*");
               }
               else if (c >= 4 && textQueue.Any())
               {
                  sb.Append(textQueue.Dequeue());
               }
               else
               {
                  sb.Append(" ");
               }
            }

            sb.AppendLine();
         }
      }

      /// <summary>
      /// Membuat text menjadi rata tengah
      /// </summary>
      /// <param name="str">Text yang ingin dijadikan rata tengah</param>
      /// <returns>Mengembalikan text yang telah rata tengah</returns>
      private string CenterText(string str)
      {
         // Mencari selisih kiri kanan menggunakan rumus
         // Lebar (jumlah karakter) dikurang 4 (bintang kiri dan kanan) lalu dibagi 2,
         // lalu tambahkan spasi sebanyak margin kiri/kanan yang didapatkan
         var marginLeft = ((Lebar - 4) - str.Length) / 2;
         var temp = string.Empty;

         for (int i = 0; i < marginLeft; i++)
         {
            temp += " ";
         }

         // Tambahkan spasi margin dengan text
         temp += str;

         return temp;
      }

      /// <summary>
      /// Perintah untuk menyimpan
      /// text sumber
      /// </summary>
      private void SaveSumber()
      {
         if (!string.IsNullOrEmpty(rtBoxData.Text) && rtBoxData.Text.Trim().Length != 0)
         {
            int lokasi = LokasiEnter(rtBoxData.Text);
            var saveFileDialog = new SaveFileDialog();

            if (lokasi != 0)
               saveFileDialog.FileName = rtBoxData.Text.Substring(0, lokasi);
            else
               saveFileDialog.FileName = rtBoxData.Text.Trim();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            DialogResult result = saveFileDialog.ShowDialog();
            string file = saveFileDialog.FileName;
            string data = rtBoxData.Text;
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
               rtBoxData.Text = ReadFile(openFileDialog.FileName);
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

      private void ClearControls(Control control)
      {
         foreach (Control ctrl in control.Controls)
         {
            if (ctrl is RichTextBox) ((RichTextBox)ctrl).Clear();

            ClearControls(ctrl);
         }
      }

      #endregion

   }
}
