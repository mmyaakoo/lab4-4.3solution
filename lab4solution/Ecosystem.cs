// Ecosystem class modeling interactions between organisms
class Ecosystem
{
    private List<LivingOrganism> organisms;

    public Ecosystem()
    {
        organisms = new List<LivingOrganism>();
    }

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateInteractions()
    {
        foreach (var organism in organisms)
        {
            if (organism is IReproducible reproducibleOrganism)
            {
                reproducibleOrganism.Reproduce();
            }

            if (organism is IPredator predatoryOrganism)
            {
                // Simulate hunting for prey
                var prey = organisms.FirstOrDefault(o => o != organism);
                if (prey != null)
                {
                    predatoryOrganism.Hunt(prey);
                }
            }
        }
    }
}