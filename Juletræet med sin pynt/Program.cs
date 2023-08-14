namespace Juletræet_med_sin_pynt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool solidGreen = false;
            bool emptyRow = false;
            char[,] christmasTree = new char[15,15];
            int offset = christmasTree.GetLength(1) / 2;
            for(int rows = 0; rows < christmasTree.GetLength(0); rows++)
            {
                if (rows % 2 == 0)
                {
                    solidGreen = !solidGreen;
                }
                if (rows % 2 == 1)
                {
                    emptyRow = !emptyRow;
                }
                for (int cols = 0; cols < christmasTree.GetLength(1); cols++)
                {
                    /*if(solidGreen)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    } */

                }
            }
        }
    }
}