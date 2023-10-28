using System.Collections;

namespace NonGenericClassDemo
{
    public class ArrayListCollection
    {
        static void Main(string[] args)
        {
            // * Collections can resize unlike arrays
            // * ArrayLists are resizable arrays
            // * that can hold multiple data types
            // * Create an ArrayList instance
            
            ArrayList aList = new ArrayList(); // 4 and then double the size

            aList.Add("Rob");
            aList.Add(50);
            aList.Add(45);

            //Display the count and capacity properties of the collection
            Console.WriteLine($"Count: {aList.Count}");
            
            // ? Capacity 
            Console.WriteLine($"Capacity of the list: {aList.Capacity}");
            aList.Add(80);
            aList.Add(70);

            // ! Capacity 
            Console.WriteLine($"Capacity of the list after adding two items: {aList.Capacity}");
            
            foreach (var item in aList)
            {
                Console.WriteLine($"The list members are {item}");
            }
            
            //aList.Sort();//Fails due to Rob 
            aList.Remove("Rob");
            aList.Sort();//Succeeds
            aList.Add("John");
            //aList.Reverse(); //Fails
            aList.Remove("John");
            aList.Reverse(); //Succeeds

            Console.WriteLine("The list members after removing John are");

            foreach (var item in aList)
            {
                Console.WriteLine($"{item}");
            }

            aList.Sort();
            Console.WriteLine("The list members after sorting are ");
            foreach (var item in aList)
            {
                Console.WriteLine($"{item}");
            }

            aList.Reverse();
            Console.WriteLine("The list members after reversing are ");
            foreach (var item in aList)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}