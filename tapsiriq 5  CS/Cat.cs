class Cat : Animal
{
    public void Snarl() => Console.WriteLine("Grrr...");
    public Cat(string nickname, short age, Gender gender, sbyte energy, decimal price, int mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity) {}

    public override string GetClassName() => "Cat";

    public override void ShowStatus()
    {
        Console.Write("Cat => ");
        base.ShowStatus();
    }
}
