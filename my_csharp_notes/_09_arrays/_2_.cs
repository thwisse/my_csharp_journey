namespace _09_arrays
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            // dizi tanımlama varyasyonları

            // 1    (klasik)

            int[] yaşlar = new int[5];

            yaşlar[0] = 22;
            yaşlar[3] = 14;

            // 2    (kaç tane değer girersen, dizi o kadar eleman sayısına sahip olacak)

            string[] ruhsuzGames = { "Oğuzhan", "Ramazan", "Kaan" };
            // kaç tane değer girersen, dizi o kadar eleman sayısına sahip olacak.

            // 3    (üsttekinin farklı bir kullanımı)

            string[] türkBeşleri = new string[] { "Hasan", "Ulvi", "Cemal", "Ahmet", "Necil" };

            // 4    (yine üsttekinin farklı kullanımı)
            // ancak burada girdiğin eleman sayısı kadar değer girebiliyorsun. 
            // bir sınır belirlemiş oluyosun.

            long[] tcKNo = new long[3] { 54313878676, 98753454396, 68643516488 };

            // 5    (atama operatörü sonrası bu şekilde yazılabilir)

            int[] tarihler = new[] { 1881, 1938 };

            // 6    (üsttekinin var kullanarak oluşturulmuş hali. başta indexer yok.)

            var sayılar = new[] { 78, 79, 80 };

            var burçlar = new[] { "Terazi", "Kova", "Boğa" };

            ///////////////////////////////////////

            // dizi formatı seçimi

            int[] diziOrnek = new int[6];
            // genellikle bu format algoritmalarda tercih edilir. çünkü indexer
            // algoritmalarda çok kullanılır. operatif kullanım.

            Array diziOrnek2 = new int[6];
            // bu format ise genellikle elimizdeki dizinin üzerinde işlem yapmak için kullanılır.
            // dizi hakkında bilgi edinirken vs. kullanılır. fonksiyonel kullanım.

            ////////////////////////////////////////

            // SetValue ve GetValue fonksiyonu

            //Array türünden dizilere değer atama / değer okuma
            
            /////////////////// ATAMA

            // 1. yöntem    (klasik. pek kullanışlı değil.)

            int[] dizi = new int[3];
            dizi[0] = 10;
            dizi[1] = 20;
            dizi[2] = 30;

            Array dizi_ = dizi;

            // 2. yöntem(ler)   (varyasyonlar. yine pek kullanışlı değil.)

            //Array dizi = { 10, 20, 30 };  // BU KULLANILAMAZ

            Array dizi2a = new int[] { 10, 20, 30 };

            Array dizi2b = new int[3] { 10, 20, 30 };

            Array dizi2c = new[] { 10, 20, 30 };

            // 3. yöntem    (SetValue fonksiyonu. kullanışlı.)

            Array dizi3 = new int[3];

            dizi3.SetValue(10, 0);
            dizi3.SetValue(20, 1);
            dizi3.SetValue(30, 2);

            //////////////// OKUMA    (GetValue fonksiyonu.)

            object value3 = dizi3.GetValue(0);
            Console.WriteLine(value3);              /// 10



            char ch = Console.ReadKey().KeyChar;
        }
    }
}