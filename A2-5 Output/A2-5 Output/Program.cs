namespace A2_5_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the program will output "1 2 3 4" over 4 rows using various Console.WriteLine methods

            // Output using only one WriteLine
            Console.WriteLine("1 2 3 4\n1 2 3 4\n1 2 3 4\n1 2 3 4");

            Console.WriteLine(); // used for spacing and readability

            // Output using four Console.Write statements
            Console.Write("1 2 3 4\n");
            Console.Write("1 2 3 4\n");
            Console.Write("1 2 3 4\n");
            Console.Write("1 2 3 4\n");

            Console.WriteLine(); // // used for spacing and readability

            //output using four variables and string interpolation
            string set1 = "1 2 3 4";
            string set2 = "1 2 3 4";
            string set3 = "1 2 3 4";
            string set4 = "1 2 3 4";

            Console.WriteLine($"{set1}\n{set2}\n{set3}\n{set4}");
        }
    }
}