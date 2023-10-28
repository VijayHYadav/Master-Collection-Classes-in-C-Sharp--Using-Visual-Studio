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




            ArrayList aList2 = new ArrayList();

            // Add an object array
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            foreach (var item in aList2)
            {
                Console.WriteLine("The members of the new list are {0}", item);
            }

            // Add 1 array list to another
            aList.AddRange(aList2);
            foreach (var item in aList)
            {
                Console.WriteLine("The revised members of the list are {0}", item);
            }

            // Insert at the 2nd position
            aList2.Insert(1, "Turkey");
            foreach (var item in aList2)
            {
                Console.WriteLine("The members of the revised list are {0}", item);
            }


            // Get the 1st 2 items
            ArrayList range = aList2.GetRange(0, 2);
            foreach (var item in range)
            {
                Console.WriteLine("The members of the shortened list are {0}", item);
            }

            //End lecture 3

           
            Console.ReadLine();
        }
    }
}