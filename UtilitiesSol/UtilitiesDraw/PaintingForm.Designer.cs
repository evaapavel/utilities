﻿namespace UtilitiesDraw
{
    partial class PaintingForm
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
            this.panelPainting = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPainting
            // 
            this.panelPainting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPainting.BackColor = System.Drawing.Color.White;
            this.panelPainting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPainting.Location = new System.Drawing.Point(13, 13);
            this.panelPainting.Name = "panelPainting";
            this.panelPainting.Size = new System.Drawing.Size(775, 333);
            this.panelPainting.TabIndex = 0;
            this.panelPainting.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPainting_Paint);
            this.panelPainting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelPainting_MouseDown);
            this.panelPainting.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelPainting_MouseMove);
            this.panelPainting.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelPainting_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelPainting);
            this.Name = "PaintingForm";
            this.Text = "PaintingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPainting;
        private System.Windows.Forms.Button button1;
    }
}