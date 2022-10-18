namespace Alphabet_is_Vowel_or_Consonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter;
            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            letter = Convert.ToChar(Console.ReadLine().ToLower());
            switch (letter)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }



        }
    }
}