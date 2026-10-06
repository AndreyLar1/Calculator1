using System;

namespace Calculator
{
    public class GUIConsoleApp
    {
        public double Sum(int[] array)
        {
            double s = 0;
            foreach (var x in array) s += x;
            return s;
        }
    public int Count(int[] array) => array.Length;

    public int Max(int[] array)
    {
            int max = array[0];
            foreach (var x in array) if (x > max) max = x; 
            return max; 
        }

    public int Min(int[] array)
    {
            int min = array[0];
            foreach (var x in array) if (x < min) min = x;
            return min; 
        }

        public int FindIndex(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) return i;
            }
            return -1; 
        }


        public int[] Sort(Int[] array)
        {
            int[] sorted = (int[])array.Clone();
            for (int i = 0; i < sotred.Length - 1; i+
            {
                for (int j = 0; j < sotred.Length - i - 1; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        int temp = sorted [j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp; 
                    }

                }
            }
            return sorted;
        }
    }
}