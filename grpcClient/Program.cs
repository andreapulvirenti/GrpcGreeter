using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7195");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(
                  new HelloRequest { Name = "Sono pulvi" });
Console.WriteLine("Risposta: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();