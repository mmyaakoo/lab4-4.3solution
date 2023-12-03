// Derived class for workstations
class Workstation : Computer, IConnectable
{
    public string WorkstationType { get; set; }

    public Workstation(string ipAddress, int power, string os, string workstationType)
        : base(ipAddress, power, os)
    {
        WorkstationType = workstationType;
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
