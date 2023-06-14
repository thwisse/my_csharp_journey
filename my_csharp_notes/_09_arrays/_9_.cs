namespace _09_arrays
{
    internal class _9_
    {
        static void Main9(string[] args)
        {
            // propertyler

            Array isimler = new[] { "Polat", "Memati", "Çakır", "Abdülhey", "Aslan" };

            //Console.WriteLine(isimler.IsReadOnly);  /// False
            // sadece okunabilir değil. hem okunabilir, hem yazılabilir.

            //Console.WriteLine(isimler.IsFixedSize);   /// True

            //Console.WriteLine(isimler.Length);  /// 5

            //Console.WriteLine(isimler.Rank);   /// 1

            char ch = Console.ReadKey().KeyChar;
        }
    }
}