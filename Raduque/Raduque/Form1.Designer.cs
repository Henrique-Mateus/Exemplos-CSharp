namespace Raduque
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pt2 = new System.Windows.Forms.PictureBox();
            this.pt1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(252, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(581, 119);
            this.button1.TabIndex = 16;
            this.button1.Text = "Raduquem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "RADUQUEM!!!!!!!!!";
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(410, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 51);
            this.button2.TabIndex = 20;
            this.button2.Text = "Mais um raduquem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pt2
            // 
            this.pt2.Image = global::Raduque.Properties.Resources.Raduquem1_Stritifait;
            this.pt2.Location = new System.Drawing.Point(181, 361);
            this.pt2.Name = "pt2";
            this.pt2.Size = new System.Drawing.Size(74, 62);
            this.pt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt2.TabIndex = 1;
            this.pt2.TabStop = false;
            this.pt2.Click += new System.EventHandler(this.pt2_Click);
            // 
            // pt1
            // 
            this.pt1.Image = global::Raduque.Properties.Resources.Raduquem1_Stritifait;
            this.pt1.Location = new System.Drawing.Point(191, 612);
            this.pt1.Name = "pt1";
            this.pt1.Size = new System.Drawing.Size(74, 62);
            this.pt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pt1.TabIndex = 0;
            this.pt1.TabStop = false;
            this.pt1.Visible = false;
            this.pt1.Click += new System.EventHandler(this.pt1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Raduque.Properties.Resources.Riu1_estritifait;
            this.pictureBox7.Location = new System.Drawing.Point(-1, 348);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(176, 196);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pt2);
            this.Controls.Add(this.pt1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pt1;
        private System.Windows.Forms.PictureBox pt2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

