namespace _05_flowControlMec2
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            // örnek 2 (kullanıcı adı ve şifre)

            /*   Girilen kullanıcı adı ve şifre doğru ise giriş başarılı, yanlış ise hatalı 
            mesajı verecek kodu yazın.  */
            
            Console.Write("Kullanıcı adı giriniz: ");
            string kullanıcıAdı = Console.ReadLine();
            Console.Write("Şifre giriniz: ");
            string şifre = Console.ReadLine();

            Console.WriteLine(kullanıcıAdı == "thwisse" && şifre == "123asd" 
            ? "Giriş başarılı." : "Hatalı giriş");
            // ternary operasyonu.
            
            
            System.Console.ReadKey();
        }
    }
}