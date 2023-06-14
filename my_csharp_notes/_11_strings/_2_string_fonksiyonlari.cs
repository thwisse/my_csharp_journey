namespace _11_strings
{
    internal class _2_string_fonksiyonlari
    {
        static void Main2(string[] args)
        {
            // STRING FONKSIYONLARI
            
            //////// Contains

            string metin = "laylaylom galiba sana göre sevmeler";

            if (metin.Contains("göre"))     /// True
            {
                Console.WriteLine("hopaşinanay");
            }
            else
            {
                Console.WriteLine("imam hatipler kapatılsın");
            }

            /////// StartsWith

            Console.WriteLine(metin.StartsWith("lay"));         /// True
            Console.WriteLine(metin.StartsWith("laylay"));      /// True
            Console.WriteLine(metin.StartsWith("laylaylom"));   /// True

            /////// EndsWith

            Console.WriteLine(metin.EndsWith("ler"));           /// True
            Console.WriteLine(metin.EndsWith("meler"));         /// True
            Console.WriteLine(metin.EndsWith("sevmeler"));      /// True

            ///////// Equals

            Console.WriteLine(metin.Equals("hopaşinanay"));         /// False   
            Console.WriteLine(metin.Equals("laylaylom galiba sana göre sevmeler"));  /// True

            ///////// Compare

            string metin2 = "on iki dev adam teyyyoo teyyooo";

            Console.WriteLine(string.Compare(metin2, "zürafa"));        /// -1
            Console.WriteLine(string.Compare(metin2, metin2));          ///  0
            Console.WriteLine(string.Compare(metin2, "atatürk"));       ///  1

            string metin3 = "pn iki dev adam teyyyoo teyyooo";      // ilk harf değişti
            
            Console.WriteLine(string.Compare(metin2, metin3));          /// -1

            string metin4 = "on iki dev adam teyyyoo teyyooox";     // sona harf eklendi

            Console.WriteLine(string.Compare(metin2, metin4));          /// -1

            ///////// CompareTo      (Compare ile neredeyse aynı. yazımı farklı.)

            Console.WriteLine(metin2.CompareTo("zürafa"));      /// -1  
            Console.WriteLine(metin2.CompareTo(metin2));        ///  0
            Console.WriteLine(metin2.CompareTo("atatürk"));     ///  1

            ////////// IndexOf

            string metin_ = "horse washing in  out";

            Console.WriteLine(metin_.IndexOf("ho"));             /// 0
            Console.WriteLine(metin_.IndexOf("horse"));          /// 0
            Console.WriteLine(metin_.IndexOf("in"));             /// 10
            Console.WriteLine(metin_.IndexOf("lemi galip"));     /// -1

            // eğer aynı değerden birden fazla varsa IndexOf için önemsizdir.
            // IndexOf ilk eşleşen değerin indexini döndürecektir.

            ////////// Insert

            string metin_2 = metin_.Insert(17, "and");

            Console.WriteLine(metin_);
            Console.WriteLine(metin_2 + "\n");

            /////////// Remove

            //           0123456789..............
            // metin_2 : horse washing in and out

            // overload 1
            // string string.Remove(int startIndex)

            Console.WriteLine(metin_2.Remove(5));      
            // 5. indexten itibaren (5 dahil) tüm değerleri sil

            // overload 2
            // string string.Remove(int startIndex, int count)

            Console.WriteLine(metin_2.Remove(5, 8));
            // 5'ten sonra 8 karakterlik değeri sil

            ////////// Replace

            string metin_3 = "tak tak takırdama uyumayın ulaaan";

            Console.WriteLine(metin_3);

            // overload 1
            // string string.Replace(char oldChar, char newChar)

            Console.WriteLine(metin_3.Replace('a', '*'));

            // overload 2
            // string string.Replace(string oldValue, string? newValue)

            Console.WriteLine(metin_3.Replace("tak", "XXX"));

            
            ////////// Split

            string metin_4 = "ben seni bir anlık değil, bir ömür boyu ararım";

            // overload 3
            // string[] string.Split(params char[]? separator)

            string[] dizi = metin_4.Split(' ');

            // overload 1
            // string[] string.Split(char separator, int count, 
            // StringSplitOptions options = StringSplitOptions.None) (bu kısmı anlamadım)

            string[] dizi2 = metin_4.Split(' ', 'a');   // hem boşluk hem a.

            // break point ile dizilerin elemanlarini goruntuleyebiliriz.

            System.Console.ReadKey();
        }
    }
}