namespace WindowsFormsApplication4
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
            this.CmbMinuto = new System.Windows.Forms.ComboBox();
            this.CmbHora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPara = new System.Windows.Forms.Button();
            this.LblTempo2 = new System.Windows.Forms.Label();
            this.LblTempo1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblTempo3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbSegundo = new System.Windows.Forms.ComboBox();
            this.BtnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.CmbMinuto.Location = new System.Drawing.Point(89, 91);
            this.CmbMinuto.Name = "CmbMinuto";
            this.CmbMinuto.Size = new System.Drawing.Size(72, 21);
            this.CmbMinuto.TabIndex = 25;
            this.CmbMinuto.Text = "00";
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
            this.CmbHora.Location = new System.Drawing.Point(0, 91);
            this.CmbHora.Name = "CmbHora";
            this.CmbHora.Size = new System.Drawing.Size(72, 21);
            this.CmbHora.TabIndex = 24;
            this.CmbHora.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 55);
            this.label1.TabIndex = 23;
            this.label1.Text = ":";
            // 
            // BtnPara
            // 
            this.BtnPara.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnPara.Enabled = false;
            this.BtnPara.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPara.Location = new System.Drawing.Point(75, -2);
            this.BtnPara.Name = "BtnPara";
            this.BtnPara.Size = new System.Drawing.Size(84, 37);
            this.BtnPara.TabIndex = 22;
            this.BtnPara.Text = "Stop";
            this.BtnPara.UseVisualStyleBackColor = false;
            this.BtnPara.Click += new System.EventHandler(this.BtnPara_Click);
            // 
            // LblTempo2
            // 
            this.LblTempo2.AutoSize = true;
            this.LblTempo2.BackColor = System.Drawing.Color.Transparent;
            this.LblTempo2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo2.Location = new System.Drawing.Point(86, 37);
            this.LblTempo2.Name = "LblTempo2";
            this.LblTempo2.Size = new System.Drawing.Size(82, 55);
            this.LblTempo2.TabIndex = 20;
            this.LblTempo2.Text = "00";
            // 
            // LblTempo1
            // 
            this.LblTempo1.AutoSize = true;
            this.LblTempo1.BackColor = System.Drawing.Color.Transparent;
            this.LblTempo1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo1.Location = new System.Drawing.Point(-5, 37);
            this.LblTempo1.Name = "LblTempo1";
            this.LblTempo1.Size = new System.Drawing.Size(82, 55);
            this.LblTempo1.TabIndex = 19;
            this.LblTempo1.Text = "00";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPlay.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(-1, -2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(81, 37);
            this.btnPlay.TabIndex = 18;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblTempo3
            // 
            this.LblTempo3.AutoSize = true;
            this.LblTempo3.BackColor = System.Drawing.Color.Transparent;
            this.LblTempo3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempo3.Location = new System.Drawing.Point(176, 38);
            this.LblTempo3.Name = "LblTempo3";
            this.LblTempo3.Size = new System.Drawing.Size(82, 55);
            this.LblTempo3.TabIndex = 28;
            this.LblTempo3.Text = "00";
            this.LblTempo3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 55);
            this.label3.TabIndex = 29;
            this.label3.Text = ":";
            // 
            // CmbSegundo
            // 
            this.CmbSegundo.FormattingEnabled = true;
            this.CmbSegundo.Items.AddRange(new object[] {
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
            this.CmbSegundo.Location = new System.Drawing.Point(177, 91);
            this.CmbSegundo.Name = "CmbSegundo";
            this.CmbSegundo.Size = new System.Drawing.Size(72, 21);
            this.CmbSegundo.TabIndex = 30;
            this.CmbSegundo.Text = "01";
            // 
            // BtnContinue
            // 
            this.BtnContinue.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnContinue.Enabled = false;
            this.BtnContinue.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.Location = new System.Drawing.Point(155, -2);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(96, 37);
            this.BtnContinue.TabIndex = 31;
            this.BtnContinue.Text = "Keep";
            this.BtnContinue.UseVisualStyleBackColor = false;
            this.BtnContinue.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::WindowsFormsApplication4.Properties.Resources.anpulheta;
            this.ClientSize = new System.Drawing.Size(250, 112);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.CmbSegundo);
            this.Controls.Add(this.LblTempo3);
            this.Controls.Add(this.CmbMinuto);
            this.Controls.Add(this.CmbHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPara);
            this.Controls.Add(this.LblTempo2);
            this.Controls.Add(this.LblTempo1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbMinuto;
        private System.Windows.Forms.ComboBox CmbHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPara;
        private System.Windows.Forms.Label LblTempo2;
        private System.Windows.Forms.Label LblTempo1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblTempo3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbSegundo;
        private System.Windows.Forms.Button BtnContinue;
    }
}

