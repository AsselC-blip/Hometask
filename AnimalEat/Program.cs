namespace AnimalEat
{
    abstract class Animal
    {
        protected string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public abstract void MakeSound();

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Pig : Animal
    {
        public Pig(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Oink");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Whiskers", 3);
            Pig pig = new Pig("Porky", 5);

            cat.PrintInfo();
            cat.MakeSound();

            Console.WriteLine();

            pig.PrintInfo();
            pig.MakeSound();
        }
    }
}