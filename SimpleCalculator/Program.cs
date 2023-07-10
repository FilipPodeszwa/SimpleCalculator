using System.Security.Cryptography.X509Certificates;

namespace SimpleCalculator
{
    internal class Program
    {
        
        static double Addiction(double num1, double num2) => num1 + num2;
        static double Subtraction(double num1, double num2) => num1 - num2;
        static double Multiplication(double num1, double num2) => num1 * num2;
        static double Division(double num1, double num2) => num1 / num2;
        static double Modulo(double num1, double num2) => num1 % num2;

        static bool Repeat()
        {
            bool again, repeat = false;
            do
            {
                again = false;
                Console.Write("Do you want use calculator again? [yes/no]: ");
                string choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice == "yes")
                {
                    repeat = true;
                }
                else if (choice == "no")
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again.\n");
                    again = true;
                }
            } while (again);
            return repeat;
        }
        static string Operator(string opMath)
        {
            string op;
            bool again;

            do
            {
                again = false;
                Console.Write($"Type an {opMath}: ");
                op = Console.ReadLine();
                if (op != "+" && op != "-" && op != "*" && op != "/" && op != "%")
                {
                    Console.WriteLine($"Invalid {opMath}, please try again.\n");
                    again = true;
                }
            } while (again);
            return op;
        }
        static double NumType(string numOrder)
        {
            double num;
            bool again;

            do
            {
                again = false;
                Console.Write($"Type a {numOrder} number: ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid number, please try again.\n");
                    again = true;
                }
            } while (again);
            return num;
        }

        // Main method
        static void Main(string[] args)
        {
            double num1, num2;
            string op;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to calculator!\n");
                Console.Write("Press any button to get started.");
                Console.ReadKey();
                Console.Clear();

                num1 = NumType("first");
                Console.Clear();
                Console.WriteLine("+ (Addiction)\n- (Subtraction)\n* (Multiplication)\n/ (Division)\n% (Remainder after division)\n");
                op = Operator("operator");
                Console.Clear();
                num2 = NumType("second");
                Console.Clear();

                switch (op)
                {
                    case "+":
                        Console.WriteLine($"Result: {Addiction(num1, num2)}\n");
                        break;
                    case "-":
                        Console.WriteLine($"Result: {Subtraction(num1, num2)}\n");
                        break;
                    case "*":
                        Console.WriteLine($"Result: {Multiplication(num1, num2)}\n");
                        break;
                    case "/":
                        Console.WriteLine($"Result: {Division(num1, num2)}\n");
                        break;
                    case "%":
                        Console.WriteLine($"Result: {Modulo(num1, num2)}\n");
                        break;
                    default:
                        Console.WriteLine("I don't know, how you got here. I thought I did everything right..\n");
                        break;
                }

            } while (Repeat());

            Console.WriteLine("\nThanks for using my calculator, you can press any key to close program.\n");
            Console.ReadKey();

        }
    }
}