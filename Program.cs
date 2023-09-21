using PriceTag.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace PriceTagOk {

    internal class Program {

        static void Main(string[] args) {

            Console.Write("Number of products: ");
            int N = int.Parse(Console.ReadLine());

            List<Product> Pd = new List<Product>();

            for (int i = 0; i < N; i++) {
                Console.WriteLine($"Data number #{i + 1}");
               
                Console.Write("Commom, used or imported? (c/u/i)");
                char quest = char.Parse(Console.ReadLine());
                

                if (quest == 'c') {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Pd.Add(new Product(name, price));
                }
                else if (quest == 'u') {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Manufacture Date: (DD/MM/YYYY)");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Pd.Add(new UsedProduct(name, price, date));

                }
                else if (quest == 'i') {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Custem Fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Pd.Add(new ImportedProduct(name, price, fee));
                    
                }
                else {
                    Console.WriteLine("Invalid option :(");
                    i -= 1;
                }
            }
            Console.WriteLine();
            foreach (Product product in Pd) {

                Console.WriteLine(product.PriceTag(), CultureInfo.InvariantCulture);
            }


        }
    }

}