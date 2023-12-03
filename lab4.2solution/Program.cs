using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // Creating instances of different computers
        Server server = new Server("192.168.1.1", 1000, "Windows Server", "File Server");
        Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10", "Development Workstation");
        Router router = new Router("192.168.1.3", 200, "RouterOS", "Wireless Router");

        // Creating a network and adding computers to it
        Network network = new Network();
        network.AddComputer(server);
        network.AddComputer(workstation);
        network.AddComputer(router);

        // Simulating interactions in the network
        network.SimulateInteractions();

        // Keep the console window open
        Console.ReadLine();
    }
}
