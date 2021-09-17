using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Threading;

namespace socket2
{
    public partial class Form1 : Form
    {
        TcpClient tcpCliente;
        NetworkStream networkStream;
        Thread thInteraction;

        public Form1()
        {
            InitializeComponent();
        }

        private void connect()
        {
            tcpCliente = new TcpClient();
            setMsg("## ESTABELECENDO CONEXÃO. . .");
            tcpCliente.Connect("192.168.10.23", 8000);
        }

        private void disconnect()
        {
            if (thInteraction != null)
            {
                if (thInteraction.ThreadState == ThreadState.Running)
                    thInteraction.Abort();
            }

            tcpCliente.Close();
        }

        private void enviarMsg(string mensagem)
        {
            if (networkStream.CanWrite)
            {
                byte[] sendBytes = Encoding.ASCII.GetBytes(mensagem);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
            }
        }

        delegate void delSetMsg(string mensagem);
        private void setMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delSetMsg(setMsg), mensagem);
            }
            else
            {
                rtbConversa.Text = "Eu: " + mensagem + "\n";
            }
        }

        delegate void delGetMsg(string mensagem);
        private void getMsg(string mensagem)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new delGetMsg(getMsg), mensagem);
            }
            else
            {
                rtbConversa.Text = "Server: " + mensagem + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();

            thInteraction = new Thread(new ThreadStart(interaction));
            thInteraction.IsBackground = true;
            thInteraction.Priority = ThreadPriority.Highest;
            thInteraction.Name = "thInteraction";
            thInteraction.Start();
        }

        private void txbMenssagem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string mensagem = txbMenssagem.Text;
                enviarMsg(mensagem);
                setMsg(mensagem);
            }
        }

        private void txbMenssagem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txbMenssagem.Clear();
        }

        private void interaction()
        {
            try 
            {
                do
                {
                    networkStream = tcpCliente.GetStream();

                    if (networkStream.CanRead)
                    {
                        byte[] bytes = new byte[tcpCliente.ReceiveBufferSize];
                        networkStream.Read(bytes, 0, Convert.ToInt32(tcpCliente.ReceiveBufferSize));

                        string returnData = Encoding.ASCII.GetString(bytes);
                        getMsg(returnData);
                    }
                    else
                    {
                        setMsg("## Não é possivel ler dados para este stream. . .");
                        disconnect();
                    }
                } while (tcpCliente.Connected);
            }
            catch{}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            disconnect();
        }
    }
}
