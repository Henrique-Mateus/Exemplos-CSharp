using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LugarDeTexts
{
    public partial class add_numero : Form
    {
        int num1;
        int num2;
        int num3;
        public add_numero()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(numero_add.Text == "" || quantas_vezes_add_o_numero.Text == "" || numero_recebe.Text == "")
            {
                
            }
            else
            {
                num1 = Convert.ToInt32(numero_add.Text);
                num2 = Convert.ToInt32(quantas_vezes_add_o_numero.Text);
                num3 = Convert.ToInt32(numero_recebe.Text);

                while(num2 != 0)
                {
                    num3 += num1;
                    num2 -= 1;
                }

                numero_add.Text = "0";
                quantas_vezes_add_o_numero.Text = "0";
                numero_recebe.Text = Convert.ToString(num3);  
            }
        }
    }
}
