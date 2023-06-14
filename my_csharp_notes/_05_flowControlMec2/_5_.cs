namespace _05_flowControlMec2
{
    internal class _5_
    {
        static void Main5(string[] args)
        {
            // pattern matching enhancements (C# 9.0)

            // 1- simple type pattern
            // örnek yok

            // 2- relational pattern
            
            int sayı = 300;

            string sonuç = sayı switch
            {
                < 300 => "300'den küçük",
                > 300 => "300'den büyük",
                _ => "300'e eşit"
            };

            Console.WriteLine(sonuç);

            /////////////////////////////

            // 3- logical pattern
            
            int sayi = 65;

            string sonuc = sayi switch
            {
                > 10 and < 50 => "10'dan büyük ve 50'den küçük",
                55 or 65 => "55 veya 65",
                not 70 => "70 değil"  // bu default değer gibi. 70 olmayan tüm sonuçlar.
            };

            Console.WriteLine(sonuc);

            // 4- not pattern
            // örnek yok

            
            System.Console.ReadKey();
        }
    }
}