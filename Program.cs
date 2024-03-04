using BenchmarkDotNet.Running;

namespace PortaOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfInts = WorkWithFiles.ReadNumbersToList("10m.txt");
            var listOfDoubles = listOfInts.ConvertAll(x => (double) x);

            Console.WriteLine($"Max number: {Calculate.FindMaxNumberLinq(listOfInts)}\n");
            Console.WriteLine($"Min number: {Calculate.FindMinNumber(listOfInts)}\n");
            Console.WriteLine($"Average number: {Calculate.FindAverageNumber(listOfInts)} \n");
            Console.WriteLine($"Median number: {Calculate.FindMedian(listOfDoubles)}\n");

            PrintLongestIncreasingSequence(listOfInts);
            PrintLongestDecreasingSequence(listOfInts);

            static void PrintLongestIncreasingSequence(List<int> listOfInts)
            {
                int count = 0;
                var ints = Calculate.FindLongestIncreasingSequence(listOfInts);

                Console.WriteLine("Longest increasing sequence:");

                foreach (var item in ints)
                {
                    Console.WriteLine(item);
                    count++;
                }
                Console.WriteLine($"Count of elements: {count}\n");
            }

            static void PrintLongestDecreasingSequence(List<int> listOfInts)
            {
                int count = 0;
                var ints = Calculate.FindLongestDecreasingSequence(listOfInts);

                Console.WriteLine("Longest decreasing sequence:");

                foreach (var item in ints)
                {
                    Console.WriteLine(item);
                    count++;
                }
                Console.WriteLine($"Count of elements: {count}\n");
            }

            BenchmarkRunner.Run<Benchmark>();
            
        }
    }
}
