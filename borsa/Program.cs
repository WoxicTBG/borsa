using System;
using System.Text;

namespace borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal euroCourse = 1.94M;
            decimal pricePerVegetables = 0;
            decimal pricePerFruits = 0;
            int vegetablesQuantity = 0;
            int fruitsQuantity = 0;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Цена за килограм на зеленчуци: ");
            pricePerVegetables = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Цена за килограм на плодове: ");
            pricePerFruits = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Общи килограми на зеленчуците: ");
            vegetablesQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Общи килограми на плодовете: ");
            fruitsQuantity = int.Parse(Console.ReadLine());
            decimal vegetablesPrice = (vegetablesQuantity * pricePerVegetables) / euroCourse;
            decimal fruitsPrice = (fruitsQuantity * pricePerFruits) / euroCourse;
            Console.WriteLine($"Обща цена на зеленчуците: {vegetablesPrice:0.00}" +
                $"\nОбща цена на плодовете: {fruitsPrice:0.00}");
            


        }
    }
}
