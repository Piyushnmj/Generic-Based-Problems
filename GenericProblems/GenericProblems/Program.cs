namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Problems");

            MaxNumberCheck<int> objint = new MaxNumberCheck<int>(11, 111, 1111, 11111);
            Console.WriteLine("\nMax integer number is: " + objint.MaxMethod());

            MaxNumberCheck<float> objfloat = new MaxNumberCheck<float>(1, 11, 111, 1111);
            Console.WriteLine("\nMax float number is: " + objfloat.MaxMethod());

            MaxNumberCheck<string> objstring = new MaxNumberCheck<string>("Apple", "Peach", "Banana", "Orange");
            Console.WriteLine("\nMax string word is: " + objstring.MaxMethod());
        }
    }
}