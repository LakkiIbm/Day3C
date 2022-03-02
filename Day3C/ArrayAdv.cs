using System;
using System.Linq;

//---------------Jagged Array-------------------------------------
//namespace Day3C
//{
//    internal class ArrayAdv
//    {
//        static void Main(string[] args)
//        {
//            int[][] arr = new int[][] { new int[] { 1, 2, 3, 4, 5, 6, }, new int[] { 4, 2, 1 }, 
//                            new int[] { 2, 3, 4 }, new int[] { 3, 4, 5 }, new int[] { 4, 5, 6 } };
//            int i, j;
//            for(i = 0; i < arr.Length; i++)
//            {
//                for(j = 0; j < arr[i].Length; j++)
//                {
//                    Console.WriteLine("arr[{0},{1}] = {2}",i,j,arr[i][j]);
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}



//--------------------------Param Array----------------------------------------
//namespace Day3C
//{
//    class ArrayAdv
//    {
//        public int sumOfArray(params int[] arr)
//        {
//            Console.Write("Array: ");
//            foreach (int i in arr)
//                Console.Write(i+" ");
//            Console.WriteLine();
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//                sum+=arr[i];
//            return sum;
//        }
//    }
//    class testClass
//    {
//        static void Main(string[] args)
//        {
//            ArrayAdv a = new ArrayAdv();
//            int s = a.sumOfArray(31,22,72,20,87,10);
//            Console.WriteLine("The sum of the array is : "+s);
//            Console.ReadLine();
//        }
//    }
//}



//--------------------------Passing an array to method---------------------------------------
//namespace Day3C
//{
//    class ArrayAdv
//    {
//        public double avgOfArray(int[] arr)
//        {
//            int n = arr.Length;
//            int sum = 0;
//            for (int i = 0; i < arr.Length; i++)
//                sum += arr[i];
//            double avg = (double)sum / n;
//            return avg;
//        }
//    }
//    class testClass
//    {
//        static void Main(string[] args)
//        {
//            ArrayAdv a = new ArrayAdv();
//            int[] l = new int[] { 31, 22, 72, 20, 87, 10 };
//            Console.Write("Array: ");
//            foreach (int i in l)
//                Console.Write(i + " ");
//            Console.WriteLine();
//            double avg;
//            avg = a.avgOfArray(l);
//            Console.WriteLine("The average of the array is : " + avg);
//            Console.ReadLine();
//        }
//    }
//}



//------------------Exploring various methods in array----------------------------
//namespace Day3C
//{
//    internal class ArrayAdv
//{
//    static void Main(string[] args)
//    {
//        int[] b = { 12, 17, 10, 20, 14, 5, 30 };
//        int[] temp = b;
//        Console.Write("Original Array: ");
//        foreach (int i in b)
//            Console.Write(i + " ");
//        Console.WriteLine();
//        Array.Reverse(b);
//        Console.Write("Reversed Array: ");
//        foreach (int i in b)
//            Console.Write(i + " ");
//        Console.WriteLine();
//        Array.Sort(temp);
//        Console.Write("Sorted Array: ");
//        foreach (int i in temp)
//            Console.Write(i + " ");
//        Console.WriteLine();
//        Console.ReadLine();
//    }
//}
//}


//---------------------Jagged array with 2D array--------------------------------
namespace Day3C
{
    internal class ArrayAdv
    {
        static void Main(string[] args)
        {
            int[][,] arr = new int[][,]
            {
                new int[,]{{4,2},{5,3}, { 6,4} },
                new int[,]{ { 7, 5 }, { 8, 6 } },
                new int[,]{{1,1}}
            };
            Console.WriteLine("The values in the array are:");
            for(int i = 0; i < arr.Length; i++)
                foreach (int n in arr[i])
                    Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}