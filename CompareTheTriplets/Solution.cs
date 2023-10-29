namespace CompareTheTriplets
{
    class Result
    {
        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int pAlice = 0;
            int pBob = 0;

            for (int i = 0; i < a.Capacity; i++)
            {
                if (a[i] > b[i])
                {
                    pAlice += 1;
                }
                else if (a[i] < b[i])
                {
                    pBob += 1;
                }
            }

            return new List<int> { pAlice, pBob };
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            string res = string.Join(" ", result);
            Console.WriteLine(res);

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}