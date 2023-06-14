namespace _5_flowControlMec2
{
    internal class _4_
    {
        static void Main4(string[] args)
        {
            // 2- constant pattern
            
            object x = "Oğuzhan Tutucu";

            if (x is "thwisse")
                Console.WriteLine("Nick");
            else if (x is "Oğuzhan")
                Console.WriteLine("İsim");
            else if (x is "Oğuzhan Tutucu")
                Console.WriteLine("İsim Soyisim");
            

            object y = 1881;

            if (y is 1938)
                Console.WriteLine("Vefat");
            else if (y is 1923)
                Console.WriteLine("Cumhuriyet");
            else if (y is 1881)
                Console.WriteLine("Doğum");
            

            object z = true;

            if (z is false)                 // bu iki if değer bazında is içeriyor
                Console.WriteLine("False");
            else if (z is true)
                Console.WriteLine("True");
            if (z is bool)                  // bu if ise tür bazında is içeriyor
                Console.WriteLine("Boolean");
            

            int a = 15;

            Console.WriteLine(a is int);        /// true
            Console.WriteLine(a is bool);       /// false
            Console.WriteLine(a is char);       /// false

            ////////////////////////////

            // 3- var pattern
            
            object cinsiyet = "Erkek";

            if (cinsiyet is var a)
                Console.WriteLine(a);
            
            System.Console.ReadKey();
        }
    }
}