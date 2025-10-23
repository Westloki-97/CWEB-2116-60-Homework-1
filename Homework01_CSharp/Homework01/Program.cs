using System;

namespace Homework01
{
    /// <summary>
    /// CWEB 2116-60 Application Design I - HOMEWORK 01
    /// Implements output statements, comments, variables, constants, typecasting, if-else, and switch.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== C# Homework 01 ===");
            Console.WriteLine();

            // ---------------------------
            // Task 1: Output Statements
            // ---------------------------
            // Single-line comment: This prints name and favorite color.
            Console.WriteLine("[Task 1] Output Statements");
            string myName = "William Schneider"; // replace if desired
            string favoriteColor = "Blue";
            Console.WriteLine($"Your name: {myName}");
            Console.WriteLine($"Your favorite color: {favoriteColor}");
            Console.WriteLine();

            /* 
             * Task 2: Comments
             * Multi-line comment: We are demonstrating comment styles.
             */

            /// <remarks>
            /// Documentation comment example for Task 2.
            /// </remarks>
            Console.WriteLine("[Task 2] Comments added in source code (single-line, multi-line, documentation).");
            Console.WriteLine();

            // --------------------------------
            // Task 3: Variables and Data Types
            // --------------------------------
            Console.WriteLine("[Task 3] Variables and Data Types");
            string firstName = "Alex";
            long cityPopulation = 4299543L;
            double tempCelsius = 21.6;
            bool isStudent = true;
            Console.WriteLine($"First name (string): {firstName}");
            Console.WriteLine($"City population (long): {cityPopulation}");
            Console.WriteLine($"Temperature (double, °C): {tempCelsius}");
            Console.WriteLine($"Is student? (bool): {isStudent}");
            Console.WriteLine();

            // ---------------------
            // Task 4: Constants + π
            // ---------------------
            Console.WriteLine("[Task 4] Constants and Area of Circle");
            const double PI = 3.14159; // constant for π
            // Note: 'radius' is a variable; 'PI' is a constant
            double radius = 5.0;
            double area = PI * Math.Pow(radius, 2);
            Console.WriteLine($"Given radius = {radius}, Area = π * r^2 = {area}");
            Console.WriteLine();

            // -------------------------------------------
            // Task 5: Typecasting and if-else (vote check)
            // -------------------------------------------
            Console.WriteLine("[Task 5] Typecasting and if-else");
            Console.Write("Enter your name: ");
            string nameInput = Console.ReadLine() ?? "";
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine() ?? "0";

            // Typecast/parse user input
            int age;
            bool parsed = int.TryParse(ageInput, out age);
            if (!parsed)
            {
                Console.WriteLine("Invalid age entered. Assuming age = 0.");
                age = 0;
            }
            if (age >= 18)
            {
                Console.WriteLine($"{nameInput}, you are eligible to vote.");
            }
            else
            {
                Console.WriteLine($"{nameInput}, you are NOT eligible to vote.");
            }
            Console.WriteLine();

            // -----------------------------------------
            // Task 6: Switch Statement (Calculator menu)
            // -----------------------------------------
            Console.WriteLine("[Task 6] Switch Statement Calculator");
            Console.Write("Enter number1: ");
            string n1 = Console.ReadLine() ?? "0";
            Console.Write("Enter number2: ");
            string n2 = Console.ReadLine() ?? "0";

            double number1, number2;
            if (!double.TryParse(n1, out number1))
            {
                Console.WriteLine("Invalid number1, set to 0.");
                number1 = 0.0;
            }
            if (!double.TryParse(n2, out number2))
            {
                Console.WriteLine("Invalid number2, set to 0.");
                number2 = 0.0;
            }

            Console.WriteLine("Choose operation: 1=Addition, 2=Subtraction, 3=Multiplication, 4=Division");
            Console.Write("Enter choice (1-4): ");
            string choiceInput = Console.ReadLine() ?? "1";
            int choice;
            if (!int.TryParse(choiceInput, out choice))
            {
                Console.WriteLine("Invalid choice, defaulting to Addition (1).");
                choice = 1;
            }

            double result;
            switch (choice)
            {
                case 1:
                    result = number1 + number2;
                    Console.WriteLine($"Result: {number1} + {number2} = {result}");
                    break;
                case 2:
                    result = number1 - number2;
                    Console.WriteLine($"Result: {number1} - {number2} = {result}");
                    break;
                case 3:
                    result = number1 * number2;
                    Console.WriteLine($"Result: {number1} * {number2} = {result}");
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Result: {number1} / {number2} = {result}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please run again and choose between 1 and 4.");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("=== End of Homework 01 ===");
        }
    }
}
