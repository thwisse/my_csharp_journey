namespace _11_strings
{
    internal class _3_ornekler
    {
        static void Main3(string[] args)
        {
            // Ornek 1
            
            // Kullanicinin girdigi metinde kac adet 'n' karakterinin oldugunu bulan program.

            Console.Write("Lutfen metni giriniz: ");
            string metin = Console.ReadLine();

            int cnt = 0; // counter

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] == 'n')
                    cnt++;
            }
            
            Console.WriteLine("n sayisi: " + cnt);

            ////////////////////////////////////////////////

            // Ornek 2
            
            // Girilen metindeki kelime sayisini hesaplayan kodu yazin.

            Console.Write("Metin giriniz: ");
            string metin2 = Console.ReadLine();

            string[] dizi = metin2.Split(' ');

            Console.WriteLine(dizi.Length);

            System.Console.ReadKey();
        }
    }
}            
            
            
            
            
            