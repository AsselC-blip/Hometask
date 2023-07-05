namespace InventoryManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


namespace InventoryManagementApp
    {
        class Program
        {
            static void Main(string[] args)
            {
                Inventory inventory = new Inventory();

                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Добавить продукт");
                    Console.WriteLine("2. Показать все продукты");
                    Console.WriteLine("3. Показать стоимость инвентаря");
                    Console.WriteLine("4. Выход");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddProduct(inventory);
                            break;
                        case "2":
                            ShowProducts(inventory);
                            break;
                        case "3":
                            ShowInventoryValue(inventory);
                            break;
                        case "4":
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void AddProduct(Inventory inventory)
            {
                Console.WriteLine("Введите название продукта:");
                string name = Console.ReadLine();

                Console.WriteLine("Введите цену продукта:");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите количество продукта:");
                int quantity = Convert.ToInt32(Console.ReadLine());

                // Создаем новый объект Product и добавляем его в инвентарь
                Product product = new Product(name, price, quantity);
                inventory.AddProduct(product);

                Console.WriteLine("Продукт успешно добавлен!");
            }

            static void ShowProducts(Inventory inventory)
            {
                if (inventory.GetProductCount() == 0)
                {
                    Console.WriteLine("Нет доступных продуктов.");
                }
                else
                {
                    Console.WriteLine("Список продуктов:");
                    foreach (Product product in inventory.GetProducts())
                    {
                        Console.WriteLine($"Название: {product.Name}, Цена: {product.Price}, Количество: {product.Quantity}");
                    }
                }
            }

            static void ShowInventoryValue(Inventory inventory)
            {
                double value = inventory.GetInventoryValue();
                Console.WriteLine($"Стоимость инвентаря: {value}");
            }
        }

        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, double price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }
        }

        class Inventory
        {
            private List<Product> products;

            public Inventory()
            {
                products = new List<Product>();
            }

            public void AddProduct(Product product)
            {
                products.Add(product);
            }

            public List<Product> GetProducts()
            {
                return products;
            }

            public int GetProductCount()
            {
                return products.Count;
            }

            public double GetInventoryValue()
            {
                double value = 0;
                foreach (Product product in products)
                {
                    value += product.Price * product.Quantity;
                }
                return value;
            }
        }
    }

}
    
