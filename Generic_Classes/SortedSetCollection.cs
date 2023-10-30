using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Classes
{
    public class SortedSetCollection
    {
        static void Main(){
        SortedSet<int> set1 = new SortedSet<int>();
        set1.Add(10);
        set1.Add(20);
        set1.Add(30);
        set1.Add(40);
        SortedSet<int> set2 = new SortedSet<int>();
        set2.Add(30);
        set2.Add(10);
        set2.Add(60);
        set2.Add(50);

        Console.WriteLine(set1.Overlaps(set2));
        Console.WriteLine("........................");
        SortedSet<int> set3 = set1.GetViewBetween(11, 39);
        Console.WriteLine("The view between 11 and 39 in set1");
        foreach (var item in set3)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("........................");
        // set1.Reverse();
        foreach (var item in set1.Reverse())
        {
            Console.WriteLine(item);
        }

        }


    }
}