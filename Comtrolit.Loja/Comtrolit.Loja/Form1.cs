using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Data.SqlClient;

namespace Comtrolit.Loja
{
    public partial class Form1 : Form
    {
        string[] aCodProduto = new string[100];
        string[] aNomeProduto = new string[100];
        decimal[] aPrecoProduto = new decimal[100];
        string[] aLocalizacao = new string[100];
        string[] aFornecedor = new string[100];
        DateTime[] aDataUltCompra = new DateTime[100];
        decimal[] aVlrUltCompra = new decimal[100];
        string modo;

     
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------Metódos
        private void vc()
        {
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void vb()
        {
            button1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void desabilita()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            dateTimePicker1.Enabled = false;
            textBox6.ReadOnly = true;
        }

        private void habilita()
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            dateTimePicker1.Enabled = true;
            textBox6.ReadOnly = false;
        }

        private void atualiza()
        {
            int linhadgv = dgvProdutos.CurrentRow.Index + 1;
            label9.Text = Convert.ToString(linhadgv);

            textBox1.Text = aCodProduto[linhadgv].Trim();
            textBox2.Text = aNomeProduto[linhadgv].Trim();
            textBox3.Text = Convert.ToString(aPrecoProduto[linhadgv]).Trim();
            textBox4.Text = aLocalizacao[linhadgv].Trim();
            textBox5.Text = aFornecedor[linhadgv].Trim();
            dateTimePicker1.Value = aDataUltCompra[linhadgv];
            textBox6.Text = Convert.ToString(aVlrUltCompra[linhadgv]).Trim();
        }

        private void gravaArqSeq()
        {
            //System.IO.StreamWriter vgravador = new System.IO.StreamWriter("c:/temp/Produto.txt");

            //for (int da = 1; da <= aCodProduto.Length - 1; da++)
            //{
            //    if (aCodProduto[da] != null)
            //    {
            //        string linhaDados = "";
            //        linhaDados += aCodProduto[da];
            //        linhaDados += aNomeProduto[da];
            //        linhaDados += String.Format("              {0}", Convert.ToString(aPrecoProduto[da])).Substring(Convert.ToString(aPrecoProduto[da]).Length, 14);
            //        linhaDados += aLocalizacao[da];
            //        linhaDados += aFornecedor[da];
            //        linhaDados += Convert.ToString(aDataUltCompra[da]).Substring(0, 10);
            //        linhaDados += String.Format("              {0}", Convert.ToString(aVlrUltCompra[da])).Substring(Convert.ToString(aVlrUltCompra[da]).Length, 14);
            //        vgravador.WriteLine(linhaDados);
            //    }
            //}
            //vgravador.Close();
        }

        private void Critica()
        {
            //if (Convert.ToDecimal(textBox3.Text) < Convert.ToDecimal(textBox6.Text))
            //{
            //    MessageBox.Show("Valor de Venda não pode ser menor que Valor de Compra!");
            //    teveErro = true;
            //}
        }

        private void atualizaGrid()
        {
            dgvProdutos.Rows.Clear();

            for (int c = 1; c <= aCodProduto.Length - 1; c++)
            {
                if (aCodProduto[c] != null)
                {
                    dgvProdutos.Rows.Add(aCodProduto[c], aNomeProduto[c], aFornecedor[c]);
                }
            }
        }
        //-----------------------------------------Obijetos
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gravaArqSeq();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            BuscarDados();
            
            //StreamReader vLeitor = new StreamReader("c:/temp/Produto.txt");

            //int i = 0;
            //while (!vLeitor.EndOfStream)
            //{
            //    string registro = vLeitor.ReadLine();
            //    i++;
            //    aCodProduto[i] = registro.Substring(0, 10);
            //    aNomeProduto[i] = registro.Substring(10, 20);
            //    aPrecoProduto[i] = Convert.ToDecimal(registro.Substring(30, 14));
            //    aLocalizacao[i] = registro.Substring(44, 10);
            //    aFornecedor[i] = registro.Substring(54, 15);
            //    aDataUltCompra[i] = Convert.ToDateTime(registro.Substring(69, 10));
            //    aVlrUltCompra[i] = Convert.ToDecimal(registro.Substring(79, 14));

            //    dgvProdutos.Rows.Add(aCodProduto[i], aNomeProduto[i], aFornecedor[i]);

            //    //System.Media.SoundPlayer p = new System.Media.SoundPlayer();
            //    //p.SoundLocation = @"D:\Musica\lvl-up.wav";
            //    //p.Play();
            //}
            //vLeitor.Close();
            //desabilita();
            //vb();
            //modo = "";
            //toolStripStatusLabel1.Text = "Pronto de Utilização";

           

        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            vb();
            atualiza();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vc();
            habilita();
            modo = "A";
            toolStripStatusLabel1.Text = "Modo de Atualização";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vc();
            modo = "I";
            toolStripStatusLabel1.Text = "Modo de Inclusão";
            habilita();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = System.DateTime.Now;
            textBox6.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vb();
            desabilita();
            atualiza();
            modo = "";
            toolStripStatusLabel1.Text = "Pronto de Utilização";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delit();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

