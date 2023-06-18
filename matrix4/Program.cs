using System.Security.Cryptography.X509Certificates;

namespace matrix4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size A");
            int sizeA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter size B");
            int sizeB = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[sizeA, sizeB];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + "X: " + j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int z = 0; z < array.GetLength(1); z++)
                {
                    Console.Write(array[y, z] + "\t");
                }
                Console.WriteLine();

            }

            var menu = new string[]
            {
                "1) Find number of positive / negative numbers in matrix",
                "2) Sorting matrix elements line by line",
                "3) Invert matrix elements line by line",
                "0) Exit",
            };

            //int indexMenu = -1;
            bool exitFromLoop = false;
            while (!exitFromLoop)
            {
                foreach (var z in menu)
                {
                    Console.WriteLine(z);
                }
                Console.Write("\n" +
                    "Select option: ");


                {
                    int selectedMenu = int.Parse(Console.ReadLine());

                    switch (selectedMenu)
                    {
                        case 1:
                            Console.WriteLine("Find number of positive / negative numbers in matrix");
                            Console.WriteLine("1");
                            int countPositive = 0;
                            int countNegative = 0;

                            foreach (var number in array)
                            {
                                if (number > 0)
                                {
                                    countPositive++;
                                }
                                else
                                {
                                    countNegative++;

                                }
                            }
                            Console.WriteLine("Positive numbers count is: " + countPositive);
                            Console.WriteLine("Negative numbers count is: " + countNegative);
                            exitFromLoop = true;
                            break;

                        case 2:
                            Console.WriteLine("Sorting matrix elements line by line");
                            Console.WriteLine("2");
                            int[,] sortArray;
                            int temp;

                            
                            for (int i = 0; i < array.Length - 1; i++)

                              
                                for (int j = i + 1; j < array.Length -1; j++)

                                   
                                    if (array[i] < array[j])
                                    {

                                        temp = array[i];
                                        array[i] = array[j];
                                        array[j] = temp;
                                    }

                            
                            foreach (int value in array)
                            {
                                Console.Write(value + " ");
                            }
                                }
                            }


                            exitFromLoop = true;
                            break;

                        case 3:
                            Console.WriteLine("Invert matrix elements line by line");
                            Console.WriteLine("3");
                            exitFromLoop = true;
                            break;

                        case 0:
                            exitFromLoop = true;
                            break;
                    }
                }
            }
        }
    }
}
