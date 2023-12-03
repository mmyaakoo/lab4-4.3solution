// Class for simulating traffic on a road
class TrafficSimulator
{
    private Road road;
    private List<Vehicle> vehicles;

    public TrafficSimulator(Road road)
    {
        this.road = road;
        vehicles = new List<Vehicle>();
    }

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void SimulateTraffic()
    {
        Console.WriteLine($"Simulating traffic on a road of length {road.Length} km with {road.Lanes} lanes.");

        foreach (var vehicle in vehicles)
        {
            // Simulate vehicles moving on the road
            vehicle.Move();
        }

        Console.WriteLine("Traffic simulation completed.");
    }
}
