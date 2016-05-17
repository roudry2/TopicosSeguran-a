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
        static void Main(string[] args)
        {

            TcpListener server = null;
            try
            {
                int port = 1000;
                IPAddress localAddr = IPAddress.Parse("172.22.216.237");
                server = new TcpListener(localAddr, port);
                server.Start();

                //Buffer para ler dados
                Byte[] bytes = new Byte[256];


                TcpClient cliente = server.AcceptTcpClient();
                NetworkStream stream = cliente.GetStream();
                int i = stream.Read(bytes, 0, bytes.Length);
                string data = Encoding.ASCII.GetString(bytes, 0, i);

                //Loop para verificar a conecção
                while (true)
                {
                    Console.Write("A espera de uma coneccao...");
                    Console.Clear();
                    Console.WriteLine("Cliente: " + data + "Conectado!");
                    
                    

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
                    cliente.Close();
                }
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