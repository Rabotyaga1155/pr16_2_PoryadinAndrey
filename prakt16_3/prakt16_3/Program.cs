using System;

namespace prakt16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double[] arr = { 5.1, 1.3, 9.2, 2.3,5.1,3};
            double[] uniqueNums = getnumbers(arr);
            int[] f = new int[uniqueNums.Length];
            for (int i =0;i<uniqueNums.Length;i++)
            {
                f[i] = getf(arr, uniqueNums[i]);
                Console.WriteLine($"{uniqueNums[i]} - {f[i]}");
            }
            double[] newArr = new double[arr.Length];
            for(int i = 0;i<arr.Length;i++)
            {
                double num = arr[i];
                int index = Array.IndexOf(uniqueNums, num);
                newArr[i] = num * f[index];
            }
            Console.WriteLine("Новый массив: ");
                foreach(var i in newArr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            static int getf(double[] arr,double num)
            {
                int f = 0;
                foreach (double n in arr)
                {
                    if (n == num)
                    {
                        f++;
                    }
                }
                return f;
            }































            static double[] getnumbers(double[] arr)
            {
                double[] uniqueNum = new double[arr.Length];
                int i = 0;
                foreach (double a in arr)
                {
                    if (Array.IndexOf(uniqueNum,a)==-1)
                    {
                        uniqueNum[i] = a;
                        i++;
                    }
                }
                Array.Resize(ref uniqueNum, i);
                return uniqueNum;
            }
        }
    }
}
