using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LugarDeTexts
{
    public partial class TesteBaseDeDados : Form
    {
    
        public TesteBaseDeDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sSql = "select * from PRODUTO";

            SqlCommand comando = new SqlCommand(sSql, conn);





            // comando 

            SqlDataReader objDataReder = comando.ExecuteReader();

            while (objDataReder.Read())
            {

                textBox1.Text = objDataReder["nome"].ToString().Trim();
                textBox2.Text = objDataReder["codProduto"].ToString().Trim();
                textBox3.Text = objDataReder["PrecoVenda"].ToString().Trim();



            }



            conn.Close();


           // textBox1.Text = ("o valor do nome do produto");

        }

        private void TesteBaseDeDados_Load(object sender, EventArgs e)
        {

        }
    }
}
