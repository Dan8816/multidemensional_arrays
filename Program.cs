using System;

namespace multi_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[10,10];
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("");
                    for (int j = 0; j < 10; j++)
                    {
                        array2D[i,j] = (i+1)*(j+1);
                        Console.WriteLine(array2D[i,j]);
                    };
                };
            };
        }
    }
}
