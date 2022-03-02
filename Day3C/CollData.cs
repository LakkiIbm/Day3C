//-----------------------ArrayList-------------------------------------------
//---------------------------------------------------------------------------
//using System;
//using System.Collections;

//namespace Day3C
//{
//    internal class CollData
//    {
//        static void Main(string[] args)
//        {
//            ArrayList data = new ArrayList();
//            data.Add("Apple");
//            data.Add("Rice");
//            data.Add(2.2);
//            data.Add(10);
//            data.Add(20);
//            data.Add(30);
//            data.Add(50);
//            data.Remove(20);
//            Console.WriteLine("The elements in the ArrayList are:");
//            foreach (object item in data)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadLine();

//        }
//    }
//}


//----------------------------------List------------------------------------
//--------------------------------------------------------------------------
//using System;
//using System.Collections;
//using System.Collections.Generic;
//namespace Day3C
//{
//    class CollData
//    {
//        static void Main(string[] args)
//        {
//            var value = new List<int>();
//            value.Add(10);
//            value.Add(20);
//            value.Add(30);
//            value.Add(40);
//            value.Add(50);
//            value.Remove(value[0]);
//            value.Insert(3,100);
//            Console.WriteLine("The values is the List are:");
//            foreach (var item in value)
//                Console.WriteLine(item);
//            Console.ReadLine();
//        }
//    }
//}


//----------------------------------Sorted List------------------------------------
//--------------------------------------------------------------------------
//using System;
//using System.Collections.Generic;
//namespace Day3C
//{
//    class CollData
//    {
//        static void Main(string[] args)
//        {
//            var value = new SortedList<string,int>();
//            value.Add("Samsung", 10);
//            value.Add("Apple", 20);
//            value.Add("Nokia",30);
//            value.Add("Sony",40);
//            value.Add("OnePlus",50);
//            value.Add("Realme",80);
//            Console.WriteLine("The values in the Sorted List are:");
//            foreach (var item in value)
//                Console.WriteLine(item);
//            Console.ReadLine();
//        }
//    }
//}


//----------------------------------Linked List------------------------------------
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
namespace Day3C
{
    class CollData
    {
        static void Main(string[] args)
        {
            var value = new LinkedList<int>();
            value.AddLast(10);
            value.AddLast(20);
            value.AddLast(30);
            value.AddFirst(40);
            value.AddFirst(50);
            value.AddFirst(80);
            LinkedListNode<int> node = value.Find(30);
            value.AddBefore(node, 25);
            Console.WriteLine("The values in the Linked List are:");
            foreach (var item in value)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}