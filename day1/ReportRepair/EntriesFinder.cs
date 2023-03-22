using System;
using System.Linq;
namespace ReportRepair
{
    public class EntriesFinder
    {
        public int[] GetEntriesThatSum2020(int[] entries)
        {
            var result = new int[2];

            if (entries.Length > 1)
            {
                var first = 0;
                var second = 0;
                for (int i = 0; i < entries.Length && result[0] == 0 && result[1] == 0 ; i++)
                {
                    first = Math.Abs(entries[i] - 2020);
                    second = entries.First(x => x == first);
                    if (second > 0)
                    {
                        result[0] = entries[i];
                        result[1] = second;
                    }
                }
                return result;
            }
            return new int[0];
        }

    }
}
