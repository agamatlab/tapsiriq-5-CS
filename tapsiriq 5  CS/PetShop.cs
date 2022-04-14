class PetShop
{
    public Animal[] Animals { private get; set; } = null;

    public decimal TotalPrice()
    {
        decimal price = 0;
        foreach (var item in Animals)
            price += item.Price;
        return price;
    }

    public int TotalFood()
    {
        int totalFood = 0;
        foreach (var animal in Animals)
            totalFood += animal.MealQuantity;
        return totalFood;
    }

    public void AddElement(Animal animal)
    {
        if(Animals == null) Animals = new Animal[1] {animal };
        else Animals = Animals.Append(animal).ToArray();
    }

    private bool DoBreak()
    {
        string answer;

        while (true) 
        {
            Console.WriteLine("Do you Want to Continue? (YES/NO)\nEnter your Answer: ");
            answer = Console.ReadLine();
            answer = answer.ToLower();
            Console.Clear();

            if (answer == "yes") return false;
            else if(answer == "no") return true;
        } 
    }

    public void Start()
    {
        for(int i = 1; ; i++)
        {
            foreach (var animal in Animals)
            {
                if (animal is Dog) Console.ForegroundColor = ConsoleColor.Red;
                else if (animal is Cat) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (animal is Bird) Console.ForegroundColor = ConsoleColor.Cyan;

                if (animal.Play())
                    Console.Write($"{animal.GetClassName()} => Played".PadRight(16) + " | ");
                else
                {
                    Random rand = new Random();
                    if(rand.Next() % 2 == 0)
                    {
                        Console.Write($"{animal.GetClassName()} => Sleep".PadRight(16) + " | ");
                        animal.Sleep();
                    }
                    else
                    {
                        Console.Write($"{animal.GetClassName()} => Eat".PadRight(16) + " | ");
                        animal.Eat();
                    }
                }

                animal.ShowStatus();
            }

            Console.ForegroundColor = ConsoleColor.White;
            // Console.Write("\nPress any key to continue...");
            // Console.ReadKey();

            Thread.Sleep(1000);
            Console.Clear();

            if (i % 10 == 0) if (DoBreak()) break;
        }
    }

    Animal[] RemoveAt(Animal[] arr, int index)
    {
        for (int a = index; a < arr.Length - 1; a++)
            arr[a] = arr[a + 1];
        Array.Resize(ref arr, arr.Length - 1);

        return arr;
    }

    public void RemoveByNickName(string NickName)
    {
        for (int index = 0; index < Animals.Length; index++)
            if(Animals[index].Nickname == NickName) Animals = RemoveAt(Animals, index);
    }
}   
