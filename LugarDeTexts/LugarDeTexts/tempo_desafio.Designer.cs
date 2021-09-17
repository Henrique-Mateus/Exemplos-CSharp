namespace LugarDeTexts
{
    partial class tempo_desafio
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTempo1 = new System.Windows.Forms.Label();
            this.LblTempo2 = new System.Windows.Forms.Label();
            this.btnDescanso = new System.Windows.Forms.Button();
            this.BtnPara = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.CmbHora = new System.Windows.Forms.ComboBox();
            this.CmbMinuto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlay.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(178, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(146, 37);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Começa";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.Play_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTempo1
            // 
            this.LblTempo1.AutoSize = true;
            this.LblTempo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo1.Location = new System.Drawing.Point(1, 41);
            this.LblTempo1.Name = "LblTempo1";
            this.LblTempo1.Size = new System.Drawing.Size(82, 55);
            this.LblTempo1.TabIndex = 8;
            this.LblTempo1.Text = "00";
            // 
            // LblTempo2
            // 
            this.LblTempo2.AutoSize = true;
            this.LblTempo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo2.Location = new System.Drawing.Point(91, 41);
            this.LblTempo2.Name = "LblTempo2";
            this.LblTempo2.Size = new System.Drawing.Size(82, 55);
            this.LblTempo2.TabIndex = 9;
            this.LblTempo2.Text = "00";
            // 
            // btnDescanso
            // 
            this.btnDescanso.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDescanso.Enabled = false;
            this.btnDescanso.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescanso.Location = new System.Drawing.Point(178, 41);
            this.btnDescanso.Name = "btnDescanso";
            this.btnDescanso.Size = new System.Drawing.Size(146, 37);
            this.btnDescanso.TabIndex = 10;
            this.btnDescanso.Text = "Descanso";
            this.btnDescanso.UseVisualStyleBackColor = false;
            this.btnDescanso.Click += new System.EventHandler(this.btnDescanso_Click);
            // 
            // BtnPara
            // 
            this.BtnPara.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnPara.Enabled = false;
            this.BtnPara.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPara.Location = new System.Drawing.Point(178, 79);
            this.BtnPara.Name = "BtnPara";
            this.BtnPara.Size = new System.Drawing.Size(146, 37);
            this.BtnPara.TabIndex = 11;
            this.BtnPara.Text = "Para";
            this.BtnPara.UseVisualStyleBackColor = false;
            this.BtnPara.Click += new System.EventHandler(this.BtnPara_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = ":";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CmbHora
            // 
            this.CmbHora.FormattingEnabled = true;
            this.CmbHora.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CmbHora.Location = new System.Drawing.Point(11, 95);
            this.CmbHora.Name = "CmbHora";
            this.CmbHora.Size = new System.Drawing.Size(72, 21);
            this.CmbHora.TabIndex = 15;
            this.CmbHora.Text = "00";
            this.CmbHora.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CmbMinuto
            // 
            this.CmbMinuto.FormattingEnabled = true;
            this.CmbMinuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.CmbMinuto.Location = new System.Drawing.Point(99, 94);
            this.CmbMinuto.Name = "CmbMinuto";
            this.CmbMinuto.Size = new System.Drawing.Size(72, 21);
            this.CmbMinuto.TabIndex = 16;
            this.CmbMinuto.Text = "01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-21, -14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 55);
            this.label2.TabIndex = 17;
            this.label2.Text = "ALARME";
            // 
            // tempo_desafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(329, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbMinuto);
            this.Controls.Add(this.CmbHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPara);
            this.Controls.Add(this.btnDescanso);
            this.Controls.Add(this.LblTempo2);
            this.Controls.Add(this.LblTempo1);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tempo_desafio";
            this.RightToLeftLayout = true;
            this.Text = "tempo_desafio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.tempo_desafio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTempo1;
        private System.Windows.Forms.Label LblTempo2;
        private System.Windows.Forms.Button btnDescanso;
        private System.Windows.Forms.Button BtnPara;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbHora;
        private System.Windows.Forms.ComboBox CmbMinuto;
        private System.Windows.Forms.Label label2;
    }
}