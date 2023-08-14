namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            Console.WriteLine("Press enter when you are ready to play!");
            int matchesLeft = 7;
            while(true)
            {
                Console.WriteLine("Input how many matches you wanna take (1,2,3) and press enter");
                if(Convert.ToInt16(Console.ReadLine()) == 1 || Convert.ToInt16(Console.ReadLine()) == 2 || Convert.ToInt16(Console.ReadLine()) == 3)
                matchesLeft = matchesLeft - Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}