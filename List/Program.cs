

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 5, 20, 15, 30, 25 };

            // 1. Вывести отсортированные элементы по возрастанию
            List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();
            Console.WriteLine("Отсортированные элементы по возрастанию:");
            foreach (int number in sortedNumbers)
            {
                Console.WriteLine(number);
            }

            // 2. Вывести числа, которые делятся на два без остатка
            List<int> divisibleByTwo = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Числа, которые делятся на два без остатка:");
            foreach (int number in divisibleByTwo)
            {
                Console.WriteLine(number);
            }

            // 3. Вывести числа, которые больше 42
            List<int> greaterThan42 = numbers.Where(x => x > 42).ToList();
            Console.WriteLine("Числа, которые больше 42:");
            foreach (int number in greaterThan42)
            {
                Console.WriteLine(number);
            }

            // 4. Вывести сумму всех элементов коллекции
            int sum = numbers.Sum();
            Console.WriteLine("Сумма всех элементов коллекции: " + sum);

           
            
                List<string> strings = new List<string> { "Hello", "World", "C#", "Programming" };

                // 1. Вывести строки, которые не содержат пробелы
                List<string> withoutSpaces = strings.Where(x => !x.Contains(" ")).ToList();
                Console.WriteLine("Строки, которые не содержат пробелы:");
                foreach (string str in withoutSpaces)
                {
                    Console.WriteLine(str);
                }

                // 2. Вывести строки, которые содержат заглавные буквы
                List<string> withUppercase = strings.Where(x => x.Any(char.IsUpper)).ToList();
                Console.WriteLine("Строки, которые содержат заглавные буквы:");
                foreach (string str in withUppercase)
                {
                    Console.WriteLine(str);
                }

                // 3. Вывести строки, которые содержат заданную подстроку (выше в коде в переменной/введённую с консоли)
                string substring = "lo";
                List<string> withSubstring = strings.Where(x => x.Contains(substring)).ToList();
                Console.WriteLine("Строки, которые содержат подстроку \"" + substring + "\":");
                foreach (string str in withSubstring)
                {
                    Console.WriteLine(str);
                }

                // 4. Вывести (true/false) ответ, содержатся ли в любой строке коллекции число.
                bool containsNumber = strings.Any(x => x.Any(char.IsDigit));
                Console.WriteLine("Содержатся ли в любой строке коллекции число: " + containsNumber);
            }
        }
    }



    