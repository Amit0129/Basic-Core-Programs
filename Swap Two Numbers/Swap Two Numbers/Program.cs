namespace Swap_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Emter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}