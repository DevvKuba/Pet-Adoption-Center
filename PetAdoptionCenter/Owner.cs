namespace PetAdoptionCenter
{
    internal class Owner
    {

        public int TotalOwnedPets { get; set; }
        public string Name { get; set; }

        public Owner(string name)
        {
            Name = name;

        }
        public Owner()
        {
            Name = "No name provided";
        }

        public void ViewPets()
        {
            Console.WriteLine("Here are all the pets in the adoption center:\n");
            foreach (Pet pet in AdoptionCenter.PetInfo)
            {
                Console.WriteLine($"{pet.Name} : {pet.Species}\n");
            }
        }

        public void AdoptPet(string petName)
        {
            TotalOwnedPets++;

            for (int i = 0; i < AdoptionCenter.PetInfo.Count; i++)
            {
                if (AdoptionCenter.PetInfo[i].Name.ToLower() == petName)
                {
                    AdoptionCenter.PetInfo.RemoveAt(i);
                }
            }

            Console.WriteLine($"{petName} adopted!, you now have: {TotalOwnedPets} total owned pets");

        }

    }
}
