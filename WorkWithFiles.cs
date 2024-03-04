using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortaOne
{
    internal static class WorkWithFiles
    {
        public static List<int> ReadNumbersToList(string filePath)
        {
            var readedList = new List<int>();

            using (var sr = new StreamReader(filePath))
            {
                string? line;

                while ((line = sr.ReadLine()) is not null)
                {
                    readedList.Add(int.Parse(line));
                }
            }

            return readedList;
        }

        public static List<int> ReadNumbersToListWithCapacity(string filePath, int capacity)
        {
            var readedList = new List<int>(capacity);

            using (var sr = new StreamReader(filePath))
            {
                string? line;

                while ((line = sr.ReadLine()) is not null)
                {
                    readedList.Add(int.Parse(line));
                }
            }

            return readedList;
        }

        public static int[] ReadNumbersToArray(string filePath)
        {
            int capacity = 0;

            var readedArray = Array.Empty<int>();

            using (var sr = new StreamReader(filePath))
            {
                while (sr.ReadLine() is not null)
                {
                    capacity++;
                }

                readedArray = new int[capacity];

                sr.DiscardBufferedData();
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                string? line;
                int count = 0;

                while ((line = sr.ReadLine()) is not null)
                {
                    readedArray[count++] = int.Parse(line);
                }
            }

            return readedArray;
        }

        public static int[] ReadNumbersToArrayWithCapacity(string filePath, int capacity)
        {

            var ints = new int[capacity];

            using (var sr = new StreamReader(filePath))
            {
                string? line;
                int count = 0;

                while ((line = sr.ReadLine()) is not null)
                {
                    ints[count++] = int.Parse(line);
                }
            }

            return ints;
        }

        public static List<int> ReadNumbersFileReadLines(string filePath)
        {
            var readedList = new List<int>();

            var lines = File.ReadLines(filePath);

            foreach (var line in lines)
            {
                if (line is not null)
                    readedList.Add(int.Parse(line));
            }

            return readedList;
        }
    }
}
