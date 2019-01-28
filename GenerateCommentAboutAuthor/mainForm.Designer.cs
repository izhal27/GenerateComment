namespace GenerateCommentAboutAuthor
{
   partial class mainForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
         this.btnGenerate = new System.Windows.Forms.Button();
         this.btnClear = new System.Windows.Forms.Button();
         this.tblExit = new System.Windows.Forms.Button();
         this.rtBoxSumber = new System.Windows.Forms.RichTextBox();
         this.rtBoxHasil = new System.Windows.Forms.RichTextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.muatSumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveSumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
         this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
         this.btnCopy = new System.Windows.Forms.Button();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tblGenerate
         // 
         this.btnGenerate.Location = new System.Drawing.Point(12, 264);
         this.btnGenerate.Name = "tblGenerate";
         this.btnGenerate.Size = new System.Drawing.Size(75, 35);
         this.btnGenerate.TabIndex = 1;
         this.btnGenerate.Text = "&Generate";
         this.btnGenerate.UseVisualStyleBackColor = true;
         this.btnGenerate.Click += new System.EventHandler(this.tblGenerate_Click);
         // 
         // tblClear
         // 
         this.btnClear.Location = new System.Drawing.Point(93, 264);
         this.btnClear.Name = "tblClear";
         this.btnClear.Size = new System.Drawing.Size(75, 35);
         this.btnClear.TabIndex = 3;
         this.btnClear.Text = "&Clear";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.tblClear_Click);
         // 
         // tblExit
         // 
         this.tblExit.Location = new System.Drawing.Point(174, 264);
         this.tblExit.Name = "tblExit";
         this.tblExit.Size = new System.Drawing.Size(75, 35);
         this.tblExit.TabIndex = 4;
         this.tblExit.Text = "&Exit";
         this.tblExit.UseVisualStyleBackColor = true;
         this.tblExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // rchSumber
         // 
         this.rtBoxSumber.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rtBoxSumber.Location = new System.Drawing.Point(12, 58);
         this.rtBoxSumber.Name = "rchSumber";
         this.rtBoxSumber.Size = new System.Drawing.Size(460, 200);
         this.rtBoxSumber.TabIndex = 0;
         this.rtBoxSumber.Text = "";
         this.rtBoxSumber.WordWrap = false;
         this.rtBoxSumber.TextChanged += new System.EventHandler(this.rchSumber_TextChanged);
         // 
         // rchHasil
         // 
         this.rtBoxHasil.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.rtBoxHasil.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.rtBoxHasil.Location = new System.Drawing.Point(12, 336);
         this.rtBoxHasil.Name = "rchHasil";
         this.rtBoxHasil.ReadOnly = true;
         this.rtBoxHasil.Size = new System.Drawing.Size(460, 200);
         this.rtBoxHasil.TabIndex = 5;
         this.rtBoxHasil.TabStop = false;
         this.rtBoxHasil.Text = "";
         this.rtBoxHasil.WordWrap = false;
         this.rtBoxHasil.TextChanged += new System.EventHandler(this.rtBoxHasil_TextChanged);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BackColor = System.Drawing.Color.Transparent;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(9, 36);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(60, 19);
         this.label1.TabIndex = 6;
         this.label1.Text = "Sumber";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BackColor = System.Drawing.Color.Transparent;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(12, 314);
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
         this.menuStrip1.Size = new System.Drawing.Size(484, 24);
         this.menuStrip1.TabIndex = 8;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muatSumberToolStripMenuItem,
            this.saveSumberToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // muatSumberToolStripMenuItem
         // 
         this.muatSumberToolStripMenuItem.Name = "muatSumberToolStripMenuItem";
         this.muatSumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.muatSumberToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
         this.muatSumberToolStripMenuItem.Text = "&Muat Sumber";
         this.muatSumberToolStripMenuItem.Click += new System.EventHandler(this.muatSumberToolStripMenuItem_Click);
         // 
         // saveSumberToolStripMenuItem
         // 
         this.saveSumberToolStripMenuItem.Name = "saveSumberToolStripMenuItem";
         this.saveSumberToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveSumberToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
         this.saveSumberToolStripMenuItem.Text = "&Simpan Sumber";
         this.saveSumberToolStripMenuItem.Click += new System.EventHandler(this.saveSumberToolStripMenuItem_Click);
         // 
         // toolStripMenuItem2
         // 
         this.toolStripMenuItem2.Name = "toolStripMenuItem2";
         this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 22);
         this.toolStripMenuItem2.Text = "----------------------";
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
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
         // saveFileDialog
         // 
         this.saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
         // 
         // openFileDialog
         // 
         this.openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
         // 
         // tblCopy
         // 
         this.btnCopy.Enabled = false;
         this.btnCopy.Location = new System.Drawing.Point(12, 542);
         this.btnCopy.Name = "tblCopy";
         this.btnCopy.Size = new System.Drawing.Size(75, 35);
         this.btnCopy.TabIndex = 2;
         this.btnCopy.Text = "Co&py";
         this.btnCopy.UseVisualStyleBackColor = true;
         this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
         // 
         // mainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 583);
         this.Controls.Add(this.btnCopy);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.rtBoxHasil);
         this.Controls.Add(this.rtBoxSumber);
         this.Controls.Add(this.tblExit);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.btnGenerate);
         this.Controls.Add(this.menuStrip1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.Name = "mainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Generate Comment Author";
         this.Load += new System.EventHandler(this.mainForm_Load);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnGenerate;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button tblExit;
      private System.Windows.Forms.RichTextBox rtBoxSumber;
      private System.Windows.Forms.RichTextBox rtBoxHasil;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveSumberToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
      private System.Windows.Forms.SaveFileDialog saveFileDialog;
      private System.Windows.Forms.OpenFileDialog openFileDialog;
      private System.Windows.Forms.ToolStripMenuItem muatSumberToolStripMenuItem;
      private System.Windows.Forms.Button btnCopy;

   }
}

