using System;

namespace CalculatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            char operation;

            double num1, num2;

            


            Console.WriteLine("Enter the Operater(+,-,*/)");
            operation = Console.ReadLine()[0];

            Console.WriteLine("Enter the two number one by one");
            num1= Convert.ToDouble( Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
             
            switch (operation)
            {
                case '+':
                    Console.WriteLine(Addition(num1,num2));
                    break;

                case '-':
                    Console.WriteLine(Subtraction(num1, num2));
                    
                    break;


                case '*':
                    Console.WriteLine(Multiplication(num1, num2));                    
                    break;


                case '/':

                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero sitution, Division is not possible.....");
                    else
                        Console.WriteLine(Division(num1, num2));                        
                    break;

                default:
                    Console.WriteLine("User enters invalid Operator ....");
                    break;

            }
            Console.WriteLine("PressAny key to Exit the progrem");
            Console.ReadKey();
        }

        static double Addition(double num1,double num2)
        {
            double num3;
            num3 = num1 + num2;
            return num3;
        }
        static double Subtraction(double num1, double num2)
        {
            double num3;
            num3 = num1 - num2;
            return num3;
        }
        static double Multiplication(double num1, double num2)
        {
            double num3;
            num3 = num1 * num2;
            return num3;
        }
        static double Division(double num1, double num2)
        {
            double num3;
            num3 = num1 / num2;
            return num3;
        }
    }
}
