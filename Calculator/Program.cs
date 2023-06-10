namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, secondvalue;
            string operation;

            Console.WriteLine("enter the number 1");
            firstvalue = double.Parse(Console.ReadLine());
            Console.WriteLine("enter operation:'+' '-' '/' '*' '%'");
            string action = Console.ReadLine();
            Console.WriteLine("enter the number 2");
            secondvalue = double.Parse(Console.ReadLine());
            double result = 0;
            switch (action)
            {
                case "+":
                    result = firstvalue + secondvalue; break;
                case "-":
                    result = firstvalue - secondvalue; break;
                case "/":
                    result = firstvalue / secondvalue; break;
                case "*":
                    result = firstvalue * secondvalue; break;
                case "%":
                    result = firstvalue % secondvalue;
                    break;
                default:
                    break;
            }

            //        if (action == "+")
            //        {
            //            result = firstvalue + secondvalue;
            //        }
            //        else if (action == "-")
            //        {
            //            result = firstvalue - secondvalue;
            //        }
            //        else if (action == "/")
            //        {
            //            result = firstvalue / secondvalue;
            //        }
            //        else if (action == "*")
            //        {
            //            result = firstvalue * secondvalue;
            //        }
            //        else if (action == "%")
            //        {
            //            result = firstvalue % secondvalue;
            //        }
            //        Console.WriteLine("result\n" + result);
            //        Console.ReadLine();
            //    }
            //}
        }
    }
}