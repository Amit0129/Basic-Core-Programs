namespace Power_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            //Console.WriteLine("Hello, World!");
            Console.Write("Input a number : ");
            number = Convert.ToInt32(Console.ReadLine());

            double end = Math.Pow(2, number);
            for (int i = 1; i < number; i++)
            {
                double sqr = Math.Pow(i, 2);
                if(sqr < end)
                {

                    Console.WriteLine(sqr);
                }
                else
                {
                    break;
                }

            }
        }
    }
}