namespace _06_errorCheckingMec
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            try
            {
                //int.Parse("thwisse");   // string'i int'e mi çeviricen?

                int s1 = 0, s2 = 20;
                int a = s2 / s1;        // 20, 0'a bölünmez. Hata verecek.
            }
            catch (FormatException ex)
            {
                Console.WriteLine("For.Ex. Mesajı: " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Div.ByZ. Mesajı: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bilinmeyen türdeki hatanın Mesajı: " + ex.Message);
            }

            System.Console.ReadKey();
        }
    }
}