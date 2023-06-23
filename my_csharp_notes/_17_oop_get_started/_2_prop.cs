namespace _17_oop_get_started;

class _2_prop
{
    static void Main2(string[] args)
    {
        MyClass ozi = new MyClass();
        
        ozi.Yas = 21;

        Console.WriteLine(ozi.Yas);

        /////////////////////////////////////////////

        Console.WriteLine(ozi.Isim);




        char ch = Console.ReadKey().KeyChar;
    }
}

class MyClass
{
    /*
    int yas;

    public int Yas
    {
        get
        {
            return yas;
        }
        set
        {
            yas = value;
        }
    }
    */


    // eger basit bir property yaratmak istiyorsak ve kapsulleme yapmayacaksak
    // tum bunlari boyle yazmak yerine alttaki gibi tek satirda halledebiliriz.
    // alttakinde hem field tanimlanir hem de property olusturulur.
    // kendi fieldini kullanmak istersen prop kullanamazsin. propdaki fielda o classda ya da
    // baska bir yerde erisilmez.

    public int Yas { get; set; }    // prop

    /////////////////////////////////////////////

    // auto property initializers (C# 6.0)

    // fieldin baslangic degerini fieldi olustururken direkt verebilirsin.

    public string Isim { get; set; } = "Oguzhan";

    // bu ozellikten dolayi prop imzalarda ilgili property readonly olabilir ancak writeonly olamaz.
    // yani get tek basina kullanilabilir ama get olmadan set tek basina kullanilamaz.

    public string Soyisim { get; } = "Tutucu";
}
