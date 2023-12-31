﻿namespace Mini_MaxSum
{
    class Result
    {
        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static void miniMaxSum(List<int> arr)
        {
            //int temp = 0;
            //int minSum = arr[0];
            //int maxSum = 0;

            //for (int i = 0; i < arr.Count(); i++)
            //{
            //    for (int j = i + 1; j < arr.Count(); j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}


            //for (int i = 1; i < arr.Count(); i++)
            //{
            //    maxSum += arr[i];
            //}

            //for (int i = 0; i < arr.Count() - 1; i++)
            //{
            //    minSum += arr[i];
            //}

            //Console.WriteLine(minSum + " " + maxSum);

            arr.Sort((a, b) => a.CompareTo(b));

            long totalSum = 0;
            long maxArr = arr.Max();
            long minArr = arr.Min();

            for (int i = 0; i < arr.Count(); i++)
            {
                totalSum += arr[i];
            }

            Console.WriteLine((totalSum - maxArr) + " " + (totalSum - minArr));
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}