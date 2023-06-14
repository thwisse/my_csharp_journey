namespace _1_variables
{
    internal class _1_
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worlddd!");

            //////////////////////////////////////

            //todo yapilacak sey
            //todo daha sonra yap

            ////////////////////////////////////

            bool medeniHal;
            string soyad;
            string TCNo;

            medeniHal = true;

            float X = 3.14f;

            double Y = 45.689d;     // double'da yazmasan da olur

            decimal Z = 10.0m;

            soyad = "tutucu";

            TCNo = "12345678901";

            ///////////////////////////////////////////////

            // tuple degisken

            (int a, int b) t = (10, 30);

            t.a = 20;
            t.b = 40;

            (int age, string name, bool maritalStatus) person = (21, "Oguzhan", false);

            person.age = 50;
            person.name = "Meryem";
            person.maritalStatus = true;

            ////////////////////////////////////////////

            int sayi = 1_000_000_000;

            //////////////////////////////////////

            bool j = default(bool);

            char o = default(char);

            int k = default;        // ikisi de olur.

            ///////////////////////////////////////////

            int u = 5;

            u = u;  // u'nun stack'teki degeri 5 idi. burada ise o deger silindi ve
                    // yerine tekrardan 5 degeri koyuldu

            ////////////////////////////////////////////////

            // sabit = const

            const double pi = 3.14;

            /////////////////////////////////////////

            object _yas = 10;   // boxing

            int yas = (int)_yas;    // unboxing

            Console.WriteLine(yas);

            ///////////////////////////////////////

            var a = 5;

            dynamic _a = 5;

            a.ToString();  // kodu yazarken tanidi.

            _a.ToString();  // runtime aninda tanidi

            Console.WriteLine(a.GetType());
            Console.WriteLine(_a.GetType());

            ///////////////////////////////////////

            dynamic x = "Ahmet";

            Console.WriteLine(x.GetType()); // string

            x = 3.14D;

            Console.WriteLine(x.GetType()); // double

            System.Console.ReadKey(); // For VSCode's externalTerminal.
        }
    }
}