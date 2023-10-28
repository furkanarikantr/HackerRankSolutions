﻿namespace ArrayDs
{
    class Result
    {
        /*
         * Complete the 'reverseArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static List<int> reverseArray(List<int> a)
        {
            a.Reverse();
            return a;
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> res = Result.reverseArray(arr);

            string result = string.Join(" ", res);
            Console.WriteLine(result);
            //textWriter.WriteLine(String.Join(" ", res));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

