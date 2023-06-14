namespace _9_arrays
{
    internal class _4_
    {
        static void Main4(string[] args)
        {
            // array metot 2 - Copy

            Array isimler = new[] { "Polat", "Memati", "Çakır", "Abdülhey", "Aslan" };

            string[] isimler2 = new string[isimler.Length];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }
            Console.WriteLine("/////////////////////");

            // overload 1
            Array.Copy(isimler, isimler2, isimler.Length);
            // (Array sourceArray, Array destinationArray, int length)

            for (int i = 0; i < isimler2.Length; i++)
            {
                Console.WriteLine(isimler2[i]);
            }
            Console.WriteLine("/////////////////////");

            string[] isimler3 = new string[isimler.Length];

            // overload 2
            Array.Copy(isimler, 2, isimler3, 2, 3);
            // (Array sourceArray, int sourceIndex, Array destinationArray, 
            // int destinationIndex, int length)

            for (int i = 0; i < isimler2.Length; i++)
            {
                Console.WriteLine(isimler3[i]);
            }
            Console.WriteLine("/////////////////////");

            char ch = Console.ReadKey().KeyChar;
        }
    }
}