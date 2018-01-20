/*
 * C# Program to Perform Radix Sort
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace radix_sort
{
    class Example
    {
        private int[] data;
        private IList<IList<int>> digits = new List<IList<int>>();
        private int maxLength = 0;
        public Example()
        {
            for (int i = 0; i < 10; i++)
            {
                digits.Add(new List<int>());
            }
            Console.Write("Enter the Number of Records : ");
            int count = int.Parse(Console.ReadLine());
            data = new int[count];
            Console.ReadLine();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Record {0} : ", i + 1);

                data[i] = int.Parse(Console.ReadLine());

                if (maxLength < data[i].ToString().Length)
                    maxLength = data[i].ToString().Length;
            }
        }



        static void Main(string[] args)
        {
            
        }
    }
}
