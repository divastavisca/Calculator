using System;
using Operations;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMathematicalOperation operation = new Operation();
            var continueInput = true;
            while (continueInput)
            {
                Console.Write("Press..\n(1)Add\n(2)Subtract\n(3)Multiply\n(4)Divide\n(5)Exit");
                var input = Console.ReadLine();
                try
                {
                    var inputOperationChoice = int.Parse(input);
                    int num1, num2;
                    switch(inputOperationChoice)
                    {
                        case 1:
                            num1 = ReadNumber();
                            num2 = ReadNumber();
                            Console.WriteLine(operation.Add(num1, num2));
                            break;
                        case 2:
                            num1 = ReadNumber();
                            num2 = ReadNumber();
                            Console.WriteLine(operation.Subtract(num1, num2));
                            break;
                        case 3:
                            num1 = ReadNumber();
                            num2 = ReadNumber();
                            Console.WriteLine(operation.Multiply(num1, num2));
                            break;
                        case 4:
                            num1 = ReadNumber();
                            num2 = ReadNumber();
                            Console.WriteLine(operation.Divide(num1, num2));
                            break;
                        case 5:
                            continueInput = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Something went wrong..try again");
                }
            }
        }

        public static int ReadNumber()
        {
            int number = 0;
            var isValidInput = false;
            while(!isValidInput)
            {
                Console.WriteLine("Enter a number");
                var input = Console.ReadLine();
                isValidInput = int.TryParse(input, out number);
                if (!isValidInput)
                    Console.WriteLine("That was not an int");
            }
            return number;
        }
    }
}
