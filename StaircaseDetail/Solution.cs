namespace StaircaseDetail
{
    class Result
    {
        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */
        public static void staircase(int n)
        {
            int length = n;
            int xCount = 1;
            int empty = length - xCount; // 4 - 3 - 2 - 1

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (empty > 0)
                    {
                        Console.Write(" ");
                        empty -= 1;
                    }
                    else
                    {
                        Console.Write("#");

                    }
                }
                xCount += 1;
                empty = length - xCount;
                Console.Write("\n");
            }
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }
    }
}