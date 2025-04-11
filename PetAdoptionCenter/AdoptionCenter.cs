namespace PetAdoptionCenter
{
    internal class AdoptionCenter
    {
        // store both names and species in list...
        private static List<Pet> _petInfo;
        private static int _petCount;
        public static int PetCount { get => _petCount; set => _petCount = value; }
        public static List<Pet> PetInfo { get => _petInfo; set => _petInfo = value; }

        public AdoptionCenter()
        {
            // list does actually need to be initialised
            PetInfo = new List<Pet>();
            PetCount = 0;
        }

        public void AddPet(Pet pet)
        {
            PetInfo.Add(pet);
            PetCount += 1;
        }


    }
}
