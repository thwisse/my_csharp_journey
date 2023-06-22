namespace _17_oop_get_started;

class _1_full_property
{
    static void Main1(string[] args)
    {
        Banka hesap = new Banka();

        Console.WriteLine(hesap.Bakiye); // get blogu tetiklenecek /// 0 - default deger (bakiye yok)
        // iste burada -1 0 1 2 degerlerine gore if blogunda bakiyeyi degerlendirirsin.

        hesap.Bakiye = 2500; // set blogu tetiklenecek

        Console.WriteLine(hesap.Bakiye); /// 2 - yeni deger (1000 tlden cok bakiye)

        Banka hesap2 = new Banka();

        hesap2.Bakiye = 500;

        Console.WriteLine(hesap2.Bakiye); /// 1 (1000 tlden cok bakiye)

        char ch = Console.ReadKey().KeyChar;
    }
}

// Full Property

class Banka
{
    int bakiye;

    public int Bakiye
    {
        get
        {
            if (bakiye < 0)
            {
                return -1;  // bakiye ekside
            }
            else if (bakiye == 0)
            {
                return 0;   // bakiye yok
            }
            else if (bakiye < 1000)
            {
                return 1;   // 1000 tlden az bakiye
            }
            else
            {
                return 2;   // 1000 tlden cok bakiye
            }
        }
        set
        {
            if (value < 1000)
            {
                bakiye = value;  // value: disardan gelen deger. bunu fielda atiyoruz.
            }
            else    // 1000 tlden fazla bakiye
            {
                bakiye = value * 90 / 100;  // yuzde 10 vergi uyguladim.
            }
        }
    }
}