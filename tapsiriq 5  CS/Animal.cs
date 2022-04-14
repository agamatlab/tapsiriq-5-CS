class Animal
{

    public Animal(string nickname, short age, Gender gender, sbyte energy, decimal price, int mealQuantity)
    {
        Nickname = nickname;
        Age = age;
        Gender = gender;
        Energy = energy;
        Price = price;
        MealQuantity = mealQuantity;
    }

    public string Nickname { get; set; }
    public short Age { get; set; }
    public Gender Gender { get; set; }
    public sbyte Energy { get; set; }
    public decimal Price { get; set; }
    public int MealQuantity{ get; set; }


    // Methods: Eat(), Sleep(), Play()
    public void Eat()
    {
        if (Energy == 100) return;

        Random rand = new Random();
        Energy += Convert.ToSByte(5 + rand.Next() % 5);
        if (Energy > 100) Energy = 100;
        Price += Convert.ToDecimal(rand.NextDouble() * (rand.Next() % 20));
        MealQuantity++;
    }

    public void Sleep()
    {
        if (Energy == 100) return;

        Random rand = new Random();
        Energy += Convert.ToSByte(70 + rand.Next() % 10);
        if (Energy > 100) Energy = 100;
    }

    public bool Play()
    {
        if(Energy == 0) return false;

        Random rand = new Random();
        Energy -= Convert.ToSByte(5 + rand.Next() % 5);
        if (Energy < 0) Energy = 0;

        return true;
    }

    virtual public string GetClassName() => "Animal";

    virtual public void ShowStatus()
    => Console.WriteLine($"Nickname: {Nickname} | Energy: {Energy}");
}
