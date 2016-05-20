using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        RSACryptoServiceProvider rsa;
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
            try
            {
                if (txtNome.Text == "")
                {
                    MessageBox.Show("Tem de preencher com  NOME");
                }
                else
                {
                    String message = txtNome.Text;



                    int port = 1000;
                    TcpClient cliente = new TcpClient(GetLocalIPAddress(), port);
                    Byte[] data = Encoding.ASCII.GetBytes(message);

                    NetworkStream stream = cliente.GetStream();

                    stream.Write(data, 0, data.Length);
                    MessageBox.Show("Enviado:" + message);
                    data = new Byte[256];

                    //String para guardar a resposta do ASCII
                    String responseData = String.Empty;

                    //Ler a primeira resposta do TcpServer em bytes
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = Encoding.ASCII.GetString(data, 0, bytes);


                    stream.Close();
                    cliente.Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
