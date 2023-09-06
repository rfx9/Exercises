﻿namespace P11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (product)
                    {
                        case "banana":
                            price = 2.5;
                            break;
                        case "apple":
                            price = 1.2;
                            break;
                        case "orange":
                            price = 0.85;
                            break;
                        case "grapefruit":
                            price = 1.45;
                            break;
                        case "kiwi":
                            price = 2.7;
                            break;
                        case "pineapple":
                            price = 5.5;
                            break;
                        case "grapes":
                            price = 3.85;
                            break;
                        default:
                            Console.WriteLine("error");
                            return;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (product)
                    {
                        case "banana":
                            price = 2.7;
                            break;
                        case "apple":
                            price = 1.25;
                            break;
                        case "orange":
                            price = 0.9;
                            break;
                        case "grapefruit":
                            price = 1.6;
                            break;
                        case "kiwi":
                            price = 3;
                            break;
                        case "pineapple":
                            price = 5.6;
                            break;
                        case "grapes":
                            price = 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            return;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }

            double cost = price * quantity;

            Console.WriteLine($"{cost:F2}");
        }
    }
}