namespace _00_exercises
{
    internal class exercise04
    {
        static void Main4(string[] args)
        {
            //2 – 100 arasindaki asal sayilari listeleyen program

            // asal sayi: yalnizca 1'e ve kendisine bolunebilen sayilar.
            // bu yuzden 2. for'da kendinden onceki sayilara bolunuyor mu diye kontrol ediyoruz.
            
            int sayac = 0;

            for (int sayi = 2; sayi <= 100; sayi++)
            {
                int kontrol = 0;

                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        kontrol = 1;
                        break;
                    }
                }

                if (kontrol == 1)
                    Console.WriteLine("{0} asal degildir.", sayi);
                else
                {
                    Console.WriteLine("{0} asaldir.", sayi);
                    sayac++;
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine("{0} adet asal sayi var.", sayac);
            
            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}