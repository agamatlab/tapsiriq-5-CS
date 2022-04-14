class Bird : Animal
{
    public bool CanFly { get; set; }
    public Bird(string nickname, short age, Gender gender, sbyte energy, decimal price, int mealQuantity, bool canFly)
        : base(nickname, age, gender, energy, price, mealQuantity) { CanFly = canFly; }

    public override string GetClassName() => "Bird";

    public override void ShowStatus()
    {
        Console.Write("Bird => ");
        base.ShowStatus();
    }
}
