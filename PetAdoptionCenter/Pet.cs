namespace PetAdoptionCenter
{
    internal class Pet
    {

        public string Name { get; set; }
        public string Species { get; set; }
        public bool IsAdopted { get; set; }

        public Pet(string name, string species, bool isAdopted = false)
        {
            Name = name;
            Species = species;
            IsAdopted = isAdopted;

        }

    }
}
