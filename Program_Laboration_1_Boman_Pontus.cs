using System;
using System.Text;
using Boman_Pontus;

namespace Program
{
    public class Labs
    {
        static void task_1()
        {
            //task_1
            var csv = new StringBuilder();
            Size size = new();
            Laboration_1 lab = new();
            var amountOfRuns = 10;  // Amount of runs for the for loop
            var changeValueEvery = 1; // Change value of n every x number
            
            for (var i = 0; i < amountOfRuns; i++)
            {
                if (i % changeValueEvery == 0)
                    size.ArrayBigSize += 5000000;
                Console.WriteLine(size.ArrayBigSize);
                var array = lab.RandomArray(size.ArrayBigSize);
                var value = lab.RandomValue();

                DateTime start = DateTime.Now;
                var product = lab.NOfOccurrences(array, value);
                DateTime stop = DateTime.Now;

                TimeSpan execitionTime = stop - start;
                var ms = execitionTime.TotalMilliseconds;
                Console.WriteLine($"NOfOccurrences: värdet {value} hittades {product} gånger i listan, det tog {ms:f0} ms");


                var newLine = lab.WriteToFile(size.ArrayBigSize, ms);
                csv.AppendLine(newLine);
            }
            ////-----Uncomment to print to csv file-----
            //File.WriteAllText("../../../csv_files/runTimeForNOfOccurrences.csv", csv.ToString());
        }
        static void task_2_a()
        {
            var csv = new StringBuilder();
            Size size = new();
            Laboration_1 lab = new();
            var amountOfRuns = 10;  // Amount of runs for the for loop
            var changeValueEvery = 1; // Change value of n every x number

            for (var i = 0; i < amountOfRuns; i++)
            {
                if (i % changeValueEvery == 0)
                    size.ArraySmallSize += 500;
                Console.WriteLine(size.ArraySmallSize);
                var array = lab.RandomArray(size.ArraySmallSize);

                DateTime start = DateTime.Now;
                var product = lab.MaxDiff_BruteForce(array);
                DateTime stop = DateTime.Now;

                TimeSpan execitionTime = stop - start;
                var ms = execitionTime.TotalMilliseconds;
                Console.WriteLine($"MaxDiff_BruteForce: Den största skillnaden i listan är {product} det tog {ms:f0} ms");


                var newLine = lab.WriteToFile(size.ArraySmallSize, ms);
                csv.AppendLine(newLine);
            }
            ////-----Uncomment to print to csv file-----
            //File.WriteAllText("../../../csv_files/runTimeForMaxDiff_BruteForce.csv", csv.ToString());
        }
        static void task_2_b()
        {
            var csv = new StringBuilder();
            Size size = new();
            Laboration_1 lab = new();
            var amountOfRuns = 10;  // Amount of runs for the for loop
            var changeValueEvery = 1; // Change value of n every x number

            for (var i = 0; i < amountOfRuns; i++)
            {
                if (i % changeValueEvery == 0)
                    size.ArrayBigSize += 5000000;
                Console.WriteLine(size.ArrayBigSize);
                var array = lab.RandomArray(size.ArrayBigSize);

                DateTime start = DateTime.Now;
                var product = lab.MaxDiff_Improved(array);
                DateTime stop = DateTime.Now;

                TimeSpan execitionTime = stop - start;
                var ms = execitionTime.TotalMilliseconds;
                Console.WriteLine($"MaxDiff_Improved: Den största skillnaden i listan är {product} det tog {ms:f0} ms");


                var newLine = lab.WriteToFile(size.ArrayBigSize, ms);
                csv.AppendLine(newLine);
            }
            ////-----Uncomment to print to csv file-----
            //File.WriteAllText("../../../csv_files/runTimeForMaxDiff_Improved.csv", csv.ToString());
        }
        static void task_3_a()
        {
            var csv = new StringBuilder();
            Size size = new();
            Laboration_1 lab = new();
            var amountOfRuns = 10;  // Amount of runs for the for loop
            var changeValueEvery = 1; // Change value of n every x number

            for (var i = 0; i < amountOfRuns; i++)
            {
                if (i % changeValueEvery == 0)
                    size.ArraySmallSize += 2500;
                Console.WriteLine(size.ArraySmallSize);
                var array = lab.RandomArray(size.ArraySmallSize);

                DateTime start = DateTime.Now;
                lab.ReverseArray(array);
                DateTime stop = DateTime.Now;


                TimeSpan execitionTime = stop - start;
                var ms = execitionTime.TotalMilliseconds;
                Console.WriteLine($"ReverseArray: Listan är nu tvärtom och det tog {ms:f0} ms");
            


                var newLine = lab.WriteToFile(size.ArraySmallSize, ms);
                csv.AppendLine(newLine);
            }
            ////-----Uncomment to print to csv file-----
            //File.WriteAllText("../../../csv_files/runTimeForReverseArray.csv", csv.ToString());
        }
        static void task_3_b()
        {
            var csv = new StringBuilder();
            Size size = new();
            Laboration_1 lab = new();
            var amountOfRuns = 10;  // Amount of runs for the for loop
            var changeValueEvery = 1; // Change value of n every x number

            for (var i = 0; i < amountOfRuns; i++)
            {
                if (i % changeValueEvery == 0)
                    size.ArrayBigSize += 5000000;
                Console.WriteLine(size.ArrayBigSize);
                var array = lab.RandomArray(size.ArrayBigSize);

                DateTime start = DateTime.Now;
                lab.ReverseArray_Improved(array);
                DateTime stop = DateTime.Now;


                TimeSpan execitionTime = stop - start;
                var ms = execitionTime.TotalMilliseconds;
                Console.WriteLine($"ReverseArray_Improved: Listan är nu tvärtom och det tog {ms:f0} ms");



                var newLine = lab.WriteToFile(size.ArrayBigSize, ms);
                csv.AppendLine(newLine);
            }
            ////-----Uncomment to print to csv file-----
            //File.WriteAllText("../../../csv_files/runTimeForReverseArray_Improved.csv", csv.ToString());
        }
        static void Main(string[] args)
        {
            task_1();
            task_2_a();
            task_2_b();
            task_3_a();
            task_3_b();
        }
    }
}
