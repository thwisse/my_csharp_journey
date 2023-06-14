namespace _5_flowControlMec2
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            // if yapılanması

            // örnek 1 (indirim uygula)

            /*   Kullanıcıdan iki sayı al. Eğer toplam 200den büyükse 2. ürüne 
            %25 indirim yap ve toplamı öyle yazdır. 200'den küçükse indirim uygulamadan toplamı ver  */
            
            // writeline bi satır aşağı çeker, write ta ise o satırda kalır
            Console.Write("İlk sayıyı girin: ");     
            string _sayı1 = Console.ReadLine();
            Console.Write("İkinci sayıyı girin: ");
            string _sayı2 = Console.ReadLine();

            int sayı1 = int.Parse(_sayı1);
            int sayı2 = int.Parse(_sayı2);
            
            // şu üsttekileri yaratmadan da yapabilirsin :
            //int sayı = int.Parse(Console.ReadLine());   

            int tutar = sayı1 + sayı2;

            if (sayı1 + sayı2 >= 200)
            {
                Console.WriteLine("İndirim uygulandı.");
                tutar = sayı1 + (sayı2 - sayı2*25/100);
            }
            else if (sayı1 + sayı2 < 200)
            {
                Console.WriteLine("İndirim uygulanmadı. Toplam 200'den küçük.");
            }
            Console.WriteLine("Tutar: " + tutar);
            
            
            System.Console.ReadKey();
        }
    }
}