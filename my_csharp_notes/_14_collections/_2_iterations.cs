using System.Collections;

namespace _14_collections
{
    internal class _2_iterations
    {
        static void Main2(string[] args)
        {
            ArrayList sayilar = new ArrayList() { 98, 987, 9, 79, 87, 987, 9, 879 };

            foreach (object item in sayilar)
            {
                Console.WriteLine(item);
            }

                char ch = Console.ReadKey(true).KeyChar;
        }
    }
}