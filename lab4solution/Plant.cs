// Derived class for plants
class Plant : LivingOrganism, IReproducible
{
    public string Type { get; set; }

    public Plant(double energy, int age, double size, string type)
        : base(energy, age, size)
    {
        Type = type;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Type} is spreading seeds.");
    }
}