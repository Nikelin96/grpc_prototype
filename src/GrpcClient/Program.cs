using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

            var request = new HelloRequest { Name = "Nik" };

            var reply = await client.SayHelloAsync(request);

            Console.WriteLine(reply.Message);

            Console.ReadLine();
        }
    }
}
