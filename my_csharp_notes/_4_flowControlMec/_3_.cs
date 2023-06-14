namespace _4_flowControlMec
{
    internal class _3_
    {
        static void Main3(string[] args)
        {
            // expression 2 (yeni yöntemde değişken ve when kullanımı)
            
            // when ve var kullanımı

            int i = 9;

            string isim = i switch
            {
                4 => "Ramazan",
                8 when (3 == 5) => "Kaan",
                int x when x == 1 => "Carteeel", 
                // türü kendimiz de belirleyebiliriz
                var x when (x == 7) && (x % 2 == 1) => "Oğuzhan", 
                // var ile compiler'a da belirletebiliriz
                var x => "Hiçbiri"    // bu default yerine geçer
            //  _ => "Hiçbiri"        // bu da üstteki ile aynı işlemi yapar
            };

            Console.WriteLine(isim);

            System.Console.ReadKey();
        }
    }
}