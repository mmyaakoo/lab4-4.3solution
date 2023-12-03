// Derived class for servers
class Server : Computer, IConnectable
{
    public string ServerType { get; set; }

    public Server(string ipAddress, int power, string os, string serverType)
        : base(ipAddress, power, os)
    {
        ServerType = serverType;
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
