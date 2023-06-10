namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("size of one leg");
            double leg1= double.Parse(Console.ReadLine());
            Console.WriteLine("size of second leg");
            double leg2 = double.Parse(Console.ReadLine());
            Console.WriteLine("size of hypetenuse");
            double hypetenuse = double.Parse(Console.ReadLine());
            double result = leg1 * leg2 * hypetenuse;
            Console.WriteLine("result\n"+result);
        }
    }
}