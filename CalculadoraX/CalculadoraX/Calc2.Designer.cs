namespace CalculadoraX
{
    partial class Calc2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Mais = new System.Windows.Forms.PictureBox();
            this.Menos = new System.Windows.Forms.PictureBox();
            this.Vezis = new System.Windows.Forms.PictureBox();
            this.Divide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vezis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divide)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite um númeral";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aguardando valores...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CalculadoraX.Properties.Resources.igual;
            this.pictureBox2.Location = new System.Drawing.Point(147, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadoraX.Properties.Resources.caselar;
            this.pictureBox1.Location = new System.Drawing.Point(111, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Mais
            // 
            this.Mais.Image = global::CalculadoraX.Properties.Resources.mais;
            this.Mais.Location = new System.Drawing.Point(147, 14);
            this.Mais.Name = "Mais";
            this.Mais.Size = new System.Drawing.Size(30, 30);
            this.Mais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mais.TabIndex = 14;
            this.Mais.TabStop = false;
            this.Mais.Click += new System.EventHandler(this.Mais_Click);
            // 
            // Menos
            // 
            this.Menos.Image = global::CalculadoraX.Properties.Resources.menos;
            this.Menos.Location = new System.Drawing.Point(147, 50);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(30, 30);
            this.Menos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menos.TabIndex = 13;
            this.Menos.TabStop = false;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // Vezis
            // 
            this.Vezis.Image = global::CalculadoraX.Properties.Resources.vezis;
            this.Vezis.Location = new System.Drawing.Point(147, 86);
            this.Vezis.Name = "Vezis";
            this.Vezis.Size = new System.Drawing.Size(30, 30);
            this.Vezis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vezis.TabIndex = 12;
            this.Vezis.TabStop = false;
            this.Vezis.Click += new System.EventHandler(this.Vezis_Click);
            // 
            // Divide
            // 
            this.Divide.Image = global::CalculadoraX.Properties.Resources.divide;
            this.Divide.Location = new System.Drawing.Point(147, 122);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(30, 30);
            this.Divide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Divide.TabIndex = 11;
            this.Divide.TabStop = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Calc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 200);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Mais);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Vezis);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Calc2";
            this.Text = "Calc2";
            this.Load += new System.EventHandler(this.Calc2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vezis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Divide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Divide;
        private System.Windows.Forms.PictureBox Vezis;
        private System.Windows.Forms.PictureBox Menos;
        private System.Windows.Forms.PictureBox Mais;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}