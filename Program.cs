using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Duplicates
{
    class Program
    {
        static void Main(string[] args)
        {

            var listWithDuplicates = new List<int>(10000);

            var rand = new Random();

            listWithDuplicates.AddRange(Enumerable.Range(0, 100000).Select(x => rand.Next(x)));

            var anotherList = new List<int>() { 1, 1, 1, 1, 3, 4, 4, 4, 1, 3 };

            if (ContainsDuplicates(RemoveDuplicates(listWithDuplicates)) && ContainsDuplicates(RemoveDuplicates(anotherList)))
            {
                Console.WriteLine("List still contains duplicates");
            }
            else
            {
                Console.WriteLine("Duplicates removed");
            }
        }


        public static List<int> RemoveDuplicates(List<int> listWithDuplicates)
        {
            /*TODO: Remove Duplicates in listWithDuplicates*/
            for (int i = 0; i < listWithDuplicates.Count; i++)
            {

                for (int j = i + 1; j < listWithDuplicates.Count; j++)
                {
                    if (listWithDuplicates[i] == listWithDuplicates[j])
                    {
                        listWithDuplicates.RemoveAt(j);
                        j--;
                    }

                }
            }


            return listWithDuplicates; //return list without duplicates
        }


        public static bool ContainsDuplicates(IEnumerable<int> list)
        {
            var collection = list.ToArray();

            return collection.Count() != collection.Distinct().Count();

        }



    }
}