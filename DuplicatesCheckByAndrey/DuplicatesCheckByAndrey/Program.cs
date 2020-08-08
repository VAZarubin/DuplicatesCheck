using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 3, 23, 4, 1, 34, 1, 5, 3, 3, 45, 6, 3, 2, 34, 5, 76, 6, 4, 5 };

            List<int> NewList = new List<int>() { 1, 3, 23, 4, 1, 34, 1, 5, 3, 3, 45, 6, 3, 2, 34, 5, 76, 6, 4, 5 };

            Dubs(list);


            List<int> Dubs(List<int> SomeList)
            {
                for (int i = 0; i < SomeList.Count; i++)
                {

                    for (int j = i + 1; j < SomeList.Count; j++)
                    {
                        if (SomeList[i] == SomeList[j])
                        {
                            SomeList.RemoveAt(j);
                            j--;
                        }

                    }
                }
                return SomeList;
            }




            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            foreach (int j in NewList)
            {
                Console.Write(" " + j);
            }



        }
    }
}
