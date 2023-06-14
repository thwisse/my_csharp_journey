namespace _09_arrays
{
    internal class _7_
    {
        static void Main7(string[] args)
        {
            // array metot 5 - Sort

            Array isimler = new[] { "Polat", "Memati", "Çakır", "Abdülhey", "Aslan" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }
            Console.WriteLine("/////////////////////");

            Array.Sort(isimler);

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}