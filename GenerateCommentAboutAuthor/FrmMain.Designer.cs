namespace GenerateCommentAboutAuthor
{
   partial class FrmMain
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
         this.btnGenerate = new System.Windows.Forms.Button();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnExit = new System.Windows.Forms.Button();
         this.rtBoxData = new System.Windows.Forms.RichTextBox();
         this.rtBoxHasil = new System.Windows.Forms.RichTextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.btnCopy = new System.Windows.Forms.Button();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.nmUpDwnLebar = new System.Windows.Forms.NumericUpDown();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.rtBoxHeader = new System.Windows.Forms.RichTextBox();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.menuStrip1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnLebar)).BeginInit();
         this.tableLayoutPanel2.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.SuspendLayout();
         // 
         // btnGenerate
         // 
         this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnGenerate.Location = new System.Drawing.Point(3, 3);
         this.btnGenerate.Name = "btnGenerate";
         this.btnGenerate.Size = new System.Drawing.Size(75, 35);
         this.btnGenerate.TabIndex = 3;
         this.btnGenerate.Text = "&Generate";
         this.btnGenerate.UseVisualStyleBackColor = true;
         this.btnGenerate.Click += new System.EventHandler(this.tblGenerate_Click);
         // 
         // btnClear
         // 
         this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnClear.Location = new System.Drawing.Point(84, 3);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(75, 35);
         this.btnClear.TabIndex = 4;
         this.btnClear.Text = "&Clear";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.tblClear_Click);
         // 
         // btnExit
         // 
         this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnExit.Location = new System.Drawing.Point(165, 3);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(75, 35);
         this.btnExit.TabIndex = 5;
         this.btnExit.Text = "&Exit";
         this.btnExit.UseVisualStyleBackColor = true;
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // rtBoxData
         // 
         this.rtBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel1.SetColumnSpan(this.rtBoxData, 2);
         this.rtBoxData.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rtBoxData.Location = new System.Drawing.Point(3, 199);
         this.rtBoxData.Name = "rtBoxData";
         this.rtBoxData.Size = new System.Drawing.Size(359, 213);
         this.rtBoxData.TabIndex = 2;
         this.rtBoxData.Text = "";
         this.rtBoxData.WordWrap = false;
         this.rtBoxData.TextChanged += new System.EventHandler(this.rtBox_TextChanged);
         // 
         // rtBoxHasil
         // 
         this.rtBoxHasil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel3.SetColumnSpan(this.rtBoxHasil, 2);
         this.rtBoxHasil.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.rtBoxHasil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rtBoxHasil.Location = new System.Drawing.Point(3, 33);
         this.rtBoxHasil.Name = "rtBoxHasil";
         this.rtBoxHasil.ReadOnly = true;
         this.rtBoxHasil.Size = new System.Drawing.Size(471, 379);
         this.rtBoxHasil.TabIndex = 5;
         this.rtBoxHasil.TabStop = false;
         this.rtBoxHasil.Text = "";
         this.rtBoxHasil.WordWrap = false;
         this.rtBoxHasil.TextChanged += new System.EventHandler(this.rtBoxHasil_TextChanged);
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(3, 35);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(59, 19);
         this.label1.TabIndex = 6;
         this.label1.Text = "Header";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(3, 5);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(44, 19);
         this.label2.TabIndex = 7;
         this.label2.Text = "Hasil";
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(869, 24);
         this.menuStrip1.TabIndex = 8;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromXMLToolStripMenuItem,
            this.saveToXMLToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // loadFromXMLToolStripMenuItem
         // 
         this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
         this.loadFromXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
         this.loadFromXMLToolStripMenuItem.Text = "&Load Data From XML";
         this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
         // 
         // saveToXMLToolStripMenuItem
         // 
         this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
         this.saveToXMLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
         this.saveToXMLToolStripMenuItem.Text = "&Save Data To XML";
         this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // tentangToolStripMenuItem
         // 
         this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
         this.tentangToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
         this.tentangToolStripMenuItem.Text = "&Tentang";
         this.tentangToolStripMenuItem.Click += new System.EventHandler(this.tentangToolStripMenuItem_Click);
         // 
         // btnCopy
         // 
         this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.btnCopy.Enabled = false;
         this.btnCopy.Location = new System.Drawing.Point(374, 3);
         this.btnCopy.Name = "btnCopy";
         this.btnCopy.Size = new System.Drawing.Size(75, 35);
         this.btnCopy.TabIndex = 6;
         this.btnCopy.Text = "Co&py";
         this.btnCopy.UseVisualStyleBackColor = true;
         this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Controls.Add(this.nmUpDwnLebar, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.rtBoxData, 0, 4);
         this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.rtBoxHeader, 0, 2);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 5;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.Size = new System.Drawing.Size(365, 415);
         this.tableLayoutPanel1.TabIndex = 9;
         // 
         // nmUpDwnLebar
         // 
         this.nmUpDwnLebar.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.nmUpDwnLebar.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.nmUpDwnLebar.Location = new System.Drawing.Point(148, 5);
         this.nmUpDwnLebar.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
         this.nmUpDwnLebar.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.nmUpDwnLebar.Name = "nmUpDwnLebar";
         this.nmUpDwnLebar.Size = new System.Drawing.Size(56, 20);
         this.nmUpDwnLebar.TabIndex = 0;
         this.nmUpDwnLebar.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 8);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(139, 13);
         this.label3.TabIndex = 1;
         this.label3.Text = "Lebar (Banyaknya Karakter)";
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Transparent;
         this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(3, 171);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(42, 19);
         this.label4.TabIndex = 6;
         this.label4.Text = "Data";
         // 
         // rtBoxHeader
         // 
         this.rtBoxHeader.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.tableLayoutPanel1.SetColumnSpan(this.rtBoxHeader, 2);
         this.rtBoxHeader.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rtBoxHeader.Location = new System.Drawing.Point(3, 63);
         this.rtBoxHeader.Name = "rtBoxHeader";
         this.rtBoxHeader.Size = new System.Drawing.Size(347, 100);
         this.rtBoxHeader.TabIndex = 1;
         this.rtBoxHeader.Text = "";
         this.rtBoxHeader.WordWrap = false;
         this.rtBoxHeader.TextChanged += new System.EventHandler(this.rtBox_TextChanged);
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel2.ColumnCount = 5;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 477F));
         this.tableLayoutPanel2.Controls.Add(this.btnGenerate, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.btnClear, 1, 0);
         this.tableLayoutPanel2.Controls.Add(this.btnCopy, 4, 0);
         this.tableLayoutPanel2.Controls.Add(this.btnExit, 2, 0);
         this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 448);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(848, 42);
         this.tableLayoutPanel2.TabIndex = 10;
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.tableLayoutPanel3.ColumnCount = 2;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
         this.tableLayoutPanel3.Controls.Add(this.rtBoxHasil, 0, 1);
         this.tableLayoutPanel3.Location = new System.Drawing.Point(383, 27);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 2;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel3.Size = new System.Drawing.Size(477, 415);
         this.tableLayoutPanel3.TabIndex = 11;
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(869, 499);
         this.Controls.Add(this.tableLayoutPanel3);
         this.Controls.Add(this.tableLayoutPanel2);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Controls.Add(this.menuStrip1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.MinimumSize = new System.Drawing.Size(885, 537);
         this.Name = "FrmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Generate Comment Author";
         this.Load += new System.EventHandler(this.mainForm_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.nmUpDwnLebar)).EndInit();
         this.tableLayoutPanel2.ResumeLayout(false);
         this.tableLayoutPanel3.ResumeLayout(false);
         this.tableLayoutPanel3.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnGenerate;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnExit;
      private System.Windows.Forms.RichTextBox rtBoxData;
      private System.Windows.Forms.RichTextBox rtBoxHasil;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
      private System.Windows.Forms.Button btnCopy;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.NumericUpDown nmUpDwnLebar;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.RichTextBox rtBoxHeader;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
   }
}

