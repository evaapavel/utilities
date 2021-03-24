namespace UtilitiesDraw
{
    partial class TestForm
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
            this.buttonNewMessage = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelTest = new System.Windows.Forms.Panel();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.listBoxImageFormat = new System.Windows.Forms.ListBox();
            this.labelImageFormat = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewMessage.Location = new System.Drawing.Point(29, 639);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(131, 43);
            this.buttonNewMessage.TabIndex = 0;
            this.buttonNewMessage.Text = "New Message";
            this.buttonNewMessage.UseVisualStyleBackColor = false;
            this.buttonNewMessage.Click += new System.EventHandler(this.ButtonNewMessage_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMessage.Location = new System.Drawing.Point(23, 275);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(146, 20);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Zatím žádné zprávy";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(659, 631);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 50);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panelTest
            // 
            this.panelTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTest.Location = new System.Drawing.Point(29, 329);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(725, 274);
            this.panelTest.TabIndex = 3;
            this.panelTest.Click += new System.EventHandler(this.PanelTest_Click);
            this.panelTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTest_MouseDown);
            this.panelTest.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTest_MouseMove);
            this.panelTest.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTest_MouseUp);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(29, 58);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(593, 20);
            this.textBoxFileName.TabIndex = 4;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(29, 42);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(122, 13);
            this.labelFileName.TabIndex = 5;
            this.labelFileName.Text = "Zadejte cestu k souboru";
            // 
            // listBoxImageFormat
            // 
            this.listBoxImageFormat.FormattingEnabled = true;
            this.listBoxImageFormat.Items.AddRange(new object[] {
            "Vektorový formát",
            "Bitmapový formát",
            "Komprimovaný formát"});
            this.listBoxImageFormat.Location = new System.Drawing.Point(27, 127);
            this.listBoxImageFormat.Name = "listBoxImageFormat";
            this.listBoxImageFormat.Size = new System.Drawing.Size(120, 95);
            this.listBoxImageFormat.TabIndex = 6;
            // 
            // labelImageFormat
            // 
            this.labelImageFormat.AutoSize = true;
            this.labelImageFormat.Location = new System.Drawing.Point(29, 108);
            this.labelImageFormat.Name = "labelImageFormat";
            this.labelImageFormat.Size = new System.Drawing.Size(148, 13);
            this.labelImageFormat.TabIndex = 7;
            this.labelImageFormat.Text = "Zvolte formát uložení obrázku";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSaveFile.Location = new System.Drawing.Point(348, 157);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(160, 41);
            this.buttonSaveFile.TabIndex = 8;
            this.buttonSaveFile.Text = "Uložit";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.ButtonSaveFile_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 701);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.labelImageFormat);
            this.Controls.Add(this.listBoxImageFormat);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonNewMessage);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.ListBox listBoxImageFormat;
        private System.Windows.Forms.Label labelImageFormat;
        private System.Windows.Forms.Button buttonSaveFile;
    }
}