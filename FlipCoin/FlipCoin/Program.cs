namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flip Coin and print percentage of Head and Tail");
            int noOfTime = 10;
            int head = 0;
            int tail = 0;
            for (int i = 1; i <= noOfTime; i++)
            {
                Random random = new Random();
                int coinCheck = random.Next(0, 2);
                if (coinCheck == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            Console.WriteLine(head);
            Console.WriteLine(tail);
            int headPer = (head/noOfTime)*100;
            int tailPer = (tail/noOfTime)*100;
            Console.WriteLine(" Persentage = " + headPer);
            Console.WriteLine("tail Persentage = " + tailPer);


        }
    }
}