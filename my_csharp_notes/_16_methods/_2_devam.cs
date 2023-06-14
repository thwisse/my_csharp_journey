namespace _16_methods;

class _2_devam
{
    static void Main2(string[] args)
    {
        Birlestir("ismet", "inonu");

        Birlestir("mustafa", "kemal", "ataturk");

        Birlestir("salih", "bozok", '!'); // baskomutan yaversiz gitmez!

        char ch = Console.ReadKey(true).KeyChar;
    }

    static void Birlestir(string yazi1, string yazi2)
    {
        Console.WriteLine($@"{yazi1} {yazi2}");
    }

    static void Birlestir(string yazi1, string yazi2, string yazi3)
    {
        Console.WriteLine($@"{yazi1} {yazi2} {yazi3}");
    }

    static void Birlestir(string yazi1, string yazi2, char yazi3)
    {
        Console.WriteLine($@"{yazi1} {yazi2} {yazi3}");
    }
}
