using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Network;

namespace Networking
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            API.InitializeClient();

            JsonClient client = new JsonClient();

            var trains = await client.GetDataAsync<List<Train>>("/trains/latest/5");

            trains.ForEach((x) => Console.WriteLine(x.trainNumber));
            trains.ForEach((x) => Console.WriteLine(x.trainCategory));
            trains.ForEach((x) => Console.WriteLine(x.trainType));
            trains.ForEach((x) => Console.WriteLine(x.departureDate));
        }
    }
}
