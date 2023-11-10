namespace TimeConversion
{
    class Result
    {
        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */
        public static string timeConversion(string s)
        {
            var timeSplit = s.Split(':');
            string amOrPm = timeSplit[2].Substring(2);
            string seconds = timeSplit[2].Substring(0, 2);
            string time24hrs = string.Empty;

            if (amOrPm.ToUpper() == "AM")
            {
                if (timeSplit[0] == "12" && Convert.ToInt32(timeSplit[1]) >= 0)
                {
                    time24hrs = $"00:{timeSplit[1]}:{seconds}";
                }
                else
                {
                    time24hrs = $"{timeSplit[0]}:{timeSplit[1]}:{seconds}";
                }
            }
            else
            {
                if (Convert.ToInt32(timeSplit[0]) == 12)
                {
                    time24hrs = $"{timeSplit[0]}:{timeSplit[1]}:{seconds}";
                }
                else
                {
                    time24hrs = $"{Convert.ToInt32(timeSplit[0]) + 12}:{timeSplit[1]}:{seconds}";
                }
            }

            return time24hrs;
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}