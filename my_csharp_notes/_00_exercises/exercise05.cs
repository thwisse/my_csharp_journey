namespace _00_exercises
{
    internal class exercise05
    {
        static void Main5(string[] args)
        {
            x:

            // Girilen sayinin asal olup olmadigini bulan program.

            Console.Write("Sayiyi girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 2)
            {
                Console.WriteLine("Sayi asal degildir.");

                //System.Console.ReadKey();
                //Environment.Exit(0);          // kodu sonlandirmak icin kullandim.

                goto x;     // tum sayilari test etmek icin goto kullandim.
            }

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
            {
                Console.WriteLine("Sayi asal degildir.");
            }
            else
            {
                Console.WriteLine("Sayi asaldir.");
            }

            goto x;         // tum sayilari test etmek icin goto kullandim.
            
            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}