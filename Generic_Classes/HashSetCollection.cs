using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Classes
{
    public class HashSetCollection
    {
        static void Main()
        {
            List<string> firstSetOfColors = new List<string>();
            firstSetOfColors.Add("Red");
            firstSetOfColors.Add("yellow");
            firstSetOfColors.Add("Green");
            firstSetOfColors.Add("Purple");

            List<string> secondSetOfColors = new List<string>();
            secondSetOfColors.Add("Orange");
            secondSetOfColors.Add("Black");
            secondSetOfColors.Add("Red");
            secondSetOfColors.Add("Magenta");

            HashSet<string> set1 = new HashSet<string>(firstSetOfColors);
            HashSet<string> set2 = new HashSet<string>(secondSetOfColors);

            set1.UnionWith(set2);

            Console.WriteLine("=======================================");
            Console.WriteLine("set1 elements after UnionWith operation");

            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("set1 elements after ExceptWith operation");

            set1.ExceptWith(set2);
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("set1 elements after SymmetricExceptWith operation");

            set1.SymmetricExceptWith(set2);
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=======================================");
            Console.WriteLine("set1 elements after IntersectWith operation");

            set1.IntersectWith(set2);
            foreach (var item in set1)
            {
                Console.WriteLine(item);
            }
        }
    }
}