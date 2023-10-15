namespace A2_6_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            int radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"The diameter of the circle is: {2 * radius}");
            Console.WriteLine($"The circumference of the circle is: {2 * Math.PI * radius}");
            Console.WriteLine($"The area of the circle is: {Math.PI * radius * radius}");
        }
    }
}