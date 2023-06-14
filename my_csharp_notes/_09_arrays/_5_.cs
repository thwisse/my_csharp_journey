namespace _09_arrays
{
    internal class _5_
    {
        static void Main5(string[] args)
        {
            // array metot 3 - IndexOf

            Array isimler = new[] { "Polat", "Memati", "Çakır", "Abdülhey", "Aslan" };
            
            // overload 1
            // int Array.IndexOf(Array array, object? value)

            int index = Array.IndexOf(isimler, "Memati");

            if (index != -1)
                Console.WriteLine("Bu değer bu dizide var.");
            else
                Console.WriteLine("... yok.");
            
            // overload 2
            // int Array.IndexOf(Array array, object? value, int startIndex, int count)

            int index2 = Array.IndexOf(isimler, "Aslan", 0, 5);

            if (index2 != -1)
                Console.WriteLine("Bu değer bu aralıkta var.");
            else   
                Console.WriteLine("... yok.");

            char ch = Console.ReadKey().KeyChar;
        }
    }
}