namespace age_verification.tern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            string result = age >= 18 ? "You're adult" : "You're not adult";
            Console.WriteLine(result);
        }
    }
}