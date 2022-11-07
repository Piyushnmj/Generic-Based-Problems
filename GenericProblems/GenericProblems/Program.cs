namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Based Problems");

            string output = MaxNumberCheck.MaxIntegerNumber("Peach", "Apple", "Banana");
            Console.WriteLine("\nMax string word is: " + output);
        }
    }
}