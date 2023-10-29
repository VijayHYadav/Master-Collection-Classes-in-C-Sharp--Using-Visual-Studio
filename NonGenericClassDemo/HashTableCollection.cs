using System.Collections;

namespace NonGenericClassDemo
{
    public class HashTableCollection
    {
        public static void Main()
        {
            Hashtable currencies = new Hashtable();
            
            currencies?.Add("India", "Rupee");
            currencies?.Add("US", "US Dollar");
            currencies?.Add("Britain", "Pound");
            
           currencies?.Add("France", "Euro");

            try
            {
                currencies?.Add("France", "Euro");
                Console.WriteLine("A new country/currency pair added");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"France\" already exists");
            }

            Console.WriteLine();

            currencies!["India"] = "INR";
            Console.WriteLine("For key = \"India\", value = {0}", currencies["India"]);

            Console.WriteLine();

            if(!currencies.ContainsKey("Oman"))
            {
                currencies.Add("Oman", "Rial");
                Console.WriteLine("Value added for key = \"Oman\",  {0}", currencies["Oman"]);

            }

            Console.WriteLine();

            foreach (DictionaryEntry item in currencies)
            {
                Console.WriteLine($"key ={item.Key}, value = {item.Value} ");
            }

            Console.WriteLine("=========================================");

            // * lecture 2 starts
            ICollection collection = currencies.Keys;
            Console.WriteLine();
            foreach (string item in collection)
            {
                Console.WriteLine($"Key = {item}");
            }


            Console.WriteLine("Now let us use Remove() method");

            currencies.Remove("Britain");

            if(!currencies.ContainsKey("Britain"))
            {
                Console.WriteLine("Key \"Britain\" is not found");
            }

            // * lecture 2 end
        }
    }
}