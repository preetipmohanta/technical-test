namespace TechnicalTestCore
{
    internal class Summations
    {
        public static int SumOfNumbersFrom1TillNrAsInt(int maxNrAsInt)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int sum = 0;
          for (int i = 1; i <= maxNrAsInt; i++)
            {
                sum = sum + i;
            }

            return sum;
        }

        public static string SumOfNumbersFrom1TillNrAsString(string maxNrAsString)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            double maxNrAsInt = double.Parse(maxNrAsString);
            double sum = 0;
            for (double i = 1; i <= maxNrAsInt; i++)
            {
                sum = sum + i;
            }

            return sum.ToString();
            
            
        }
    }
}