                // pega o codProduto

                // selecionar na base 

                // se vier dados eu vou comparar com os outros dados que estao na tela 

                // e se tiver diferença eu atualizo com o comando " update produtos set nome = textbox2.tex where codproduto = textbox1 "

                // sSlq = ""

                // mas se não retornou dados da base 

               if (textBox1.Text == "") 
               {
                textBox1.Text = "0";
               } 

                int u = 0;
                string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                string sSql = "SELECT * FROM PRODUTO WHERE CODPRODUTO = " + textBox1.Text; 
                SqlCommand comando = new SqlCommand(sSql, conn);
                SqlDataReader objDataReder = comando.ExecuteReader();


                if (objDataReder.HasRows) // retornou dados do select 
                {
                    AtualizarRegistro();
                }
                else
                {
                    InserirRegistro();
                      
                }
              


                //vb();
                //desabilita();
                //modo = "";
                //conn.Close();
                //toolStripStatusLabel1.Text = "Pronto de Utilização";
            }
            //----------------------------------MODO INCLUSÃO
            //if (modo == "I")
            //{

            //    string sSql;
            //    //int linhadgv = dgvProdutos.Rows.Count + 1;
            //    //aCodProduto[linhadgv] = string.Format("{0}          ", textBox1.Text).Substring(0, 10);
            //    //aNomeProduto[linhadgv] = string.Format("{0}                    ", textBox2.Text).Substring(0, 20);
            //    //aPrecoProduto[linhadgv] = Convert.ToDecimal(textBox3.Text);
            //    //aLocalizacao[linhadgv] = string.Format("{0}          ", textBox4.Text).Substring(0, 10);
            //    //aFornecedor[linhadgv] = string.Format("{0}               ", textBox5.Text).Substring(0, 15);
            //    //aDataUltCompra[linhadgv] = Convert.ToDateTime(dateTimePicker1.Text);
            //    //aVlrUltCompra[linhadgv] = Convert.ToDecimal(textBox6.Text);
            //    //modo = "";
            //    //toolStripStatusLabel1.Text = String.Format("dados incluidos com sucesso! registro {0}", linhadgv);
            //    //desabilita();
            //    //atualizaGrid();
            //    //dgvProdutos[0, linhadgv - 1].Selected = true;

            //    int u = 0;
            //    string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            //    SqlConnection conn = new SqlConnection(strConn);
            //    conn.Open();

            //    decimal num = Convert.ToDecimal(textBox6.Text);




            //    sSql = "";
            //    sSql = sSql + " INSERT INTO PRODUTO ";
            //    sSql = sSql + " VALUES ('" + textBox2.Text + "','";
            //    sSql = sSql + textBox4.Text + "','";
            //    sSql = sSql + textBox5.Text + "',";
            //    sSql = sSql + textBox6.Text.Replace(",", ".") + ",";
            //    sSql = sSql + textBox3.Text.Replace(",", ".") + ",'";
            //    sSql = sSql + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";


                    
                    
            //        // "insert into PRODUTO values ('feijao', 'cidade', 'matheus', 22000.01,  1524.45, '2020-07-29' )";






            //    SqlCommand comando = new SqlCommand(sSql, conn);





            //    // comando 



            //    conn.Close();

            //}
            //-----------------------------------MODO EXCLUSÃO
            //if (modo == "E")
            //{
            //    int u = 0;
            //    string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            //    SqlConnection conn = new SqlConnection(strConn);
            //    conn.Open();

            //    string sSql = "delete from PRODUTO where {0}";

            //    SqlCommand comando = new SqlCommand(sSql, conn);





            //    // comando 

            //    SqlDataReader objDataReder = comando.ExecuteReader();

            //    while (objDataReder.Read())
            //    {

            //    u++;
            //    cod.Text = objDataReder["codProduto"].ToString().Trim();
            //    nom.Text = objDataReder["Nome"].ToString().Trim();
            //    preco.Text = objDataReder["PrecoVenda"].ToString().Trim();
            //    localiza.Text = objDataReder["Localizacao"].ToString().Trim();
            //    fornec.Text = objDataReder["Fornecedor"].ToString().Trim();
            //    datultcompre.Text = objDataReder["DatUltCompra"].ToString().Trim();
            //    valodcompre.Text = objDataReder["ValorCompra"].ToString().Trim();
            //}


            //desabilita();
            //modo = "";
            //conn.Close();
            //toolStripStatusLabel1.Text = String.Format("Registro excluido com sucesso!");
            //} 

