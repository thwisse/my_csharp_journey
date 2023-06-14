namespace _8_auxManeuverCom
{
    internal class _4_
    {
        static void Main4(string[] args)
        {
            // return örnek 1
            // Kullanıcı 'c' tuşuna basana kadar sonsuz döngüde dönen kodu yazın.
            
            while (true)
            {
                if (Console.ReadKey().KeyChar == 'c')
                {
                    Console.WriteLine(" Uygulama sona erdi.");
                    System.Console.ReadKey();       // for vscode
                    return;
                }

                Console.WriteLine(" Uygulama çalışıyor...");
            }

            char ch = Console.ReadKey().KeyChar;
        }
    }
}