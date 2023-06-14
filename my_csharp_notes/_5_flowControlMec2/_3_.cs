namespace _5_flowControlMec2
{
    internal class _3_
    {
        static void Main3(string[] args)
        {
            // pattern matching (C# 7.0)

            // 1- type pattern
            
            object x = 123;

            if (x is string a)
                Console.WriteLine("x değişkeni string'dir. Değeri: " + x);

            else if (x is int b)
                Console.WriteLine("x değişkeni int'dir. Değeri: " + x);

            else
                Console.WriteLine("Hata");
            
            System.Console.ReadKey();
        }
    }
}