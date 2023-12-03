// Derived class for routers
class Router : Computer, IConnectable
{
    public string RouterType { get; set; }

    public Router(string ipAddress, int power, string os, string routerType)
        : base(ipAddress, power, os)
    {
        RouterType = routerType;
    }

    public void Connect(Computer other)
    {
        Console.WriteLine($"{IPAddress} is connecting to {other.IPAddress}.");
    }

    public void Disconnect(Computer other)
    {
        Console.WriteLine($"{IPAddress} is disconnecting from {other.IPAddress}.");
    }

    public void TransferData(Computer other, string data)
    {
        Console.WriteLine($"{IPAddress} is transferring data to {other.IPAddress}: {data}");
    }
}