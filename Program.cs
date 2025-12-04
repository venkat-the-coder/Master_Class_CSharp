namespace FirstProgram
{
    public class Program
    {

        public static void ToDOApp()
        {

            var toDos = new List<string>();
            bool isUserExit = false;
            do
            {
                Console.WriteLine("Heelo!");
                Console.WriteLine("What to do?");
                Console.WriteLine("[S]ee all TODOs");
                Console.WriteLine("[A]dd a TODO's");
                Console.WriteLine("[R]emove a TODO's");
                Console.WriteLine("[E]xit");

                string userSelectedOption = Console.ReadLine();


                if (!string.IsNullOrEmpty(userSelectedOption) && userSelectedOption != "e" && userSelectedOption != "E")
                {

                    PerformOps(userSelectedOption, toDos);
                }
                else if (userSelectedOption == "e" || userSelectedOption == "E")
                {
                    Exit(out isUserExit);
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                }
            }
            while (!isUserExit);
        }

        static void PerformOps(string option, List<string> todos)
        {
            switch (option)
            {
                case "s":
                case "S":
                    SeeAllToDos(todos);
                    break;

                case "a":
                case "A":
                    AddToDos(todos);
                    break;

                case "r":
                case "R":
                    RemoveToDos(todos);
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }



        public static void SeeAllToDos(List<string> toDos)
        {
            if (!toDos.Any())
            {
                Console.WriteLine("No TODOs have been added yet., Kindly Add One");
                return;
            }

            int index = 1;
            foreach (string toDosItem in toDos)
            {
                Console.WriteLine($"{index}.{toDosItem}");
                index++;
            }
        }


        public static void AddToDos(List<string> toDos)
        {
            bool isAllUnique = false;
            var uniqueToDos = new List<string>();
            var nonUniqueToDos = new List<string>();

            while (!isAllUnique)
            {
                Console.WriteLine("Enter the TODO description or Enter the TODO description seperated by comma if have many:");

                var items = Console.ReadLine()?.Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (items != null && items.Any())
                {
                    foreach (var s in items)
                    {

                        if (toDos.Contains(s))
                        {
                            nonUniqueToDos.Add(s);
                        }
                        else
                        {
                            uniqueToDos.Add(s);
                        }
                    }

                    if (nonUniqueToDos.Any() && !uniqueToDos.Any())
                    {
                        Console.WriteLine("Entered All items are already present, Kindly Enter Unique One:");
                    }
                    else if (nonUniqueToDos.Any() && uniqueToDos.Any())
                    {
                        isAllUnique = true;
                        Console.WriteLine("Unique tasks below, Adding....:");
                        foreach (var s in uniqueToDos)
                        {
                            Console.WriteLine(s);
                            toDos.Add(s);
                        }

                        Console.WriteLine("Non-Unique tasks below ,Already Present:");
                        foreach (var s in nonUniqueToDos)
                        {
                            Console.WriteLine(s);
                        }
                    }
                    else
                    {
                        if (uniqueToDos.Count == items.Length)
                        {
                            Console.WriteLine("Adding all unique TODOs...");
                            foreach (var s in uniqueToDos)
                            {
                                toDos.Add(s);
                            }
                            isAllUnique = true;
                        }
                    }
                    uniqueToDos.Clear();
                    nonUniqueToDos.Clear();
                }
                else
                {
                    Console.WriteLine("The description cannot be empty.");
                }


            }

            Console.WriteLine("Current toDo's:");
            SeeAllToDos(toDos);
        }

        static void RemoveToDos(List<string> todos)
        {
            Console.WriteLine("Enter the toDo index to remove:");
            SeeAllToDos(todos);

            bool isParseSuccess = int.TryParse(Console.ReadLine(), out int number);
            if (isParseSuccess)
            {
                if (number < 1 || number > todos.Count)
                {
                    Console.WriteLine("Invalid Index, select within range");
                    return;
                }
                Console.WriteLine($"Follwing item is removed from todo :  {todos[number - 1]}");
                todos.RemoveAt(number - 1);
            }
        }
        static void Exit(out bool isUserExit)
        {
            isUserExit = true;
        }

        static void Main(string[] args)
        {

            ToDOApp();
        }
    }
}