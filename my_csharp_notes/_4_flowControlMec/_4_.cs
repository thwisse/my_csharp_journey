namespace _4_flowControlMec
{
    internal class _4_
    {
        static void Main4(string[] args)
        {
            // expression 3 (tuple patterns)
            
            // eski yöntemde
            
            string name = "Richard";
            int age = 32;
            string mesaj = "";

            switch (name, age)
            {
                case ("Oğuzhan", 21) :
                    mesaj = "Tutucu";
                    break;

                case ("Meryem", 49) :
                    mesaj = "Yılmaz";
                    break;

                case ("Richard", 31) :
                    mesaj = "Thomas";
                    break;

                default :           
                    // tuple'daki iki değer de eşleşmezse bu default'a düşecektir
                    mesaj = "Hata";
                    break;
            }
            Console.WriteLine(mesaj);
            
            
            // yeni yöntemde
            
            string namee = "Richard";
            int agee = 31;

            string mesajj = (namee, agee) switch
            {
                ("Oğuzhan", 21) => "Tutucu",
                ("Meryem", 49) => "Yılmaz",
                ("Richard", 31) => "Thomas",
                (_, _) => "Hata"
            };
            Console.WriteLine(mesajj);

            System.Console.ReadKey();
        }
    }
}