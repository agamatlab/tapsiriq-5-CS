using System.Threading;
enum Gender { Male,Female }

class Program
{
    static void Main(string[] args)
    {
        PetShop petShop = new PetShop();
        petShop.AddElement(new Cat("Milo", 4, Gender.Female, Convert.ToSByte(60), 8.0m, 4));
        petShop.AddElement(new Dog("Peroho", 2, Gender.Male, Convert.ToSByte(40), 2.0m, 8));
        petShop.AddElement(new Bird("Pedro", 3, Gender.Male, Convert.ToSByte(80), 2.3m, 1, true));

        Console.WriteLine("Starting...");
        Thread.Sleep(2000);
        Console.Clear();

        petShop.Start();

        Console.WriteLine($"Total Food: {petShop.TotalFood()}" +
            $"\nTotal Price: {Math.Round(petShop.TotalPrice(), 2)}");
    }
}
