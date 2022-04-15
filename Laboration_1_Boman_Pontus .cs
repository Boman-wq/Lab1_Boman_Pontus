using System;
using LaborationInterfaces;
using System.Text;

namespace Boman_Pontus
{
    public class Laboration_1 : ILaboration_1
    {
        public uint NOfOccurrences(int[] inputArray, int value)
        {
            uint counter = 0;
            foreach (int i in inputArray)
            {
                if (i == value)
                {
                    counter++;
                }
            }
            return counter;
        }

        public uint MaxDiff_BruteForce(int[] inputArray)
        {
            uint max = uint.MinValue;
            uint min = uint.MaxValue;
            foreach (uint i in inputArray)
            {
                foreach (uint j in inputArray)
                {
                    if (i > j && i > max)
                    {
                        max = i;
                    }
                    else if (i < j && i < min)
                    {
                        min = i;
                    }
                }
            }
            return max - min;
        }

        public uint MaxDiff_Improved(int[] inputArray)
        {
            uint max = uint.MinValue;
            uint min = uint.MaxValue;

            foreach (uint i in inputArray)
            {
                if (i > max)
                {
                    max = i;
                }
                else if (i < min)
                {
                    min = i;
                }
            }

            return max - min;
        }

        public void ReverseArray(int[] inputArray)
        {
            int i = 1;

            while (i < inputArray.Length - 1)
            {
                int nextValue = inputArray[i];
                int j = i;
                while (j > 0)
                {
                    inputArray[j] = inputArray[j - 1];
                    j--;
                }
                inputArray[0] = nextValue;
                i++;
            }
        }

        public void ReverseArray_Improved(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                int tmp = inputArray[i];
                inputArray[i] = inputArray[inputArray.Length - i - 1];
                inputArray[inputArray.Length - i - 1] = tmp;
            }
        }

        public int[] RandomArray(int amount)
        {
            Random random = new();
            int[] array = new int[amount];
            for(var i = 0; i < amount; i++)
            {
                array[i] = random.Next();
            }
            return array;
        }

        public int RandomValue()
        {
            Random random = new();
            return random.Next(0, int.MaxValue);
        }
        public string WriteToFile(int size, double ms)
        {
            var csv = new StringBuilder();
            var sizeString = $"{size:e2}";
            var msString = $"{ms:f0}";
            var newLine = string.Format($"{sizeString.ToString()};{msString.ToString()};");
            return newLine;
        }
    }
    public class Size
    {
        public int ArrayBigSize = 5000000;
        public int ArraySmallSize = 5000;
    }
}
