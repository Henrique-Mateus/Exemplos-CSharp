﻿namespace socket2
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMenssagem = new System.Windows.Forms.TextBox();
            this.rtbConversa = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMenssagem);
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 50);
            this.panel1.TabIndex = 0;
            // 
            // txbMenssagem
            // 
            this.txbMenssagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMenssagem.Location = new System.Drawing.Point(5, 11);
            this.txbMenssagem.Name = "txbMenssagem";
            this.txbMenssagem.Size = new System.Drawing.Size(345, 31);
            this.txbMenssagem.TabIndex = 0;
            this.txbMenssagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbMenssagem_KeyDown);
            this.txbMenssagem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbMenssagem_KeyUp);
            // 
            // rtbConversa
            // 
            this.rtbConversa.Enabled = false;
            this.rtbConversa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConversa.Location = new System.Drawing.Point(0, 2);
            this.rtbConversa.Name = "rtbConversa";
            this.rtbConversa.Size = new System.Drawing.Size(352, 269);
            this.rtbConversa.TabIndex = 1;
            this.rtbConversa.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 323);
            this.Controls.Add(this.rtbConversa);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMenssagem;
        private System.Windows.Forms.RichTextBox rtbConversa;
    }
}

