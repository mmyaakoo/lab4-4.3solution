// Derived class for animals
class Animal : LivingOrganism, IReproducible, IPredator
{
    public string Species { get; set; }

    public Animal(double energy, int age, double size, string species)
        : base(energy, age, size)
    {
        Species = species;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Species} is reproducing.");
    }

    public void Hunt(LivingOrganism prey)
    {
        Console.WriteLine($"{Species} is hunting for food.");
        // Implement hunting logic here
    }
}