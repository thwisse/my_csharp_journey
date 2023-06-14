namespace _04_flowControlMec
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            // switch expressions

            // expression 1 (tek satırlık işlemler için yeni yöntem)

            // eski yöntem
            
            string isim = "";   // boş string başlatmak için macro.
            int i = 9;

            switch (i)
            {
                case 4 :
                    isim = "Ramazan";
                    break;

                case 8 : 
                    isim = "Kaan";
                    break;

                case 9 :
                    isim = "Oğuzhan";
                    break;
            }
            
            // yeni yöntem
            
            int j = 9;

            string isimm = j switch
            {
                4 => "Ramazan",
                8 => "Kaan",
                9 => "Oğuzhan"
            };

            System.Console.ReadKey();
        }
    }
}