        private void InserirRegistro() {

          
            string sSql;
            string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();


            sSql = "";
            sSql = sSql + " INSERT INTO PRODUTO ";
            sSql = sSql + " VALUES ('" + textBox2.Text + "','";
            sSql = sSql + textBox4.Text + "','";
            sSql = sSql + textBox5.Text + "',";
            sSql = sSql + textBox6.Text.Replace(",", ".") + ",";
            sSql = sSql + textBox3.Text.Replace(",", ".") + ",'";
            sSql = sSql + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')";

            SqlCommand comando = new SqlCommand(sSql, conn);
            comando.ExecuteNonQuery();

            BuscarDados();


        }
        private void BuscarDados() {

            int u = 0;
            string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string sSql = "select * from PRODUTO ";

            SqlCommand comando = new SqlCommand(sSql, conn);

            SqlDataReader objDataReder = comando.ExecuteReader();

            dgvProdutos.Rows.Clear();


            if (objDataReder.HasRows) // retornou dados do select 
            {
                while (objDataReder.Read()) // percorre as linhas de retorno do select 
                {
                    u++;
                   
                    cod.Text = objDataReder["codProduto"].ToString().Trim();
                    nom.Text = objDataReder["Nome"].ToString().Trim();
                    preco.Text = objDataReder["PrecoVenda"].ToString().Trim();
                    localiza.Text = objDataReder["Localizacao"].ToString().Trim();
                    fornec.Text = objDataReder["Fornecedor"].ToString().Trim();
                    datultcompre.Text = objDataReder["DatUltCompra"].ToString().Trim();
                    valodcompre.Text = objDataReder["ValorCompra"].ToString().Trim();

                    aCodProduto[u] = cod.Text;
                    aNomeProduto[u] = nom.Text;
                    aPrecoProduto[u] = Convert.ToDecimal(preco.Text);
                    aLocalizacao[u] = localiza.Text;
                    aFornecedor[u] = fornec.Text;
                    aDataUltCompra[u] = Convert.ToDateTime(datultcompre.Text);
                    aVlrUltCompra[u] = Convert.ToDecimal(valodcompre.Text);

                    dgvProdutos.Rows.Add(aCodProduto[u], aNomeProduto[u], aFornecedor[u]);
                }

            }
            else
            {
                // -- inserir



            }



            vb();
            desabilita();
            modo = "";
            conn.Close();
            toolStripStatusLabel1.Text = "Pronto de Utilização";

        }
        private void AtualizarRegistro() {

            int u = 0;
            string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();


            string sSql;
 

            sSql = "";
            sSql = sSql + " UPDATE PRODUTO ";
            sSql = sSql + " SET ";
            sSql = sSql + " NOME = '" + textBox2.Text + "',";
            sSql = sSql + " PRECOVENDA = " + textBox3.Text.Replace(",", ".") + ",";
            sSql = sSql + " LOCALIZACAO = '" + textBox4.Text + "',";
            sSql = sSql + " FORNECEDOR = '" + textBox5.Text + "',";
            sSql = sSql + " DATULTCOMPRA = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',";
            sSql = sSql + " VALORCOMPRA = " + textBox6.Text.Replace(",", ".") + "";



            sSql = sSql + " WHERE CODPRODUTO = " + textBox1.Text;

            SqlCommand command = new SqlCommand(sSql, conn);
            //command.Connection.Open();
            command.ExecuteNonQuery();


            BuscarDados();
            
        
        
        }

        private void delit()
        {
            string strConn = "Data Source=localhost;Initial Catalog=LojadoHenrique;Integrated Security=true";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();


            string sSql;
 

            sSql = "";
            sSql = sSql + " DELETE FROM PRODUTO";


            sSql = sSql + " WHERE CODPRODUTO = " + textBox1.Text;
            SqlCommand command = new SqlCommand(sSql, conn);
            //command.Connection.Open();
            command.ExecuteNonQuery();


            BuscarDados();
            
        
        
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          

            string nova = "";
            string a = "";
            for (int t = 0; t <= textBox3.TextLength - 1; t++)
            {
                a = textBox3.Text.Substring(t, 1);
                if (!(a != "0" && a != "1" && a != "2" && a != "3" && a != "4" && a != "5" && a != "6" && a != "7" && a != "8" && a != "9" && a != "0" && a != "."))
                {
                    nova = nova + a;
                }
            }
            textBox3.Text = nova;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string nova = "";
            string a = "";
            for (int t = 0; t <= textBox6.TextLength - 1; t++)
            {
                a = textBox6.Text.Substring(t, 1);
                if (!(a != "0" && a != "1" && a != "2" && a != "3" && a != "4" && a != "5" && a != "6" && a != "7" && a != "8" && a != "9" && a != "0" && a != ","))
                {
                    nova = nova + a;
                }
            }
            textBox6.Text = nova;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //for (int c = 1; c <= aCodProduto.Length - 1; c++)
            //{
            //    if (aCodProduto[c] == null)
            //    {
            //        MessageBox.Show("Item não localizado !", "Não Localizado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //    if (textBox7.Text == aCodProduto[c].Trim() || aNomeProduto[c].Trim().ToUpper().Contains(textBox7.Text.ToUpper()))
            //    {
            //        dgvProdutos[0, c - 1].Selected = true;
            //        atualiza();

            //        return;
            //    }
            //}
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
