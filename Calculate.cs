// Ignore Spelling: Linq

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Statistics;

namespace PortaOne
{
    internal static class Calculate
    {
        public static int FindMinNumber(List<int> ints)
        {
            return ints.Min();
        }

        public static int FindMaxNumberLinq(List<int> ints)
        {
            return ints.Max();
        }

        public static int FindMaxNumberFor(List<int> ints)
        {
            int result = int.MinValue;

            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] > result)
                    result = ints[i];
            }
            return result;
        }

        public static double FindAverageNumber(List<int> ints)
        {
            return ints.Average();
        }

        public static double FindMedian(List<double> ints)
        {
            return ints.Median();
        }

        public static List<int> FindLongestIncreasingSequence(List<int> ints)
        {
            var longest = new List<int>();
            var temp = new List<int>() { ints[0] };

            for (int i = 1; i < ints.Count; i++)
            {
                if (ints[i] > temp[^1])
                {
                    temp.Add(ints[i]);
                }
                else
                {
                    if (temp.Count > longest.Count)
                    {
                        longest = new List<int>(temp);
                    }
                    temp.Clear();
                    temp.Add(ints[i]);
                }
            }
            if (temp.Count > longest.Count)
            {
                longest = new List<int>(temp);
            }
            return longest;
        }

        public static List<int> FindLongestDecreasingSequence(List<int> ints)
        {
            var result = new List<int>();
            var temp = new List<int>() { ints[0] };

            for (int i = 1; i < ints.Count; i++)
            {
                if (ints[i] < temp[^1])
                {
                    temp.Add(ints[i]);
                }
                else
                {
                    if (temp.Count > result.Count)
                    {
                        result = new List<int>(temp);
                    }
                    temp.Clear();
                    temp.Add(ints[i]);
                }
            }
            if (temp.Count > result.Count)
            {
                result = new List<int>(temp);
            }
            return result;
        }               
    }
}
