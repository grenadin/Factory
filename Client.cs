using System;

namespace Factory
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App: Launched with the RoadLogistics.");
            ClientMethod(new RoadLogistics());
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("App: Launched with the RoadLogistics.");
            ClientMethod(new SeaLogistics());
            Console.WriteLine("------------------------------------------------------------------------------");

            Console.WriteLine("App: Launched with the RoadLogistics.");
            ClientMethod(new AirLogistics());
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        static void ClientMethod(Logistics creator)//
        {
            Console.WriteLine($"Client not concern the creator class. It still work. {creator.PlanDelivery()}");
        }

    }

}
