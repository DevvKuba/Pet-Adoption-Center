namespace PetAdoptionCenter
{
    internal class AdoptionCenter
    {
        // store both names and species in list...

        public static int PetCount { get; set; }
        public static List<Pet> PetInfo { get; set; }

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
