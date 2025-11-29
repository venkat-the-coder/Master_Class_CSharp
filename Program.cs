namespace FirstProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heelo!");
            Console.WriteLine("What to do?");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            string userInput = Console.ReadLine();

            Console.WriteLine(userInput == "A");
            Console.WriteLine($"You selected {userInput}");

            Console.ReadKey();
           
            
        }
    }
}