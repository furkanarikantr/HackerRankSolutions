namespace BreakingTheRecords
{
    class Result
    {
        /*
         * Complete the 'breakingRecords' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY scores as parameter.
         */

        public static List<int> breakingRecords(List<int> scores)
        {
            int selectedScore = scores[0];
            int lowestScore = selectedScore;
            int highestScore = selectedScore;

            int totalHightScore = 0;
            int totalLowScore = 0;

            foreach (int score in scores)
            {
                selectedScore = score;
                if (selectedScore < lowestScore)
                {
                    lowestScore = selectedScore;
                    totalLowScore += 1;
                }
                else if (selectedScore > highestScore)
                {
                    highestScore = selectedScore;
                    totalHightScore += 1;
                }
            }

            return new List<int> { totalHightScore, totalLowScore };
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Result.breakingRecords(scores);
            string res = string.Join(" ", result);

            Console.WriteLine(res);
            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}