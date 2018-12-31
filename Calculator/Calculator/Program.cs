using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static bool validateMenuSelection(string menuSelection)
        {
            bool isValid = true;
            switch(menuSelection)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    isValid = false;
                    break;
            }
            return isValid;
        }
        static void Main(string[] args)
        {
            double value1 = 0;
            double value2 = 0;
            double result = 0;
            string continueAgain = "N";
            string op = "";
            do
            {
                ShowMenu();
                string menuOption = Console.ReadLine();
               
                if (validateMenuSelection(menuOption))
                {
                    requestParameters(out value1, out value2);
                switch (menuOption)
                    {
                        case "1":
                            op = " + ";
                            result = Add(value1, value2);
                            break;
                        case "2":
                            op = " - ";
                            result = Substract(value1, value2);
                            break;
                        case "3":
                            op = " * ";
                            result = Multiply(value1, value2);
                            break;
                        case "4":
                            op = " / ";
                            result = Divide(value1, value2);
                            break;
                        default:
                            Console.WriteLine("Invalid menu option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Menu Option.");
                }
                Console.WriteLine(value1 + op + value2 + " = " + result);
                Console.WriteLine("Do you want to continue again (Y/N)?");
                continueAgain = Console.ReadLine();
                if (!validateContinueAgain(continueAgain))
                {
                    while (!validateContinueAgain(continueAgain))
                    {
                        Console.WriteLine("Invalid Response. Do you want to continue again (Y/N)?");
                        continueAgain = Console.ReadLine();
                    }
                }
            } while (!continueAgain.ToUpper().Equals("N"));
        }
        static bool validateContinueAgain(string continueAgain)
        {
            continueAgain = continueAgain.Trim().ToUpper();
            if (continueAgain.Equals("Y") || continueAgain.Equals("N"))
                return true;
            else
                return false;
        }
        static void requestParameters(out double value1, out double value2)
        {
            Console.WriteLine("Enter value 1: ");
            value1 = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter value 2: ");
            value2 = Convert.ToDouble(Console.ReadLine());
        }
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
        }
        static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        static double Substract(double value1, double value2)
        {
            return value1 - value2;
        }
            static double Multiply(double value1, double value2)
        {
            return value1 * value2;
        }
        static double Divide(double value1, double value2)
        {
            return value1 / value2;
        }
    }
}
