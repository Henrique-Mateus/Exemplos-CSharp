namespace WebBrawser1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btVoutar = new System.Windows.Forms.Button();
            this.btCotinuar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btir = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btEstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 42);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(463, 214);
            this.webBrowser1.TabIndex = 3;
            // 
            // btVoutar
            // 
            this.btVoutar.Location = new System.Drawing.Point(12, 11);
            this.btVoutar.Name = "btVoutar";
            this.btVoutar.Size = new System.Drawing.Size(27, 23);
            this.btVoutar.TabIndex = 6;
            this.btVoutar.Text = "<<";
            this.btVoutar.UseVisualStyleBackColor = true;
            this.btVoutar.Click += new System.EventHandler(this.btVoutar_Click);
            // 
            // btCotinuar
            // 
            this.btCotinuar.Location = new System.Drawing.Point(45, 11);
            this.btCotinuar.Name = "btCotinuar";
            this.btCotinuar.Size = new System.Drawing.Size(29, 23);
            this.btCotinuar.TabIndex = 7;
            this.btCotinuar.Text = ">>";
            this.btCotinuar.UseVisualStyleBackColor = true;
            this.btCotinuar.Click += new System.EventHandler(this.btCotinuar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(80, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 8;
            // 
            // btir
            // 
            this.btir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btir.Location = new System.Drawing.Point(365, 11);
            this.btir.Name = "btir";
            this.btir.Size = new System.Drawing.Size(28, 23);
            this.btir.TabIndex = 9;
            this.btir.Text = "Ir";
            this.btir.UseVisualStyleBackColor = true;
            this.btir.Click += new System.EventHandler(this.btir_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAtualizar.Location = new System.Drawing.Point(399, 11);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(34, 23);
            this.btAtualizar.TabIndex = 10;
            this.btAtualizar.Text = "AT";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btEstop
            // 
            this.btEstop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEstop.Location = new System.Drawing.Point(439, 11);
            this.btEstop.Name = "btEstop";
            this.btEstop.Size = new System.Drawing.Size(36, 23);
            this.btEstop.TabIndex = 11;
            this.btEstop.Text = "ST";
            this.btEstop.UseVisualStyleBackColor = true;
            this.btEstop.Click += new System.EventHandler(this.btEstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(487, 266);
            this.Controls.Add(this.btEstop);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btCotinuar);
            this.Controls.Add(this.btVoutar);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btVoutar;
        private System.Windows.Forms.Button btCotinuar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btir;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btEstop;
    }
}

