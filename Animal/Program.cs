abstract class Animal
{
    public string Name { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Собака ест корм");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя собаки:");
        string name = Console.ReadLine();

        Dog dog = new Dog();
        dog.SetName(name);

        Console.WriteLine("Имя собаки: " + dog.GetName());
        dog.Eat();
    }
}
