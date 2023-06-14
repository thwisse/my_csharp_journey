namespace _00_exercises
{
    internal class exercise07
    {
        static void Main7(string[] args)
        {
            //Bir metnin harflerini sirayla duraklayarak yazdirarak matrix havasi yarat.
            
            string metin = "thwisse dosemecilik ltd sti";

            for (int i = 0; i < metin.Length; i++)
            {
                Console.Write(metin[i]);

                System.Threading.Thread.Sleep(200); // 200 milisaniye. 1 saniye 1000 milisaniyedir.
            }
            
            char ch = Console.ReadKey(true).KeyChar;
        }
    }
}