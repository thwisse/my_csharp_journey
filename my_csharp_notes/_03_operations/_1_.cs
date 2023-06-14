namespace _03_operations
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            bool patates = true, kofte = false;

            Console.WriteLine(patates && kofte);
            Console.WriteLine(patates || kofte);
            Console.WriteLine(patates ^ kofte);

            ///////////////////////////////

            int i = 10;
            Console.WriteLine(i++); // önce yazdır, sonra artır.
            i = 10;
            Console.WriteLine(++i); // önce artır, sonra yazdır.

            /////////////////////////////

            // metinsel + operatörü

            string a = "Oğuzhan", a2 = " Tutucu ";
            Console.WriteLine(a + a2);
            
            int a3 = 21;
            Console.WriteLine(a + a2 + a3); 
            // a3'ü object'e çevirdi ve öyle string toplaması yaptı

            ///////////////////////////////////////////

            // metinsel += operatörü

            string b = "Gençay";
            string b2 = " Yıldız";

            b += b2;

            Console.WriteLine(b);

            ///////////////////////////////////////////

            // metinsel == operatörü

            string c = "Ali", c2 = "Veli";

            bool sonuç = c == c2;
            Console.WriteLine(sonuç);

            // metinsel != operatörü

            bool sonuç2 = c != c2;
            Console.WriteLine(sonuç2);

            ///////////////////////////////////////////

            // ternary operatörü

            bool medeniHal = true;

            string medeniHalSonucu = medeniHal == true ? "Evlisin" : "Bekarsın";

            Console.WriteLine(medeniHalSonucu);

            // 21den küçük ise A, 21 ise B, 21den büyük ise C dönsün
            
            int yaş = 22;

            string ABC = yaş < 21 ? "A" : (yaş == 21 ? "B" : "C");

            Console.WriteLine(ABC);
            
            System.Console.ReadKey();
        }
    }
}