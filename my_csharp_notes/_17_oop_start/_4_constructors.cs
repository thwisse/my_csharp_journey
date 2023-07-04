namespace _17_oop_start;

class _4_constructors
{
    static void Main(string[] args)
    {
        // overloading in constructors

        CuteClass nesne = new CuteClass();

        CuteClass nesne2 = new CuteClass(15);

        CuteClass nesne3 = new CuteClass("asus tuf");

        char ch = Console.ReadKey().KeyChar;
    }
}

class CuteClass
{
    public CuteClass()
    {
        Console.WriteLine("huehueheuheuheu");
    }

    public CuteClass(int x)
    {
        Console.WriteLine("puhahahahahah " + x);
    }

    public CuteClass(string x)
    {
        Console.WriteLine("qweqweqweqweqwe " + x);
    }
}