namespace _08_auxManeuverCom
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            // yardımcı manevratik komutlar  // auxiliary maneuver commands

            // break örnek 1
            
            // kullanıcıdan t harfi girene kadar alınan sınırsız sayıda sayıyı toplayan ve sonucu
            // ekrana yazdıran uygulamayı yazalım.

            int toplam = 0;

            Console.WriteLine("Ya sayı gir ya da çıkmak için t harfini gir.");

            while (true)
            {   
                Console.Write("Sayı ya da t gir: ");
                string girilenDeger = Console.ReadLine();

                if (girilenDeger == "t")
                {
                    Console.WriteLine("Toplam: " + toplam);
                    break;
                }

                toplam += int.Parse(girilenDeger);
            }
            
            char ch = Console.ReadKey().KeyChar;
        }
    }
}