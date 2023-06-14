namespace _09_arrays
{
    internal class _3_
    {
        static void Main3(string[] args)
        {
            // array metot 1 - Clear

            Array isimler = new[] { "Polat", "Memati", "Çakır", "Abdülhey" };

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i));
            }

            Array.Clear(isimler, 0, isimler.Length);

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler.GetValue(i) + ".");
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}