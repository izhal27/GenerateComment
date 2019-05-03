/***********************************************************
**                                                        **
**                Generate Comment Author                 **
**                 Risal Walangadi ©2019                  **
**                                                        **
**--------------------------------------------------------**
**                                                        **
**  File Name : FrmMain.cs                                **
**  Description : Main form untuk mengenerate data        **
**  License : GNU GPL v3.0                                **
**  https://www.gnu.org/licenses/gpl.txt                  **
**                                                        **
***********************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

namespace GenerateComment
{
   public partial class FrmMain : Form
   {

      #region >> Fields <<

      private string _filePathXML;

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
         saveToolStripMenuItem.Enabled = status;
      }

      private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
      {
         LoadFromXML();
      }

      private void closeDataToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SetFilePath();
         ClearControls(this);
      }

      private void saveToolStripMenuItem_Click(object sender, EventArgs e)
      {
         // Jika tidak ada data dimuat, maka buat file baru,
         // sebaliknya simpan data pada file yang di muat
         if (!string.IsNullOrWhiteSpace(_filePathXML))
         {
            Save(_filePathXML);
            ((ToolStripMenuItem)sender).Enabled = false;
         }
         else
         {
            SaveToXML();
         }
      }

      private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         SaveToXML();
      }

      private void tentangToolStripMenuItem_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Generate Comment Author\nRisal Walangadi ©2019", "Info"
            , MessageBoxButtons.OK
            , MessageBoxIcon.Information);
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
      /// MMethod untuk mnggenerate data
      /// </summary>
      /// <returns>Mengembalikan data yang sudah digenerate</returns>
      private StringBuilder Generate()
      {
         var sb = new StringBuilder();

         try
         {
            AppendTop(sb);
            AppendString(" ", sb);
            AppendHeader(sb);
            AppendString(" ", sb);
            AppendString("-", sb); // Garis pembatas
            AppendString(" ", sb);
            AppendDataDetail(sb);
            AppendString(" ", sb);
            AppendBottom(sb);
         }
         catch (Exception ex)
         {
            MessageHelper.Error(ex);
         }

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
      /// Method untuk menyimpan data ke file XML
      /// </summary>
      private void SaveToXML()
      {
         try
         {
            if (!string.IsNullOrEmpty(rtBoxData.Text) && rtBoxData.Text.Trim().Length != 0)
            {
               var saveFileDialog = new SaveFileDialog();
               saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
               saveFileDialog.Filter = "XML Files|*.xml";

               if (saveFileDialog.ShowDialog() == DialogResult.OK)
               {
                  SetFilePath(saveFileDialog.FileName);
                  Save(saveFileDialog.FileName);
               }
            }
         }
         catch (Exception ex)
         {
            MessageHelper.Error(ex);
         }
      }

      /// <summary>
      /// Method untuk menyimpan data yang dimuat
      /// </summary>
      /// <param name="filePath"></param>
      private void Save(string filePath)
      {
         try
         {
            var xdoc = new XDocument();
            var root = new XElement("Root");
            var header = new XElement("Header");
            var data = new XElement("Data");

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
            xdoc.Save(filePath);
         }
         catch (Exception ex)
         {
            MessageHelper.Error(ex);
         }
      }

      /// <summary>
      /// Method untuk memuat data dari file XML
      /// </summary>
      private void LoadFromXML()
      {
         try
         {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "XML Files|*.xml";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               SetFilePath(openFileDialog.FileName);

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
         }
         catch (Exception ex)
         {
            MessageHelper.Error(ex);
         }
      }

      /// <summary>
      /// Method yang digunakan untuk mengatur path file yang dimuat
      /// </summary>
      /// <param name="filePath">Path file</param>
      private void SetFilePath(string filePath = default(string))
      {
         var defaultText = "Generate Comment Author";

         _filePathXML = !string.IsNullOrWhiteSpace(filePath) ? filePath : default(string);
         Text = !string.IsNullOrWhiteSpace(filePath) ? (defaultText + " - " + Path.GetFileName(_filePathXML)) : defaultText;

         closeDataToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(filePath);
         saveAsToolStripMenuItem.Enabled = !string.IsNullOrWhiteSpace(filePath);
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

      /// <summary>
      /// Method yang digunakan untuk mengatur focus sebuah control
      /// </summary>
      /// <param name="control">Control target</param>
      private void SetControlFocus(Control control)
      {
         ActiveControl = control;
      }

      #endregion

   }
}
