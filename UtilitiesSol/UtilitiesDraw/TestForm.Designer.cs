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
            this.SuspendLayout();
            // 
            // buttonNewMessage
            // 
            this.buttonNewMessage.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonNewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonNewMessage.Location = new System.Drawing.Point(28, 397);
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
            this.labelMessage.Location = new System.Drawing.Point(22, 33);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(146, 20);
            this.labelMessage.TabIndex = 1;
            this.labelMessage.Text = "Zatím žádné zprávy";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(658, 389);
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
            this.panelTest.Location = new System.Drawing.Point(28, 87);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(725, 274);
            this.panelTest.TabIndex = 3;
            this.panelTest.Click += new System.EventHandler(this.PanelTest_Click);
            this.panelTest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTest_MouseDown);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}