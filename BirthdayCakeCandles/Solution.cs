﻿namespace BirthdayCakeCandles
{
    class Result
    {
        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */
        public static int birthdayCakeCandles(List<int> candles)
        {
            int bigNumber = candles[0];
            int bigNumberCount = 0;

            foreach (int number in candles)
            {
                if (number > bigNumber)
                {
                    bigNumber = number;
                    bigNumberCount = 1;
                }
                else if (number == bigNumber)
                {
                    bigNumberCount += 1;
                }
            }

            return bigNumberCount;
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}