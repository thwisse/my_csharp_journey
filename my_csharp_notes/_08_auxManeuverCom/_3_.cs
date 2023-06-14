namespace _08_auxManeuverCom
{
    internal class _3_
    {
        static void Main3(string[] args)
        {
            // continue örnek 1

            // Kullanıcının girdiği sonsuz adet sayıdan pozitif ve çift olanlarını çarpan ve t (enter)
            // yapıldığında sonucu ekrana yazdıran kodu yazalım.

            int çarpım = 1;

            Console.WriteLine("Ya sayı gir ya da çıkmak için t harfini gir.");

            while (true)
            {
                Console.Write("Sayı ya da t gir: ");
                string girilenDeger = Console.ReadLine();

                if (girilenDeger == "t")
                {
                    Console.WriteLine("Çarpım: " + çarpım);
                    break;
                }

                int sayı = int.Parse(girilenDeger);

                if (sayı < 0 || !(sayı % 2 == 0))
                {
                    continue;
                }

                çarpım *= sayı;
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}