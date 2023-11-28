namespace BetweenTwoSets
{
    class Result
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maxA = a.Max();
            var minmB = b.Min();
            var counter = 1;
            var multipleOfMaxA = maxA;

            while (multipleOfMaxA <= minmB)
            {
                var factorOfAll = true;

                foreach (var item in a)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maxA * counter;
            }

            return totalXs;
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);
            //textWriter.WriteLine(total);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}