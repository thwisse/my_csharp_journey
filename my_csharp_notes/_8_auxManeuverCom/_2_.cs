namespace _8_auxManeuverCom
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            // break örnek 2

            // Kullanıcıdan alınan sonsuz adet sayı değerlerinden 37'nin katı girildiğinde 
            // sonlanan uygulamayı yazalım.

            while (true)
            {
                Console.Write("Sayı girin: ");
                int sayı = int.Parse(Console.ReadLine());

                if (sayı % 37 == 0)
                {
                    Console.WriteLine("37'nin katı.");
                    break;
                }
            }


            char ch = Console.ReadKey().KeyChar;
        }
    }
}