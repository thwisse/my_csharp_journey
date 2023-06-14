namespace _03_operations
{
    internal class _2_
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");

            //string _sayı = Console.ReadLine();
            //int sayı = int.Parse(_sayı);
            
            int sayı = int.Parse(Console.ReadLine());   // üsttekinin kısa hali.

            int cevap = (sayı < 3) ? sayı*5 : 
                        ((sayı > 3 && sayı < 9) ? sayı*3 : 
                        ((sayı >= 9 && sayı % 2 == 0) ? sayı*10 : 
                        ((sayı % 2 == 1) ? sayı : 0000)));

            Console.WriteLine(sayı);
            
            System.Console.ReadKey();
        }
    }
}