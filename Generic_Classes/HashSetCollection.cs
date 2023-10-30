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

            // ! Lecture 2 Starts
            Console.WriteLine("=======================================");
            
            HashSet<int> setOfNumbers = new HashSet<int>();

            for (int i = 0; i <= 5; i++)
            {
                setOfNumbers.Add(i);
            }

            Console.WriteLine($"setOfNumber contains {setOfNumbers.Count}");
            PrintSet(setOfNumbers);

            void PrintSet(HashSet<int> set)
            {
                Console.WriteLine("{");
                foreach (var i in set)
                {
                    Console.WriteLine($" {i}");
                }
                Console.WriteLine(" }");
            }

            Console.WriteLine("setOfNumbers after removing the even numbers");
            setOfNumbers.RemoveWhere(IsEven);
            PrintSet(setOfNumbers);
            bool IsEven(int i) {
                return ((i % 2) == 0);
            }

            HashSet<int> setOfNumbers2 = new HashSet<int>();

            for (int i = 0; i <= 5; i++)
            {
                setOfNumbers2.Add(i);
            }
            PrintSet(setOfNumbers2);

            if(setOfNumbers2.Contains(0)) {
                setOfNumbers2.Remove(0);
            }
            Console.WriteLine("setOfNumbers2 after removing the 0");

            PrintSet(setOfNumbers2);

        }
    }
}