﻿using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2,3,4,5,6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
            Console.ReadLine();
        }

        public static List<int> GetSmallests(List<int> list, int count)

        {
            if(list ==null)
                throw new ArgumentNullException("list");

            if (count > list.Count)
            throw new ArgumentOutOfRangeException("count", "count should be 1 and number of elements in this list");
          

            var  buffer=new List<int>(list);  //we addc new list so not to remove from ogriginal passed one
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
