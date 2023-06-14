namespace _00_exercises
{
    internal class exercise06
    {
        static void Main6(string[] args)
        {
            //Vucut kitle indeksini hesaplayan program.
            
            double boy, kilo, vke;

            Console.Write("Kilonuzu giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Boyunuzu giriniz (Ornek: 1,79): ");
            boy = Convert.ToDouble(Console.ReadLine());

            vke = kilo / (boy * boy);

            Console.WriteLine("Vucut kitle endeksiniz: " + vke);

            if (vke < 18)
                Console.WriteLine("Kilo durumunuz: Zayıf");
            else if (vke >= 18 && vke < 25)
                Console.WriteLine("Kilo durumunuz: Normal");
            else if (vke >= 25 && vke < 30)
                Console.WriteLine("Kilo durumunuz: Kilolu");
            else if (vke >= 30 && vke < 35)
                Console.WriteLine("Kilo durumunuz: Obez");
            else if (vke >= 35)
                Console.WriteLine("Kilo durumunuz: Ciddi Obez");
            else
                Console.WriteLine("Hatalı hesaplama. Lutfen tekrar deneyin.");
            
            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}