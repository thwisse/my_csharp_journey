namespace _4_flowControlMec
{
    internal class _5_
    {
        static void Main5(string[] args)
        {
            // expression 4 (tuple patterns + değişken + when)
            
            string name = "Şamil";
            int age = 19;

            string mesaj = (name, age) switch
            {
                ("Oğuzhan", 21) => "Selam Oğuzhan",

                ("Mansur", 58) when (2022 > 2021) => "Selam Mansur",

                var x when x.name == "Beyjan" && x.age == 18 => "Selam Beyjan",

                var x when x.name == "Şamil" && x.age == 19 && (10 == 10) => "Selam Şamil",

                //(_, _) => "Hata"

                _ => "Hata"     // ikisi de olur, fark etmez
            };
            Console.WriteLine(mesaj);

            System.Console.ReadKey();
        }
    }
}