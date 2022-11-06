using System;

namespace P01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cnt = 1;
            bool isReady = false;
            //End condition will be never met
            for (int row = 1; row <= n; row++)
            {
                //For each row we have, we need to pass rowNumber columns
                for (int col = 1; col <= row; col++)
                {
                    //For each column
                    if (cnt > n)
                    {
                        //Pyramid ends
                        isReady = true;
                        break;
                    }

                    Console.Write($"{cnt} ");
                    cnt++;
                }

                //Always will be after the nested loop
                //Add cnt > n to remove the empty line
                if (isReady || cnt > n)
                {
                    //End the whole construction
                    break;
                }

                //Moves to the next row
                Console.WriteLine();
            }
        }
    }
}
