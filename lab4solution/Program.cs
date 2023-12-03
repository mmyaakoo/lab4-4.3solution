class Program
{
    static void Main()
    {
        // Creating instances of different organisms
        Animal lion = new Animal(100, 5, 2, "Lion");
        Plant oakTree = new Plant(50, 10, 5, "Oak Tree");
        Microorganism bacteria = new Microorganism(10, 1, 0.1, "Bacteria");

        // Creating an ecosystem and adding organisms to it
        Ecosystem ecosystem = new Ecosystem();
        ecosystem.AddOrganism(lion);
        ecosystem.AddOrganism(oakTree);
        ecosystem.AddOrganism(bacteria);

        // Simulating interactions in the ecosystem
        ecosystem.SimulateInteractions();

        // Keep the console window open
        Console.ReadLine();
    }
}