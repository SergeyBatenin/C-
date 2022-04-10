using System;
using System.Linq;
class Program
{
    static void Main()
    {
        int rowsTriangle = 17;
        int[][] array = new int[rowsTriangle][];
        array[0] = new int[1] { 1 };

        for (int i = 1; i < array.Length; i++)
        {
            array[i] = new int[i + 1];
            int rowLength = array[i].Length;

            for (int j = 0; j < rowLength; j++)
            {
                if (j == 0 || j == rowLength - 1)
                {
                    array[i][j] = 1;
                
                }
                else
                {
                    array[i][j] = array[i - 1][j - 1] + array[i - 1][j];
                }
            }
        }

        PrintArray(array);
    }

    static void PrintArray(int[][] array)
    {
        int length = array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            IEnumerable<string> space = Enumerable.Repeat("   ", (length - i));
            foreach (String str in space)
            {
                Console.Write(str);
            }
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(String.Format($"{array[i][j], 6}"));
            }
            Console.WriteLine();
        }
        Console.WriteLine("------------------------------------------------");
    }
}