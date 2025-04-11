namespace PetAdoptionCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdoptionCenter adopCenter = new AdoptionCenter();
            Pet pet1 = new Pet("Jerry", "dog");
            Pet pet2 = new Pet("Milky", "cat");
            Pet pet3 = new Pet("Slider", "snake");
            Pet pet4 = new Pet("Lily", "dog");

            adopCenter.AddPet(pet1);
            adopCenter.AddPet(pet2);
            adopCenter.AddPet(pet3);
            adopCenter.AddPet(pet4);


            Console.WriteLine("Would you like to become an Owner of a Pet?, 'y' for yes and 'n' for no");
            char userChoice = char.Parse(Console.ReadLine());

            if (userChoice == 'y')
            {
                Console.WriteLine("Great!, what is your name so I can establish you as an owner:\n");
                Owner owner = new Owner(Console.ReadLine());

                Program.PresentAdoptionScreen(owner);

                bool keepAdopting = true;
                while (keepAdopting)
                {
                    Console.WriteLine("Would you like to adopt any other pets?, 'y' for yes and 'n' for no");
                    char adoptMorePets = char.Parse(Console.ReadLine());
                    if (adoptMorePets == 'y')
                    {
                        Program.PresentAdoptionScreen(owner);

                    }
                    else
                    {
                        Console.WriteLine($"Thank you for adopting {owner.TotalOwnedPets} pets!");
                        keepAdopting = false;
                    }
                }



            }
            else
            {
                Console.WriteLine("Dissapointing >:(");
            }
        }

        public static void PresentAdoptionScreen(Owner owner)
        {
            owner.ViewPets();
            Console.WriteLine("Choose a pet to adopt");
            string petName = Console.ReadLine().ToLower();

            owner.AdoptPet(petName);

        }
    }
}
