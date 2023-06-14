namespace _4_flowControlMec
{
    internal class _1_
    {
        static void Main1(string[] args)
        {
            // switch-case

            // örnek 1 (switch-case basic)

            Console.WriteLine("Anadolu tat");
            short anadoluTat = 1071;

            switch (anadoluTat)
            {
                case 1881:
                    Console.WriteLine("Atatürk doğdu");
                    break;

                case 1938:
                    Console.WriteLine("Atatürk vefat etti");
                    break;

                case 1071:
                    Console.WriteLine("binn yetmiş birrr");
                    break;

                default:
                    Console.WriteLine("Olmaz öyle saçma değer");
                    break;
            }

            /////////////////////////////

            // örnek 2 (when)

            Console.WriteLine("Tanrı var mı?");
            Console.WriteLine("Var diyorsan true, Yok diyorsan false yazman yeterli.");

            string tanrı = Console.ReadLine();
            bool _tanrı = bool.Parse(tanrı);

            switch (_tanrı)
            {
                case true:

                    Console.WriteLine("Tanrı var.");
                    break;

                case false when (2 + 2 == 4):

                    Console.WriteLine("Tanrı yok.");
                    break;

                default:

                    Console.WriteLine("Moruk sarhoş musun ya?");
                    break;
            }

            /////////////////////////

            // örnek 3 (goto)

            int sayı = 1;

            switch (sayı)
            {
                case 1:

                    Console.WriteLine("1");
                    goto case 3;

                case 2:

                    Console.WriteLine("2");
                    goto case 7;

                case 3:

                    Console.WriteLine("3");
                    goto case 2;

                case 7:

                    Console.WriteLine("7");
                    break;
            }

            System.Console.ReadKey();
        }
    }
}