namespace Season_of_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double month;
            Console.WriteLine("enter month");
            month = double.Parse(Console.ReadLine());

            switch (month)
            {
                case (12 or 1 or 2):
                    Console.WriteLine("Winter"); break;
                case (3 or 4 or 5):
                    Console.WriteLine("Spring"); break;
                case (6 or 7 or 8):
                    Console.WriteLine("Summer"); break;
                case (9 or 10 or 11):
                    Console.WriteLine("Autumn"); break;
                default:
                    break;
            }
        }
    }
}