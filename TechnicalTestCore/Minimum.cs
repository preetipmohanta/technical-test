namespace TechnicalTestCore
{
    using System.Collections.Generic;

    internal class Minimum
    {
        public static int MinimumElementIn(List<int> intlist)
        {
            // Adapt the method body to make the corresponding unit test in 'TechnicalTestUnitTests' pass
            int minima = intlist[0];
 
            for (int i = 1; i < intlist.Count; i++)
            {
                if (intlist[i] < minima)
                { minima = intlist[i]; }
            }
            return minima;
        }
    }
}
