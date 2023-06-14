namespace _02_typeConversion
{
    internal class _1_
    {
        static void Main(string[] args)
        {
            string y = "123";

            short y2 = short.Parse(y);       // parse

            Console.WriteLine(y2 + 321);

            ///////////////////////////////////////

            // convert

            string z = "69";

            int z2 = Convert.ToInt32(z);

            Console.WriteLine(z2 + 31);

            ///////////////////////////////////////

            string k = "3,14";
            // double'a çevireceğin zaman stringdeyken sayı virgüllü olmalı

            Console.WriteLine(Convert.ToDouble(k) + 1.86);
            // ama böyle kodun içinde bir işlem yaparken nokta kullanırsın 

            int L = 1881;       // convert

            Console.WriteLine(Convert.ToString(L));

            ///////////////////////////////////////

            // direkt ToString

            float m = 4.86F;

            string m2 = m.ToString();

            Console.WriteLine(m2);

            ///////////////////////////////////////

            int p = 9000;

            float r = p;    // bilinçli tür dönüşümü

            ///////////////////////////////////////

            int s = 4000;

            short s2 = (byte)s; // (byte)s ile bilinçli, short'a atayarak bilinçsiz
            // tür dönüşümü yapıldı.

            ///////////////////////////////////////

            checked
            {    
                int ş = 120;        // şu an hata olmaz. 500 yap hata olur.

                byte ş2 = (byte)ş;

                Console.WriteLine(ş2);
            }

            unchecked
            {    
                int ş = 500;        // veri kaybı var ama göz ardı ediliyor.

                byte ş2 = (byte)ş;

                Console.WriteLine(ş2);
            }

            ////////////////////////////////////

            bool b = true;

            int b2 = Convert.ToInt32(b);
            decimal b3 = Convert.ToDecimal(b); // herhangi bir sayısal türe dönüşebilir.

            Console.WriteLine(b2);
            Console.WriteLine(b3);

            ////////////////////////////////////

            int c = 0;      // false sadece 0 dır.
            decimal c2 = 1;
            float c3 = -40.0F;      // negatif de true sayılır.
            long c4 = 4000;

            bool a = Convert.ToBoolean(c);
            bool a2 = Convert.ToBoolean(c2);
            bool a3 = Convert.ToBoolean(c3);
            bool a4 = Convert.ToBoolean(c4);

            Console.WriteLine(a);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
            Console.WriteLine(a4);

            ///////////////////////////////////////

            char o = 'o'; // ascii tabloda 111. sayıya denk gelen karakter.
            
            int o2 = (int)o;

            Console.WriteLine(o2);

            ////////////////////////////////////

            long d_ascii = 100;
            long D_ascii = 68;

            Console.WriteLine((char)d_ascii);
            Console.WriteLine((char)D_ascii);

            System.Console.ReadKey(); // For VSCode's externalTerminal.
        }
    }
}