namespace _16_methods;

class _1_get_started
{
    static void Main(string[] args)
    {
        Ozi ozi = new Ozi();

        ozi.EkranaYazdir("Merhaba Dunya!");

        Console.WriteLine(ozi.UyariMesaji());

        char ch = Console.ReadKey(true).KeyChar;
    }
}

class Ozi
{
    public void EkranaYazdir(string yazi)
    {
        Console.WriteLine(yazi);
    }

    public string UyariMesaji()
    {
        return "Bu bir uyaridir.";
    }
}