namespace _0_exercises
{
    internal class exercise02
    {
        static void Main2(string[] args)
        {
            //Kullanicinin girdigi 10 sayidan 50 den kucuk olanlarin adetini bulan ve gosteren program.
            
            int sayi, adet = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}. sayiyi girin: ", i+1);

                sayi = Int32.Parse(Console.ReadLine());

                if (sayi < 50)
                {
                    adet++;
                }
            }
            Console.WriteLine("Girilen sayilardan 50'den kucuk olanlarin adedi: {0}", adet);
            
            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}