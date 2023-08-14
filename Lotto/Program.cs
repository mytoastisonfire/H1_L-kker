using System.Security.Cryptography;

namespace Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            int[] lottoNumber = new int[7];
            Console.WriteLine("Your lotto numbers are: ");
            for (int i = 0; i < 7; i++)
            {
                while(true)
                {
                    int nextNumber = rng.Next(1, 37);
                    if (lottoNumber.Contains(nextNumber))
                    {
                        continue;
                    }
                    else
                    {
                        lottoNumber[i] = nextNumber;
                        break;
                    }
                }
            }
            Array.Sort(lottoNumber);
            for (int i = 0; i < 7; i++)
            {
                Console.Write(lottoNumber[i] + " ");
                Thread.Sleep(2000);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            int joker = rng.Next(1, 37);
            Console.Write("\r\nAnd your joker is: " + joker);
        }
    }
}