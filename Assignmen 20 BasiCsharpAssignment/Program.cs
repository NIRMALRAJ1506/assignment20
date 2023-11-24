using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen_20_BasiCsharpAssignment
{
    public class Fact
    {
        int fact = 1;
        public void CalculateFactorial(int num)
        {
            if (num >= 1)
            {
                fact = fact * num;
                Console.WriteLine("Intermediate factorial for " + (num - 1) + " is: " + fact);
                num--;                
                CalculateFactorial(num);
                
            }
            else
            {
                fact = 1;

            }
            

        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Fact fact = new Fact();
            string choice;
            do
            {
                Console.WriteLine("Select an operation");
                Console.WriteLine("1.Print Hello World");
                Console.WriteLine("2.Variables and Input");
                Console.WriteLine("3.Basic Arithmetic");
                Console.WriteLine("4.Control Structures");
                Console.WriteLine("5.Loops");
                Console.WriteLine("6.Arrays");
                Console.WriteLine("7.Methods");
                Console.WriteLine("8.Exception Handling");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Hello World!");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter your name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Hello," + name + "!");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter first number");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter second number");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Addition of two numbers is: " + (a + b));
                            Console.WriteLine("Subtraction of two numbers is: " + (a - b));
                            Console.WriteLine("Multiplication of two numbers is: " + (a * b));
                            Console.WriteLine("Division of two numbers is: " + (a / b));
                            Console.WriteLine("Modulus of two numbers is: " + (a % b));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter a number to check odd or even");
                            int a = int.Parse(Console.ReadLine());
                            if (a % 2 == 0)
                            {
                                Console.WriteLine("The given number is even");
                            }
                            else
                            {
                                Console.WriteLine("The given number is odd");
                            }
                            break;
                        }
                    case 5:
                        {
                            int n = 10;
                            Console.WriteLine("First 10 Numbers");
                            for (int i = 1; i <= n; i++)
                            {
                                Console.WriteLine(i);
                            }
                            break;
                        }
                    case 6:
                        {
                            int[] arr = new int[5];
                            int sum = 0;
                            Console.WriteLine("Enter the array elements");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = int.Parse(Console.ReadLine());
                            }
                            for (int i = 0; i < arr.Length; i++)
                            {
                                sum += arr[i];
                            }
                            Console.WriteLine("Sum of the elements is: " + sum);
                            Console.WriteLine("Average of Sum of elements is: " + sum / arr.Length);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Enter a positive number");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Factorial of the Number");
                            fact.CalculateFactorial(a);
                            
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Enter your age");
                            string a = Console.ReadLine();
                            if (int.TryParse(a, out int b))
                            {
                                if (b <= 18)
                                {
                                    Console.WriteLine("Minor");
                                }
                                else if (b > 18 && b < 65)
                                {
                                    Console.WriteLine("Adult");
                                }
                                else if (b >= 65)
                                {
                                    Console.WriteLine("Senior");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter Valid Age");
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Option");
                            break;
                        }

                }
                Console.WriteLine("D you wanna continue? if yes press y");
                choice = Console.ReadLine();
            } while (choice == "y");
        }
    }
}
