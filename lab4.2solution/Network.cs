// Class modeling interactions between computers in a network
class Network
{
    private List<Computer> computers;

    public Network()
    {
        computers = new List<Computer>();
    }

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void SimulateInteractions()
    {
        foreach (var computer in computers)
        {
            if (computer is IConnectable connectableComputer)
            {
                // Simulate connecting and transferring data to another random computer in the network
                int randomIndex = new Random().Next(computers.Count);
                Computer otherComputer = computers[randomIndex];

                connectableComputer.Connect(otherComputer);
                connectableComputer.TransferData(otherComputer, "Sample data");
                connectableComputer.Disconnect(otherComputer);
            }
        }
    }
}
