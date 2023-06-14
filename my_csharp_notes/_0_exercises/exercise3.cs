namespace _0_exercises
{
    internal class exercise3
    {
        static void Main3(string[] args)
        {
            //Bilgisayarin random tuttugu 10 sayidan cift ve tek olanlarin sayisini gosteren program. 

            int sayi, tekAdet = 0, ciftAdet = 0;

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                sayi = rnd.Next(1, 100);

                Console.WriteLine(sayi);

                if (sayi % 2 == 0)
                {
                    ciftAdet++;
                }
                else
                {
                    tekAdet++;
                }
            }
            Console.WriteLine("Tek adet: {0}, Cift Adet: {1}", tekAdet, ciftAdet);
            
            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}