namespace AVeryBigSum
{
    class Result
    {
        /*
         * Complete the 'aVeryBigSum' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY ar as parameter.
         */

        public static long aVeryBigSum(List<long> ar)
        {
            long sum = 0;
            foreach (long i in ar)
            {
                sum = sum + i;
            }
            return sum;
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.aVeryBigSum(ar);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}