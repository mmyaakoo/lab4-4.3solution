// Derived class for microorganisms
class Microorganism : LivingOrganism, IReproducible
{
    public string Strain { get; set; }

    public Microorganism(double energy, int age, double size, string strain)
        : base(energy, age, size)
    {
        Strain = strain;
    }

    public void Reproduce()
    {
        Console.WriteLine($"{Strain} is undergoing cell division.");
    }
}