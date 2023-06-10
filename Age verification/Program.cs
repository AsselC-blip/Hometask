namespace Age_verification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");

            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine("You are adult");
            }
            else 
            {
                Console.WriteLine("You are not adult");
            }

        }

    }
}