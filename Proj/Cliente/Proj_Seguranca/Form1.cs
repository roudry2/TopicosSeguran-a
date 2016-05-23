using EI.SI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Seguranca
{
    public partial class Form1 : Form
    {
        public int flag = 0;

        private static int port = 1000;

        RSACryptoServiceProvider rsa;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Conectar
            button1.Text = "Desconectar";

            if (flag == 0)
            {
                flag = 1;

                if (txtNome.Text == "")
                {
                    MessageBox.Show("Tem de preencher com  NOME", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Text = "Conectar ao servidor";
                }
                else
                {
                    String username = txtNome.Text;
                    panel_Status.BackColor = Color.Green;

                    MessageBox.Show("Cliente Conectado");
                    button2.Enabled = true;
                    button4.Enabled = true;
                    btnEnviarFicheiro.Enabled = true;

                    IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, port);
                    TcpClient client = new TcpClient();

                    client.Connect(endpoint);
                    ProtocolSI protocoloSI = new ProtocolSI();
                    NetworkStream networkStream = client.GetStream();

                    //Envia o nome pro server
                    String data = txtNome.Text;
                    byte[] nome = protocoloSI.Make(ProtocolSICmdType.DATA, data);
                    networkStream.Write(nome, 0, nome.Length);
                    
                }
            }
            else
            {

                MessageBox.Show("Client Disconnected");

                button1.Text = "Conectar ao servidor";
                flag = 0;
                panel_Status.BackColor = Color.Red;
                txtNome.Text = "";
                button2.Enabled = false;
                button4.Enabled = false;
                btnEnviarFicheiro.Enabled = false;

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rsa = new RSACryptoServiceProvider();

            String publickey = rsa.ToXmlString(false);
            String privatePublicPair = rsa.ToXmlString(true);

            txtChavePublica.Text = publickey;
            txtBothKeys.Text = privatePublicPair;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {

                            // -> Abrir o ficheiro (original)
                            String caminho_original = openFileDialog1.InitialDirectory;
                            FileStream ficheiro_original = File.OpenRead(caminho_original);

                            // -> Criar ficheiro de destino
                            if (File.Exists(caminho_destino))
                            {
                                File.Delete(caminho_destino);
                            }
                            FileStream ficheiro_destino = File.OpenWrite(caminho_destino);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

        }


    }
}

