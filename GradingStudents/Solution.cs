namespace GradingStudents
{
    class Result
    {

        /*
         * Complete the 'gradingStudents' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts INTEGER_ARRAY grades as parameter.
         */
        public static List<int> gradingStudents(List<int> grades)
        {
            int multipleOfFive;

            // foreach(int grade in grades){
            //     multipleOfFive = (grade / 5 + 1) * 5;

            //     if(multipleOfFive >= 40){
            //         if(multipleOfFive - grade < 3){
            //             grade = multipleOfFive;
            //         }
            //     }
            // }

            for (int i = 0; i < grades.Count(); i++)
            {
                multipleOfFive = (grades[i] / 5 + 1) * 5;

                if (multipleOfFive >= 40)
                {
                    if (multipleOfFive - grades[i] < 3)
                    {
                        grades[i] = multipleOfFive;
                    }
                }
            }

            return grades;
        }
    }

    internal class Solution
    {
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades);

            string res = string.Join(" ", result);
            Console.WriteLine(res);
            //textWriter.WriteLine(String.Join("\n", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}