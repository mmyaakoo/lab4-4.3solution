// Base class for computers
class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OS { get; set; }

    public Computer(string ipAddress, int power, string os)
    {
        IPAddress = ipAddress;
        Power = power;
        OS = os;
    }
}