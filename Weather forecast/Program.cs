namespace Weather_forecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperature;
            Console.WriteLine("enter temperature");
            temperature = double.Parse(Console.ReadLine());

            switch (temperature)
            {
                case < 0:
                    Console.WriteLine("Very cold"); break;
                case (> 0) and (< 10):
                    Console.WriteLine("cold"); break;
                case (> 10) and (< 20):
                    Console.WriteLine("normal"); break;
                case (> 20) and (< 30):
                    Console.WriteLine("warm");break;
                default:
                    Console.WriteLine("hot");
                    break;
            }
        }
    }
}