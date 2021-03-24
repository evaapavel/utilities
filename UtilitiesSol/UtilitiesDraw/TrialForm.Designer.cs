namespace UtilitiesDraw
{
    partial class TrialForm
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelTrial = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.listBoxImageFormat = new System.Windows.Forms.ListBox();
            this.labelImageFormat = new System.Windows.Forms.Label();
            this.panelTrial.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewMessage.Location = new System.Drawing.Point(17, 577);
            this.buttonNewMessage.Name = "buttonNewMessage";
            this.buttonNewMessage.Size = new System.Drawing.Size(168, 48);
            this.buttonNewMessage.TabIndex = 0;
            this.buttonNewMessage.Text = "Nová zpráva";
            this.buttonNewMessage.UseVisualStyleBackColor = false;
            this.buttonNewMessage.Click += new System.EventHandler(this.ButtonNewMessage_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(620, 583);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 41);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Smazat";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMessage.Location = new System.Drawing.Point(34, 41);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(154, 20);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "Žádné nové zprávy...";
            // 
            // panelTrial
            // 
            this.panelTrial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTrial.Controls.Add(this.buttonShow);
            this.panelTrial.Location = new System.Drawing.Point(38, 286);
            this.panelTrial.Name = "panelTrial";
            this.panelTrial.Size = new System.Drawing.Size(729, 250);
            this.panelTrial.TabIndex = 3;
            this.panelTrial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTrial_MouseDown);
            this.panelTrial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTrial_MouseMove);
            this.panelTrial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTrial_MouseUp);
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonShow.Location = new System.Drawing.Point(557, 22);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(148, 59);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Zobrazit";
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(435, 43);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(295, 20);
            this.textBoxFileName.TabIndex = 4;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(435, 24);
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
            this.listBoxImageFormat.Location = new System.Drawing.Point(438, 110);
            this.listBoxImageFormat.Name = "listBoxImageFormat";
            this.listBoxImageFormat.Size = new System.Drawing.Size(120, 95);
            this.listBoxImageFormat.TabIndex = 6;
            // 
            // labelImageFormat
            // 
            this.labelImageFormat.AutoSize = true;
            this.labelImageFormat.Location = new System.Drawing.Point(438, 91);
            this.labelImageFormat.Name = "labelImageFormat";
            this.labelImageFormat.Size = new System.Drawing.Size(148, 13);
            this.labelImageFormat.TabIndex = 7;
            this.labelImageFormat.Text = "Zvolte formát uložení obrázku";
            // 
            // TrialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 673);
            this.Controls.Add(this.labelImageFormat);
            this.Controls.Add(this.listBoxImageFormat);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.panelTrial);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonNewMessage);
            this.Name = "TrialForm";
            this.Text = "TrialForm";
            this.Load += new System.EventHandler(this.TrialForm_Load);
            this.Click += new System.EventHandler(this.TrialForm_Click);
            this.panelTrial.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewMessage;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Panel panelTrial;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.ListBox listBoxImageFormat;
        private System.Windows.Forms.Label labelImageFormat;
    }
}