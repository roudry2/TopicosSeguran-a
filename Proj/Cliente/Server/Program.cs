using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
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
        static void Main(string[] args)
        {

            TcpListener server = null;
            try
            {
                int port = 1000;
                IPAddress localAddr = IPAddress.Parse(GetLocalIPAddress());
                server = new TcpListener(localAddr, port);
                server.Start();

                //Buffer para ler dados
                Byte[] bytes = new Byte[256];

                Console.Write("A espera de uma coneccao...");
                TcpClient cliente = server.AcceptTcpClient();
                NetworkStream stream = cliente.GetStream();

                if (cliente.Connect==true)
                {

                }


                int i = stream.Read(bytes, 0, bytes.Length);
                string username = Encoding.ASCII.GetString(bytes, 0, i);
                stream.Write(bytes, 0, bytes.Length);
                Console.Clear();
                Console.WriteLine("Cliente: " + username + " conectado!!");
                

                Byte[] bytes2 = new Byte[256];
                int i2 = stream.Read(bytes2, 0, bytes2.Length);
                string chave = Encoding.ASCII.GetString(bytes2, 0, i2);
                stream.Write(bytes2, 0, bytes2.Length);
                Console.WriteLine("\n\n Chave: " + chave);
                

                //Loop para verificar a conecção
               /* while (true)
                {*/
                    
                    //Loop para receber todos os dados enviados pelo cliente
                   /* while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {*/
                        //traduzir os bytes para um string em ASCII
                        username = Encoding.ASCII.GetString(bytes, 0, i);

                        //Processar os dados enviados pelo cliente
                        username = username.ToUpper();

                        byte[] msg = Encoding.ASCII.GetBytes(username);
                
                        //enviar uma resposta de volta
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Enviado: " + username.ToString());


                   /* }*/
                    
              //  }

            }
            catch (SocketException e)
            {
                Console.WriteLine("Erro de Socket: ", e);
                Console.ReadKey();
            }
            finally
            {
                //Parar o listening para os novos clientes
                server.Stop();
            }
            Console.ReadKey();
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.Read();



        }
    }
}