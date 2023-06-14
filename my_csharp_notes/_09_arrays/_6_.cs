namespace _09_arrays
{
    internal class _6_
    {
        static void Main6(string[] args)
        {
            // array metot 4 - Reverse

            Array isimler = new[] { "Polat", "Memati", "Çakır", "Abdülhey", "Aslan" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }
            Console.WriteLine("/////////////////////");
            
            // overload 1
            // void Array.Reverse(Array array)
            
            Array.Reverse(isimler);
            
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }
            Console.WriteLine("/////////////////////");
            Array.Reverse(isimler); // tekrar ilk haline çevirdim

            // overload 2
            // void Array.Reverse(Array array, int index, int length)

            Array.Reverse(isimler, 1, 3);
            // ortadaki 3'lü yer değişti

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}