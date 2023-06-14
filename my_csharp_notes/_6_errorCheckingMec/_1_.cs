namespace _6_errorCheckingMec
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            // hata kontrol mekanizmaları

            // 2- çalıştırma zamanı hataları
            // try catch yapılanması
            

            try
            {
                int s1 = 0, s2 = 20;
                int a = s2 / s1;        // 20, 0'a bölünmez. Hata verecek.
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mesaj: " + ex.Message);
            }
            
            try
            {
                int.Parse("thwisse");   // string'i int'e mi çeviricen?
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mesaj: " + ex.Message);
            }

            try
            {
                int s1 = 0, s2 = 20;
                int a = s2 / s1;   
            }
            catch (DivideByZeroException ex)    // özelleştirilmiş exception
            {
                Console.WriteLine("Mesaj: " + ex.Message);
            }
            
            try
            {
                int s1 = 0, s2 = 20;
                int a = s2 / s1;   
            }
            catch (FormatException ex)    // yanlış bir exception girersek runtime hatası alırız
            {
                Console.WriteLine("Mesaj: " + ex.Message);
            }

            System.Console.ReadKey();
        }
    }
}