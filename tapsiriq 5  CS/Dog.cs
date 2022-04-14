class Dog : Animal
{
    public void Bark() => Console.WriteLine("Haww...");
    public Dog(string nickname, short age, Gender gender, sbyte energy, decimal price, int mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity) { }

    public override string GetClassName() => "Dog";
    public override void ShowStatus()
    {
        Console.Write("DOG => ");
        base.ShowStatus();
    }
}
