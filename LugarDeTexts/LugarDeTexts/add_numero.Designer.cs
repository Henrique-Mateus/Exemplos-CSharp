namespace LugarDeTexts
{
    partial class add_numero
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
            this.Add = new System.Windows.Forms.Button();
            this.numero_add = new System.Windows.Forms.TextBox();
            this.numero_recebe = new System.Windows.Forms.TextBox();
            this.quantas_vezes_add_o_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(68, 89);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(100, 32);
            this.Add.TabIndex = 0;
            this.Add.Text = "Adiciona";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // numero_add
            // 
            this.numero_add.Location = new System.Drawing.Point(68, 11);
            this.numero_add.Name = "numero_add";
            this.numero_add.Size = new System.Drawing.Size(100, 20);
            this.numero_add.TabIndex = 1;
            // 
            // numero_recebe
            // 
            this.numero_recebe.Location = new System.Drawing.Point(68, 63);
            this.numero_recebe.Name = "numero_recebe";
            this.numero_recebe.Size = new System.Drawing.Size(100, 20);
            this.numero_recebe.TabIndex = 2;
            // 
            // quantas_vezes_add_o_numero
            // 
            this.quantas_vezes_add_o_numero.Location = new System.Drawing.Point(68, 37);
            this.quantas_vezes_add_o_numero.Name = "quantas_vezes_add_o_numero";
            this.quantas_vezes_add_o_numero.Size = new System.Drawing.Size(100, 20);
            this.quantas_vezes_add_o_numero.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "add:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "vezes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "total:";
            // add_numero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 133);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantas_vezes_add_o_numero);
            this.Controls.Add(this.numero_recebe);
            this.Controls.Add(this.numero_add);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "add_numero";
            this.Text = "add_numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox numero_add;
        private System.Windows.Forms.TextBox numero_recebe;
        private System.Windows.Forms.TextBox quantas_vezes_add_o_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}