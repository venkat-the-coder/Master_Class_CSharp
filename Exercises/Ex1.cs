using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_2.Exercises
{
    public class Ex1
    {

        public static int VariablesAndOperators()
        {
            int a = 5;
            int b = 10;
            int c = 3;

            int result = ((a + b) / c);

            return result;
        }

        public static void isSumLargerOrEqualTo17()
        {
            Console.WriteLine("Enter Number a:");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Number b:");
            int b = Convert.ToInt16(Console.ReadLine());

            bool isGreaterThan17 = (a + b) > 17;
            Console.WriteLine($"Sum of {a} and {b} is greater than 17 is {isGreaterThan17}");
        }

        public static void IfElseCheck()
        {
            Console.WriteLine("Enter the string to check:");
            var toCheckString = Console.ReadLine();

            if (toCheckString == "")
            {
                Console.WriteLine("User Enters Nothing");
            }
            else if (toCheckString?.Length > 0)
            {
                Console.WriteLine("Postive");
            }
            else if (toCheckString?.Length == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        //private void ScopeOfVariable()
        //{
        //    var global = "global"; //global scope
        //    if(global == " global")
        //    {
        //        int num = 5; //local scope 
        //        Console.WriteLine("global is global", num);
        //        if (num > 0) {
        //            Console.WriteLine(num + "> 0"); //OUTER SCOPE 
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(global);
        //        Console.WriteLine(num); // out of context
        //    }
        //}

        bool IsValid() //return Types 
        {
            return 10 > 5;
        }

        public static int AbsoluteValueOfSum(int value1, int value2)
        {
            var result = value1 + value2;

            if (result < 0)
            {
                return result * -1;
            }
            return result;
        }

        public static int TryParseString()
        {
            Console.WriteLine("Enter a Integer string");
            var number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                return number;
            }
            return 0;
        }

        // calculator assignment 

        public static void Calc()
        {
            Console.WriteLine("Hello!, Welcome to Calc");
            Console.WriteLine("Please enter following input to necessary ops");
            Console.WriteLine("Enter the Input1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Input2");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Option:");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");

            string option = Console.ReadLine();

            var result = PerformOperationSwitchExpression(number1, number2, option);

            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
        }

        private static string PerformOperation(int num1, int num2, string opt)
        {
            if (opt == "A" || opt == "a")
            {
                return $"{num1} + {num2} = {num1 + num2}";
            }
            else if (opt == "S" || opt == "s")
            {
                return $"{num1} - {num2} = {num1 - num2}";
            }
            else if (opt == "M" || opt == "m")
            {
                return $"{num1} * {num2} = {num1 * num2}";
            }
            else
            {
                return "Invalid Option";
            }
        }


        private static string PerformOperationSwitch(int num1, int num2, string opt)
        {
            switch (opt)
            {
                case "A":
                case "a":
                    return $"{num1} + {num2} = {num1 + num2}";
                case "S":
                case "s":
                    return $"{num1} - {num2} = {num1 - num2}";
                case "M":
                case "m":
                    return $"{num1} * {num2} = {num1 * num2}";
                default:
                    return "Invalid Option";
            }
        }

        /* Pattern Matching with Switch Expression */

        /* Constant Patten Matching */
        string GetCategory(int number) => number switch
        {
            1 => "One",
            2 => "Two",
            _ => "Other"
        };
        // Console.WriteLine(GetCategory(2)); // Output: Two


        /* Relational Pattern Matching (>=, <=) */
        string GetGrade(int score) => score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };
        // Console.WriteLine(GetGrade(85)); // Output: B

        /* Type Pattern Matching */
        string DescribeObject(object obj) => obj switch
        {
            int n => $"It's an integer: {n}",
            string s => $"It's a string: {s}",
            bool b => $"It's a boolean: {b}",
            _ => "Unknown type"
        };
        // Console.WriteLine(DescribeObject(42));        // Output: It's an integer: 42
        // Console.WriteLine(DescribeObject("Hello"));   // Output: It's a string: Hello
        // Console.WriteLine(DescribeObject(true));      // Output: It's a boolean: True

        /* Property Pattern Matching (Matching Object Properties) */
       

        string GetDiscount(Person person) => person switch
        {
            { Age: < 12 } => "Child Discount",
            { Age: >= 65 } => "Senior Discount",
            _ => "Regular"
        };
        //Console.WriteLine(GetDiscount(new Person { Name = "Alice", Age = 10 })); // Output: Child discount
        //Console.WriteLine(GetDiscount(new Person { Name = "Bob", Age = 70 }));   // Output: Senior discount





        private static string PerformOperationSwitchExpression(int num1, int num2, string opt)
        {
            return opt switch
            {
                "A" or "a" => $"{num1} + {num2} = {num1 + num2}",
                "S" or "s" => $"{num1} - {num2} = {num1 - num2}",
                "M" or "m" => $"{num1} * {num2} = {num1 * num2}",
                _ => "Invalid Option"
            };
        }


        string Revision(string str) => str switch
        {
            "a" => "it is string",
            "b" => "it is string"
        }; 


        private void SimpleWhileLoop()
        {
            int number = 0;

            while(number < 10)
            {
                number++;
                Console.WriteLine(number);
            }
        }

        private void SimpleWhileLoopInfinite()
        {
            int number = 11;

            while (number > 10)
            {
                number++;
                Console.WriteLine(number);
            }
        }
        public static void CalculateSumOfNumbers()
        {
            bool isUserExit = false;
            while (!isUserExit)
            {
                Console.WriteLine("Enter num1:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter num2:");
                int num2 = int.Parse(Console.ReadLine());
                int sum = 0;
                if (num1 == num2)
                {
                    Console.WriteLine("Both are equal");
                    Console.WriteLine($"Result: {num1}");
                }
                else if (num2 < num1)
                {
                    Console.WriteLine("Num 2 cannot be less than Num1");
                    Console.WriteLine("Result: 0");
                }
                else
                {
                    isUserExit = true;
                    while (num1 <= num2)
                    {
                        sum = sum + num1;
                        Console.WriteLine($"Now sum is {sum}");
                        num1++;
                    }

                    Console.WriteLine($"Final sum: {sum}");
                }
                Console.WriteLine("\nDo you want to calculate again? (yes/no):");
                string response = Console.ReadLine()?.ToLower();
                if (response == "no" || response == "n")
                {
                    isUserExit = true;
                }
            }
        }


        public static void LengthOfRepeatedCharc()
        {
            bool isUserExit = false;
            string letter = "";
            do
            {
                Console.WriteLine("Enter Charc to repeate");
                string c = Console.ReadLine();
                Console.WriteLine("Enter Number of times to repeate");
                int r = int.Parse(Console.ReadLine());
                letter = c; 

                for (int i = 1; i < r; i++)
                {
                    letter += c;
                }
                Console.WriteLine($"{letter}");

                Console.WriteLine("\nDo you want to repeate charc again? (yes/no):");
                string response = Console.ReadLine()?.ToLower();
                if (response == "no" || response == "n")
                {
                    isUserExit = true;
                }
            }
            while (!isUserExit);
        }


        public static void Factorial()
        {
            Console.WriteLine("Enter number to find fact:");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine($"{0!} is 1");
                return;
            }

            int fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"factorial of {num} is {fact}");
        }


        private static void CheckDigit()
        {
            Console.WriteLine("Enter the string");
            string number = Console.ReadLine();

            if(!string.IsNullOrEmpty(number) && number.All(char.IsDigit))
            {
                int num = int.Parse(number);    
            }

        }

        // nested loops
        private static void NestedForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{i}{j}");
                }
            }
        }

        // arrays
        private static void ArrayOps()
        {
            int[] arr = new int[10];
            int[] arr2 = new int[] { 1, 2, 3, 4, 5 };


            Console.WriteLine("last element at arr 1", arr[^1]);
            Console.WriteLine("last second element at arr 2", arr[^2]);

            for(int i = 0;i < arr2.Length;i++)
            {
                Console.WriteLine(arr2[i]);
            }

            for (int i = 0; i < arr2.Length; i++) //reverse array
            {
                Console.WriteLine(arr2[^i]);
            }
        }


        static void Main(string[] args)
        {
            // Console.WriteLine(VariablesAndOperators());
            // isSumLargerOrEqualTo17();
            //Calc();
            //CalculateSumOfNumbers();
            //LengthOfRepeatedCharc();
            Factorial();
            Console.ReadKey();
        }

    }
}

class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}
