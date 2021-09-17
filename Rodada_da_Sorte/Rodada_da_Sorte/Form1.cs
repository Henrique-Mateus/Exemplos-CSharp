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
using System.Drawing.Printing;

namespace Rodada_da_Sorte
{

    public partial class Form1 : Form
    {
        int[] arrayNumeros = new int[100];
        int[] numeros = new int[4];
        int PosicaoRetorno = -1;
        int NumeroLAT;

        public Form1()
        {
            InitializeComponent();
        }

        private int posisao()
        {
            int contador = 0;
            foreach (var numeroBloco in arrayNumeros)
            {
                if (numeroBloco == 0)
                {
                    return contador;
                }
                contador++;

            }
            return contador;

        }

        private int buscarContador(int[] array)
        {
            int iContador = 0;

            foreach (var numeroBloco in arrayNumeros)
            {
                if (numeroBloco == 0)
                {
                    return iContador;
                }
                if (numeroBloco == NumeroLAT)
                {
                    return -1;
                }
                iContador++;
            }

            return iContador;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayNumeros[0] = 6171;
            arrayNumeros[1] = 9887;
            arrayNumeros[2] = 8833;
            arrayNumeros[3] = 1775;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn3.Enabled = true;
            bool DeveInserir = false;
            int iContador = -1;
            int valorInteiro = 0;

            PosicaoRetorno = -1;

            Random numAleatorio = new Random();

            for (int i = 0; i < 4; i++)
            {

                while (iContador == -1)
                {
                    valorInteiro = numAleatorio.Next(1000, 9999);
                    iContador = buscarContador(arrayNumeros);

                }

                arrayNumeros[iContador] = valorInteiro;

                switch (i)
                {
                    case 0:
                        lbl1.Text = Convert.ToString(valorInteiro);
                        lbl1.Refresh();
                        break;
                    case 1:
                        lbl2.Text = Convert.ToString(valorInteiro);
                        lbl2.Refresh();
                        break;
                    case 2:
                        lbl3.Text = Convert.ToString(valorInteiro);
                        lbl3.Refresh();
                        break;
                    case 3:
                        lbl4.Text = Convert.ToString(valorInteiro);
                        lbl4.Refresh();
                        break;
                }
                iContador = -1;

            }





        }

        private void button2_Click(object sender, EventArgs e)
        {

            CapturarForm();
            printDocument2.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = 0;
            int numeros;
            int pos = posisao();

            if (pos <= 4) return;


            int posicaoInicial = pos - 8;

            if (PosicaoRetorno != -1)
            {
                posicaoInicial = PosicaoRetorno + 4;
            }

            if (posicaoInicial < pos)
            {
                lbl1.Text = Convert.ToString(arrayNumeros[posicaoInicial]);
                lbl2.Text = Convert.ToString(arrayNumeros[posicaoInicial + 1]);
                lbl3.Text = Convert.ToString(arrayNumeros[posicaoInicial + 2]);
                lbl4.Text = Convert.ToString(arrayNumeros[posicaoInicial + 3]);

                PosicaoRetorno = posicaoInicial;

                btn2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Você chegol ao final da linha!",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = (@""+textBox1.Text+"");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int t = 0;
            int numeros;
            int pos = posisao();

            if (pos <= 4) return;


            int posicaoInicial = pos - 8;

            if (PosicaoRetorno != -1)
            {
                posicaoInicial = PosicaoRetorno - 4;

            }

            if (posicaoInicial > -4)
            {
                lbl1.Text = Convert.ToString(arrayNumeros[posicaoInicial]);
                lbl2.Text = Convert.ToString(arrayNumeros[posicaoInicial + 1]);
                lbl3.Text = Convert.ToString(arrayNumeros[posicaoInicial + 2]);
                lbl4.Text = Convert.ToString(arrayNumeros[posicaoInicial + 3]);

                PosicaoRetorno = posicaoInicial;

                btn2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Você estar no começo da linha!",
                "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(captura, 20, 20);
        }

        public static class WindowHelper
        {
            [Serializable, System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
            public struct Rect
            {
                public int Left;
                public int Top;
                public int Right;
                public int Bottom;

                public System.Drawing.Rectangle ToRectangle()
                {
                    return System.Drawing.Rectangle.FromLTRB(Left, Top, Right, Bottom);
                }
            }

            [System.Runtime.InteropServices.DllImport(@"dwmapi.dll")]
            public static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute, int cbAttribute);

            public enum Dwmwindowattribute
            {
                DwmwaExtendedFrameBounds = 9
            }
        }

        private void CapturarForm()
        {
            captura = new Bitmap(448, 213);
            var graphics = Graphics.FromImage(captura);
            graphics.CopyFromScreen(this.Location.X + 14, this.Location.Y + 34, 0, 0, new Size(448, 213));
        }

        Bitmap captura = null;
    }
}

