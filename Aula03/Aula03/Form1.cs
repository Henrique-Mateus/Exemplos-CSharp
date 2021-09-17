using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Aula03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(DateTime.Now);
            textBox2.Text = Convert.ToString(DateTime.Today);
            textBox3.Text = Convert.ToString(DateTime.Now.Hour);
            textBox4.Text = Convert.ToString(DateTime.Now.AddDays(5));

            textBox5.Text = Convert.ToString(DateTime.Now.Subtract(dateTimePicker1.Value));

            int idaade = DateTime.Now.Year - dateTimePicker1.Value.Year;
            if (DateTime.Now.Month < dateTimePicker1.Value.Month)
            {
                idaade = idaade - 1;
            }
            else
            {
                if (DateTime.Now.Month == dateTimePicker1.Value.Month && DateTime.Now.Day < dateTimePicker1.Value.Day)
                {
                    idaade = idaade - 1;
                }
            }
            textBox6.Text = Convert.ToString(idaade);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            int qtd = textBox7.Text.Length;
            for (int i = qtd - 1; i != -1; i-- )
            {
                textBox8.Text += textBox7.Text.Substring(i, 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int qtd2 = textBox9.Text.Length;
            textBox10.Text = textBox9.Text.Substring(qtd2 - 3, 3);
        }
    }
}