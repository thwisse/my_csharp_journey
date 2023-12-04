using System.Collections;

namespace my_console_appss;
class exercise10
{
    static void Main10(string[] args)
    {
        // metot bir tam sayi dizisi alip, bu listedeki en buyuk ve 
        // en kucuk sayiyi bulsun ve bir string olarak dondursun.
        // bir siralama algoritmasi yapma. sadece min max bulmaya calisiyoruz.

        Console.Write("Deger sayisini girin: ");
        int degerSayisi = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = new int[degerSayisi];

        for (int i = 0; i < degerSayisi; i++)
        {
            Console.Write(@$"{i + 1}. int degeri girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine(Bul(sayilar));

        string Bul(int[] dizi)
        {
            // int enBuyuk = dizi.Max(), enKucuk = dizi.Min();
            // yerlesik fonksiyonlari kullanarak boyle kolayca da cozulebilir. 
            // ancak algoritmasini yaratmaya calisiyoruz.

            int enBuyuk = dizi[0], enKucuk = dizi[0];

            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }

                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
            }

            return $@"En buyuk sayi: {enBuyuk}, En kucuk sayi: {enKucuk}";
        }

        char ch = Console.ReadKey().KeyChar;
    }
}
