namespace _11_strings
{
    internal class _1_strings
    {
        static void Main1(string[] args)
        {
            // STRING'LERE GIRIS
            
            ///////////// string.Empty

            string a = "";

            string _a = string.Empty;

            // bu ikisi aynı şeydir. değişkeni empty olarak başlatır.

            /////////// IsNullOrEmpty

            string x = string.Empty;

            // x != null    ile    x is not null    aynı şeydir

            if (x != string.Empty && x is not null)
            {
                // hem bos degil hem de null degil ise
            }

            if (!string.IsNullOrEmpty(x))
            {
                Console.WriteLine(x);  /// bir şey yazdırmadı. çünkü empty.
            }
            // IsNullOrEmpty:
            // x null veya empty ise true dönecektir, ikisi de değilse false dönecektir

            /////////////// IsNullOrWhiteSpace

            string y = "thwisse";

            if (!string.IsNullOrWhiteSpace(y)) // true
            {
                Console.WriteLine(y);       /// thwisse
            }

            /////////////// bir Array olarak string'ler

            string metin = "thwisse";

            Console.WriteLine(metin[4]);

            Console.WriteLine(metin.Length);

            Console.WriteLine("////////////////////////////");

            /////////////////  stringleri döngüde kullanmak

            string metin2 = "sebepsiz boş yere ayrılacaksan";

            for (int i = 0; i < metin2.Length; i++)
            {
                if (metin2[i] == 'e')
                {
                    Console.WriteLine(i + " - e");
                }
                if (metin2[i] == 'a')
                {
                    Console.WriteLine(i + " - a");
                }
            }

            //////// string + herhangi bir tür

            Console.WriteLine("41 kere" + " marshmellow");

            Console.WriteLine(21 + 8 + 12 + " kere marshmellow");

            //////////// string formatlama

            string isimSoyisim = "Oğuzhan Tutucu";
            int yaş = 21;
            long tckn = 12345678910;
            bool medeniHal = false;

            // klasik. maliyetli.
            Console.WriteLine("TCKN: " + tckn + " İsim Soyisim: " + isimSoyisim + " Yaş: "
            + yaş + " Medeni hal: " + (medeniHal ? "Evli" : "Bekar"));

            // string.Format 1. kullanım
            string veri = string.Format("TCKN: {0} İsim Soyisim: {1} Yaş: {2} Medeni hal: {3}",
            tckn, isimSoyisim, yaş, (medeniHal ? "Evli" : "Bekar"));

            Console.WriteLine(veri);

            // string.Format 2. kullanım
            Console.WriteLine(string.Format("TCKN: {0} İsim Soyisim: {1} Yaş: {2} Medeni hal: {3}",
            tckn, isimSoyisim, yaş, (medeniHal ? "Evli" : "Bekar")));

            // string.Format'sız kullanım
            Console.WriteLine("TCKN: {0} İsim Soyisim: {1} Yaş: {2} Medeni hal: {3}",
            tckn, isimSoyisim, yaş, (medeniHal == true ? "Evli" : "Bekar"));

            // string interpolation (C# 6.0)
            Console.Write($"TCKN: {tckn} İsim Soyisim: {isimSoyisim} Yaş: {yaş}");
            Console.WriteLine($" Medeni hal: {(medeniHal == true ? "Evli" : "Bekar")}");

            Console.WriteLine($"Ben {12 + 9} yaşındayım"); // böyle de kullanılabilir.


            ////////////////// string değerlerde (escape) kaçış karakterleri

            Console.WriteLine("\"Aşk en büyük yalaaannnsa ben en büyük yalaaaancı\"");
            Console.WriteLine("Gençay \\ Yıldız");
            Console.WriteLine("\a");    // bip sesi :d
            Console.WriteLine("A\nT\nA\nT\nÜ\nR\nK");
            Console.WriteLine("İsim \t\t Soyisim \t\t Adres \t\t Tel no");
            char j = '\'';
            Console.WriteLine(j);   // ' karakterini kullanmak icin \ karakterinden yardim aldik

            ///////////////// stringlerde @ (verbatim strings) operatörü

            // 1. kullanım
            int @namespace = 69;
            string @void = "boş";
            long @long = 8795;

            // 2. kullanım
            string metin_ = @"-ismi nedir bu güzelliğin? +""selahattin"".";
            Console.WriteLine(metin);

            // 3. kullanım
            string metin_2 = "yaptığına " +
                            "şantaj derler " +
                            "böyle aşka " +
                            "montaj derler";
            Console.WriteLine(metin2);

            string _metin2 =
            @"
            yaptığına 
            şantaj derler 
            böyle aşka 
            montaj derler";
            Console.WriteLine(_metin2);

            // string interpolation ve verbatim strings'i birlikte kullanmak

            // once @ isareti, daha sonra $ isareti gelmelidir.

            string isim = "Selahattin", soyisim = "Beyazsaray", siparisNo = "23598";
            int fiyat = 250;

            string mailMessage =
            @$"
            Merhaba {isim} {soyisim}.
            {siparisNo} nolu siparişiniz hazırlanmaya başlamıştır.
            Toplam tutar {fiyat} olarak hesaplanmıştır.";

            Console.WriteLine(mailMessage);

            System.Console.ReadKey();
        }
    }
}