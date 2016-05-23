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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Seguranca
{
    public partial class Form1 : Form
    {
        public int flag = 0;
        RSACryptoServiceProvider rsa;

        private static int port = 1000;
        TcpClient cliente = new TcpClient(GetLocalIPAddress(), port);

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Conectar
            button1.Text = "Desconectar ao servidor";
            try
            {
                if (flag == 0)
                {

                    flag = 1;
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Tem de preencher com  NOME", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        String username = txtNome.Text;
                        panel_Status.BackColor = Color.Green;

                        Byte[] data = Encoding.ASCII.GetBytes(username);

                        NetworkStream stream = cliente.GetStream();

                        stream.Write(data, 0, data.Length);

                        data = new Byte[256];

                        //String para guardar a resposta do ASCII
                        String responseData = String.Empty;

                       /* //Ler a primeira resposta do TcpServer em bytes
                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = Encoding.ASCII.GetString(data, 0, bytes);*/

                    }
                }
                else if (flag == 1)
                {

                    /*Desconectar */
                    MessageBox.Show("Test");
                    cliente.Close();


                    button1.Text = "Conectar ao servidor";
                    flag = 0;
                }
               
            }
            catch (SocketException r)
            {

                MessageBox.Show("Erro de Socket:", r.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            rsa = new RSACryptoServiceProvider();

            String publickey = rsa.ToXmlString(false);
            String privatePublicPair = rsa.ToXmlString(true);

            txtChavePrivada.Text = publickey;
            txtChavePublica.Text = privatePublicPair;
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
                            



                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtChavePrivada.Text == "")
            {
                MessageBox.Show("Tem de gerar as chaves primeiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                // Encrypt
                byte[] encodedData = Encoding.UTF8.GetBytes(tbSymmentricKey.Text);
                byte[] encryptedData = rsa.Encrypt(encodedData, false);

                tbSymmetricKeyEncrtypted.Text = Convert.ToBase64String(encryptedData);

                Byte[] chave = Encoding.ASCII.GetBytes(tbSymmetricKeyEncrtypted.Text);

                NetworkStream stream = cliente.GetStream();
                stream.Write(chave, 0, chave.Length);

                chave = new Byte[256];

                //String para guardar a resposta do ASCII
                String responseData = String.Empty;

                //Ler a primeira resposta do TcpServer em bytes
                Int32 bytes = stream.Read(chave, 0, chave.Length);
                responseData = Encoding.ASCII.GetString(chave, 0, bytes);

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtChavePrivada.Text == "")
            {
                MessageBox.Show("Tem de encriptar o texto primeiro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // Decrypt
                byte[] decodedData = Convert.FromBase64String(tbSymmetricKeyEncrtypted.Text);
                byte[] decryptedData = rsa.Decrypt(decodedData, false);

                tbSymmetricKeyDecrypted.Text = Encoding.UTF8.GetString(decryptedData);

            }
        }

    }
}

