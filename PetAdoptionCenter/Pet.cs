namespace PetAdoptionCenter
{
    internal class Pet
    {
        private string _name;
        private string _species;
        private bool _isAdopted;

        public string Name { get => _name; set => _name = value; }
        public string Species { get => _species; set => _species = value; }
        public bool IsAdopted { get => _isAdopted; set => _isAdopted = value; }

        public Pet(string name, string species, bool isAdopted = false)
        {
            Name = name;
            Species = species;
            IsAdopted = isAdopted;

        }

    }
}
