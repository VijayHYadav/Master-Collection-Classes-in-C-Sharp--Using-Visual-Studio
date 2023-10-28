using System.Collections;

namespace Ex_ArrayList
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            ArrayListCreate(num1, num2, num3);
        }

        public static int[] ArrayListCreate(int a, int b, int c)
        {
            ArrayList array = new ArrayList();
            array.Add(a);
            array.Add(b);
            array.Add(c);
            int[] retVal = new int[3];
            Console.WriteLine("The items in the list are:");
            for (int i = 0; i < array.Count; i++)
            {
                retVal[i] = Convert.ToInt32(array[i]);
            }

            return retVal;
        }
    }
}