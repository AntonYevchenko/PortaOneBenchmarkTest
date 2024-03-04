using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortaOne
{
    [MemoryDiagnoser]
    public class Benchmark
    {
        [Benchmark]
        public void BenchList()
        {
            var list = WorkWithFiles.ReadNumbersToList(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt");
        }

        [Benchmark]
        public void BenchListWithCapacity()
        {
            var list = WorkWithFiles.ReadNumbersToListWithCapacity(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt", 10000000);

        }

        [Benchmark]
        public void BenchArray()
        {
            var array = WorkWithFiles.ReadNumbersToArray(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt");

        }

        [Benchmark]
        public void BenchArrayWithCapacity()
        {
            var array = WorkWithFiles.ReadNumbersToArrayWithCapacity(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt", 10000000);

        }


        [Benchmark]
        public void FindMaxFor()
        {
            var list = WorkWithFiles.ReadNumbersToList(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt");
            Calculate.FindMaxNumberFor(list);
        }

        [Benchmark]
        public void FindMaxLinq()
        {
            var list = WorkWithFiles.ReadNumbersToList(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt");
            Calculate.FindMaxNumberLinq(list);
        }



















        //[Benchmark]
        //public void BenchList2()
        //{
        //    var list = WorkWithFiles.ReadNumbersFileDeadLines(@"C:\\Users\\user\\source\\repos\\PortaOne\\bin\\Release\\net8.0\\10m.txt");
        //    double average = list.Average();
        //    int max = list.Max();
        //    int min = list.Min();
        //}

    }
}