namespace _10_arrays2
{
    internal class _2_multidimensional_arrays
    {
        static void Main2(string[] args)
        {
            // multidimensional arrays (cok boyutlu diziler)

            
            int[] array = new int[5];           // tek boyutlu
            int[,] array2 = new int[5, 2];      // iki boyutlu

            int[,,] array3 = new int[2, 3, 4];  // üç boyutlu

            
            //a,b,c,d     // sırasıyla: kat, satır, sütun.
            //a,b,c,d                    2     3      4
            //a,b,c,d
            //
            //a,b,c,d
            //a,b,c,d
            //a,b,c,d
            

            // matristeki bir değişkene değer atama

            array3[0, 0, 0] = 10;
            array3[0, 0, 1] = 11;
            array3[0, 0, 2] = 12;
            array3[0, 0, 3] = 13;

            array3[0, 1, 0] = 20;
            array3[0, 1, 1] = 21;
            array3[0, 1, 2] = 22;
            array3[0, 1, 3] = 23;

            // ... bu şekilde gider.

            ///////////////////////////////////////

            // değer atamanın farklı bir varyasyonu

            int[,] sayılar =
            {                               //     0  1  2
                {3, 5, 7},                  //  0 
                {2, 4, 6},                  //  1
                {89, 9, 35},                //  2
                {8, 3599, 69}               //  3        69
            };

            //Console.WriteLine(sayılar[3, 2]);    /// 69

            ////////////////////////////////

            int[,,] sayilar = new int[2, 2, 4];

            sayilar[0, 0, 0] = 1;
            sayilar[0, 0, 1] = 2;
            sayilar[0, 0, 2] = 3;
            sayilar[0, 0, 3] = 4;
            sayilar[0, 1, 0] = 5;
            sayilar[0, 1, 1] = 6;
            sayilar[0, 1, 2] = 7;
            sayilar[0, 1, 3] = 8;
            sayilar[1, 0, 0] = 9;       
            sayilar[1, 0, 1] = 10;
            sayilar[1, 0, 2] = 11;
            sayilar[1, 0, 3] = 12;
            sayilar[1, 1, 0] = 13;
            sayilar[1, 1, 1] = 14;
            sayilar[1, 1, 2] = 15;
            sayilar[1, 1, 3] = 16;           

            for (int i = 0; i < sayilar.GetLength(0); i++)
            {
                for (int j = 0; j < sayilar.GetLength(1); j++)
                {
                    for (int k = 0; k < sayilar.GetLength(2); k++)
                    {
                        Console.Write(sayilar[i, j, k] + "          ");
                    }
                    Console.WriteLine("");
                }
            }

            System.Console.ReadKey();
        }
    }
}