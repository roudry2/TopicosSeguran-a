using EI.SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {

        private const int PORT = 1000;

        static void Main(string[] args)
        {

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, PORT);
            TcpListener listener = new TcpListener(endpoint);
            listener.Start();

            Console.WriteLine("Server: -> Server Started" + Environment.NewLine);

            int clientCounter = 0;

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                clientCounter++;

                // cria o stream
                NetworkStream networkStream = client.GetStream();
                ProtocolSI protocoloSI = new ProtocolSI();

                // Recebe o nome
                byte[] nome = protocoloSI.Make(ProtocolSICmdType.ACK);
                networkStream.Read(protocoloSI.Buffer, 0, protocoloSI.Buffer.Length);

                Console.WriteLine("Server: -> Client {0} - {1} Connected", protocoloSI.GetStringFromData(), clientCounter);
                
                ClientHandler handler = new ClientHandler(client, clientCounter);
                handler.Handle();

            }

        }

        class ClientHandler
        {
            private TcpClient client;
            private int clientID;

            public ClientHandler(TcpClient client, int clientID)
            {
                this.client = client;
                this.clientID = clientID;

            }

            public void Handle()
            {
                Thread tread = new Thread(threadHandler);
                tread.Start();
            }

            private void threadHandler()
            {
                NetworkStream networkStream = this.client.GetStream();
                ProtocolSI protocoloSI = new ProtocolSI();

                networkStream.Read(protocoloSI.Buffer, 0, protocoloSI.Buffer.Length);
                Console.WriteLine("Server: -> client {0} -- disconected", clientID);


                



                Console.WriteLine("Server: -> Ending Thread for client {0} ", clientID);

            }

        }




    }
}