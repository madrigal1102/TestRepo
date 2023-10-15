namespace A2_4_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int sum;
            int product;
            int difference;
            int quotient;

            // prompt user for first integer
            Console.WriteLine("Enter first integer: "); 
            number1 = int.Parse(Console.ReadLine());

            // promt user for second integer
            Console.WriteLine("Enter second integer: "); 
            number2 = int.Parse(Console.ReadLine());
            
            // display sum
            sum = number1 + number2;
            Console.WriteLine($"The sum is {sum}");

            // display product
            product = number1 * number2;
            Console.WriteLine($"The product is {product}");

            // display difference 
            difference = number1 - number2;
            Console.WriteLine($"The difference is {difference}");

            // display quotient
            quotient = number1 / number2;
            Console.WriteLine($"The quotient is {quotient}");
        }
    }
}