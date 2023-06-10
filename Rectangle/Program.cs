namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of one side");
            double Perimeter1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Size of second size");
            double Perimeter2 = double.Parse(Console.ReadLine());
            double result = (Perimeter1 * Perimeter2);
            Console.WriteLine("Result \n"+result);
        }
    }
}