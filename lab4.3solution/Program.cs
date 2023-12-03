using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // Create a road and a traffic simulator
        Road cityRoad = new Road(10.0, 2.5, 2);
        TrafficSimulator trafficSimulator = new TrafficSimulator(cityRoad);

        // Create different types of vehicles
        Vehicle car = new Vehicle("Car", 60.0, 2.0);
        Vehicle truck = new Vehicle("Truck", 40.0, 3.5);
        Vehicle bus = new Vehicle("Bus", 50.0, 4.0);

        // Add vehicles to the traffic simulator
        trafficSimulator.AddVehicle(car);
        trafficSimulator.AddVehicle(truck);
        trafficSimulator.AddVehicle(bus);

        // Simulate traffic on the road
        trafficSimulator.SimulateTraffic();

        // Keep the console window open
        Console.ReadLine();
    }
}
