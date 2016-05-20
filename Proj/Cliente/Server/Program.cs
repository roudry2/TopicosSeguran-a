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
                int i = stream.Read(bytes, 0, bytes.Length);
                string data = Encoding.ASCII.GetString(bytes, 0, i);
                stream.Write(bytes, 0, bytes.Length);


                //Loop para verificar a conecção
                while (true)
                {
                    
                    Console.Clear();
                    Console.WriteLine("Cliente: " + data);
                    
                    

                    //Loop para receber todos os dados enviados pelo cliente
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        //traduzir os bytes para um string em ASCII
                        data = Encoding.ASCII.GetString(bytes, 0, i);

                        //Processar os dados enviados pelo cliente
                        data = data.ToUpper();

                        byte[] msg = Encoding.ASCII.GetBytes(data);

                        //enviar uma resposta de volta
                        stream.Write(msg, 0, msg.Length);
                        Console.WriteLine("Enviado: " + data.ToString());


                    }
                    
                }
                cliente.Close();
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