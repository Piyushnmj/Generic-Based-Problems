namespace GenericProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generic Based Problems");

            MaxNumberCheck objMaxNumber = new MaxNumberCheck();

            int output1 = objMaxNumber.MaxNumber<int>(11, 111, 1111);
            Console.WriteLine("\nMax integer number is: " + output1);

            float output2 = objMaxNumber.MaxNumber<float>(1, 11, 111);
            Console.WriteLine("\nMax float number is: " + output2);

            string output3 = objMaxNumber.MaxNumber<string>("Apple", "Peach", "Banana");
            Console.WriteLine("\nMax string word is: " + output3);
        }
    }
}