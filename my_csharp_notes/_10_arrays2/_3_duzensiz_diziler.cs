namespace _10_arrays2
{
    internal class _3_duzensiz_diziler
    {
        static void Main3(string[] args)
        {
            // duzensiz diziler

            // int[][]  =  int[] türünde bir dizi anlamına gelir

            int[][] sayilar = new int[3][];

            sayilar[0] = new int[3] {3, 5, 7};
            sayilar[1] = new int[6] {1, 2, 4, 9, 10, 77};
            sayilar[2] = new int[2] {69, 50};
            

            Console.WriteLine(sayilar[0][0]);   /// 3
            sayilar[0][0] = 30;
            Console.WriteLine(sayilar[0][0]);   /// 30

            //////////////////////////////////

            // düzensiz dizilerde lenght öğrenme
 
            Console.WriteLine(sayilar.Length);          /// 3
            // bu sayilar'in lenghti. ben bunu istemiyorum.

            Console.WriteLine(sayilar[0].Length + sayilar[1].Length + sayilar[2].Length);   /// 11
            // işte bu şekilde tüm dizilerin eleman sayısı öğrenilebilir.
            // eğer içerisinde dizi çoksa tek tek yazmak yerine döngü ile öğrenilebilir.
            
            ///////////////////////////////////

            // düzensiz dizileri iç içe döngülerle kullanma

            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = 0; j < sayilar[i].Length; j++)
                {
                    Console.Write(sayilar[i][j] + "       ");
                }
                Console.WriteLine("");
            }


            System.Console.ReadKey();
        }
    }
}