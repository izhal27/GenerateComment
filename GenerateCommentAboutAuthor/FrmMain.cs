/*************************************************
**                                              **
**               Generate Comment               **
**            Risal Walangadi ©2015             **
**                                              **
**----------------------------------------------**
**                                              **
**  File Name : FrmMain.cs                      **
**  Description :                               **
**  License :                                   **
**                                              **
*************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace GenerateCommentAboutAuthor
{
   public partial class FrmMain : Form
   {
      
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
         saveToXMLToolStripMenuItem.Enabled = false;
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

      private void rtBox_TextChanged(object sender, EventArgs e)
      {
         var status = rtBoxHeader.TextLength != 0 && rtBoxData.TextLength != 0;

         btnGenerate.Enabled = status;
         btnClear.Enabled = rtBoxHeader.TextLength != 0 || rtBoxData.TextLength != 0;
         saveToXMLToolStripMenuItem.Enabled = status;
      }

      private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
      {
         LoadFromXML();
      }

      private void saveToXMLToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveToXML();
      }

      private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Generate Comment Author\nBy: Risal Walangadi ©2015 - "
            + DateTime.Now.Year, "Info", MessageBoxButtons.OK
            , MessageBoxIcon.Information);
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

      #region >> Methods <<

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
         AppendString("-", sb); // Garis pembatas
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
         // Cari tinggi baris dari data header, dengan mengabaikan spasi
         var headerLinesLength = rtBoxHeader.Lines.Count(t => !string.IsNullOrWhiteSpace(t));
         var textQueue = new Queue<char>();

         for (int i = 0; i < headerLinesLength; i++)
         {
            // Buat setiap text dalam data header menjadi rata tengah
            // Lalu masukkan setiap huruf baris dari header ke object textQueue
            foreach (var c in CenterText(rtBoxHeader.Lines[i]))
            {
               textQueue.Enqueue(c);
            }

            for (int c = 0; c < Lebar; c++)
            {
               if (c <= 1 || c >= (Lebar - 2))
               {
                  sb.Append("*"); // 2 Bintang di kiri dan kanan
               }
               // Cek jika index lebar sekarang 2, untuk membuat gap 2 spasi
               // dan cek jika masih ada huruf di textQueue
               else if (c >= 2 && textQueue.Any())
               {
                  // Keluarkan huruf dari textQueue untuk dimasukkan ke StringBuilder object
                  sb.Append(textQueue.Dequeue());
               }
               else
               {
                  // Spasi kiri dan kanan jika tidak terdapat huruf lagi
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

         // Tambahkan spasi margin dengan text yang ada
         temp += str;

         return temp;
      }

      /// <summary>
      /// Perintah untuk menyimpan data ke file XML
      /// </summary>
      private void SaveToXML()
      {
         if (!string.IsNullOrEmpty(rtBoxData.Text) && rtBoxData.Text.Trim().Length != 0)
         {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.Filter = "XML Files|*.xml";

            try
            {
               if (saveFileDialog.ShowDialog() == DialogResult.OK)
               {
                  XDocument xdoc = new XDocument();
                  XElement root = new XElement("Root");
                  XElement header = new XElement("Header");
                  XElement data = new XElement("Data");

                  // Ambil setiap line di rtBoxHeader untuk dijadikan element,
                  // contoh <Line0>Data pada baris pertama</Line0>
                  List<XElement> listHeader = rtBoxHeader.Lines
                     .ToList().Select((v, i) => { return new XElement("Line" + i, v); }).ToList();
                  // Tambahkan pada instance header element
                  header.Add(listHeader);

                  List<XElement> listData = rtBoxData.Lines
                     .ToList().Select((v, i) => { return new XElement("Line" + i, v); }).ToList();
                  // Tambahkan pada instance data element
                  data.Add(listData);

                  // Tambahkan header dan data pada root element
                  root.Add(header);
                  root.Add(data);
                  // Tambahkan root pada instance xdoc
                  xdoc.Add(root);

                  // Simpan sesuai lokasi dan filename yang ditentukan
                  xdoc.Save(saveFileDialog.FileName);
               }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }

      /// <summary>
      /// Perintah untuk memuat data dari file XML
      /// </summary>
      private void LoadFromXML()
      {
         var openFileDialog = new OpenFileDialog();
         openFileDialog.InitialDirectory = Environment.CurrentDirectory;
         openFileDialog.Filter = "XML Files|*.xml";
         openFileDialog.FileName = "";

         if (openFileDialog.ShowDialog() == DialogResult.OK)
         {
            try
            {
               XDocument xdoc = XDocument.Load(openFileDialog.FileName);
               // Ambil data Header dan Data dari file XML
               var listHeader = xdoc.Descendants("Header").Elements().ToList();
               var listData = xdoc.Descendants("Data").Elements().ToList();

               // Pilih hanya value dan masukkan ke rtBoxHeader dan rtBocData
               rtBoxHeader.Lines = listHeader.Select(el => { return el.Value; }).ToArray();
               rtBoxData.Lines = listData.Select(el => { return el.Value; }).ToArray();

               // Hapus hasil yang ada
               rtBoxHasil.Clear();

               // Focus ke btnGenerate
               ActiveControl = btnGenerate;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
         }
      }

      /// <summary>
      /// Hapus text yang ada pada control RichTextBox
      /// </summary>
      /// <param name="control">Base control</param>
      private void ClearControls(Control control)
      {
         foreach (Control ctrl in control.Controls)
         {
            // Jika control sekarang adalah RichTextBox
            // hapus text yang ada di dalam control
            if (ctrl is RichTextBox) ((RichTextBox)ctrl).Clear();

            // Recrusive function
            // untuk mengecek jika masih terdapat control di dalam control sekarang
            ClearControls(ctrl);
         }
      }

      private void SetControlFocus(Control control)
      {
         ActiveControl = control;
      }

      #endregion

   }
}
