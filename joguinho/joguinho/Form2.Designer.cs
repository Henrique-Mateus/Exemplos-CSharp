namespace joguinho
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogo_da_velha = new System.Windows.Forms.Button();
            this.btnJogo_Aleatorio = new System.Windows.Forms.Button();
            this.btnJogo_da_Memoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnJogo_da_velha
            // 
            this.btnJogo_da_velha.Location = new System.Drawing.Point(3, 33);
            this.btnJogo_da_velha.Name = "btnJogo_da_velha";
            this.btnJogo_da_velha.Size = new System.Drawing.Size(89, 23);
            this.btnJogo_da_velha.TabIndex = 1;
            this.btnJogo_da_velha.Text = "jogo da velha";
            this.btnJogo_da_velha.UseVisualStyleBackColor = true;
            this.btnJogo_da_velha.Click += new System.EventHandler(this.btnJogo_da_velha_Click);
            // 
            // btnJogo_Aleatorio
            // 
            this.btnJogo_Aleatorio.Location = new System.Drawing.Point(278, 0);
            this.btnJogo_Aleatorio.Name = "btnJogo_Aleatorio";
            this.btnJogo_Aleatorio.Size = new System.Drawing.Size(89, 23);
            this.btnJogo_Aleatorio.TabIndex = 2;
            this.btnJogo_Aleatorio.Text = "Jogo Aleatorio";
            this.btnJogo_Aleatorio.UseVisualStyleBackColor = true;
            this.btnJogo_Aleatorio.Click += new System.EventHandler(this.btnJogo_Aleatorio_Click);
            // 
            // btnJogo_da_Memoria
            // 
            this.btnJogo_da_Memoria.Location = new System.Drawing.Point(98, 33);
            this.btnJogo_da_Memoria.Name = "btnJogo_da_Memoria";
            this.btnJogo_da_Memoria.Size = new System.Drawing.Size(103, 23);
            this.btnJogo_da_Memoria.TabIndex = 3;
            this.btnJogo_da_Memoria.Text = "jogo da memoria";
            this.btnJogo_da_Memoria.UseVisualStyleBackColor = true;
            this.btnJogo_da_Memoria.Click += new System.EventHandler(this.btnJogo_da_Memoria_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 500);
            this.Controls.Add(this.btnJogo_da_Memoria);
            this.Controls.Add(this.btnJogo_Aleatorio);
            this.Controls.Add(this.btnJogo_da_velha);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogo_da_velha;
        private System.Windows.Forms.Button btnJogo_Aleatorio;
        private System.Windows.Forms.Button btnJogo_da_Memoria;

    }
}