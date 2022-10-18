namespace Number_is_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num%2==0)
            {
                Console.WriteLine("The number " + num + " is even number");
            }
            else
            {
                Console.WriteLine("The number " + num + " is odd number");
            }
        }
    }
}