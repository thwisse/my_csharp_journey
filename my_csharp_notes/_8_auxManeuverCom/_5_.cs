namespace _8_auxManeuverCom
{
    internal class _5_
    {
        static void Main5(string[] args)
        {
            // goto örnek 1

            switch (10)
            {
                case 5:
                    Console.Write(" Tutucu");
                    break;

                case 7:
                    Console.Write("\"thwisse\"");
                    goto case 5;

                case 10:
                    Console.Write("Oğuzhan ");
                    goto case 7;

                default:
                    Console.WriteLine("Hata");
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}