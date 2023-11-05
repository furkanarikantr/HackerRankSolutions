namespace PlusMinus
{
    class Result
    {
        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static void plusMinus(List<int> arr)
        {
            int numberOfPositive = 0;
            int numberOfNegative = 0;
            int numberOfEqualToZero = 0;

            foreach (int item in arr)
            {
                if (item > 0)
                {
                    numberOfPositive += 1;
                }
                else if (item < 0)
                {
                    numberOfNegative += 1;
                }
                else
                {
                    numberOfEqualToZero += 1;
                }
            }

            double ratioOfPositive = Convert.ToDouble(numberOfPositive) / Convert.ToDouble(arr.Count());
            double ratioOfNMegative = Convert.ToDouble(numberOfNegative) / Convert.ToDouble(arr.Count());
            double ratioOfZero = Convert.ToDouble(numberOfEqualToZero) / Convert.ToDouble(arr.Count());

            Console.WriteLine(Math.Round(ratioOfPositive,6));
            Console.WriteLine(Math.Round(ratioOfNMegative,6));
            Console.WriteLine(Math.Round(ratioOfZero,6));
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}