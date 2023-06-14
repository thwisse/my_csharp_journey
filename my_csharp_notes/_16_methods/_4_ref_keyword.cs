namespace _16_methods;

class _4_ref_keyword
{
    static void Main4(string[] args)
    {
        int a = 10;

        Console.WriteLine(a);

        ref int b = ref a;

        b++;

        Console.WriteLine(a);
        Console.WriteLine(b);

        Console.WriteLine("----------------");

        /////////////////////////////////////

        int x = 3;

        Console.WriteLine(x);

        Degistir(ref x);

        Console.WriteLine(x);
        

        char ch = Console.ReadKey(true).KeyChar;
    }

    static void Degistir(ref int y)
    {
        y = 30;
    }
}
