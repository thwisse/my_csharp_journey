namespace _10_arrays2
{
    internal class _1_ranges_and_indices
    {
        static void Main1(string[] args)
        {
            // ranges and indices (C# 8.0)

            #region System.Index
            
            int[] sayilar = { 3, 5, 87, 54, 6, 989, 4, 13 };

            Index index = 3;  // soldan. 54 elemanı. yani soldan 4. eleman.
            Index index_ = ^5; // sağdan. 54 elemanı. yani sağdan 5. eleman.
            // yani ikisi de aynı elemanı gösteriyor.

            Console.WriteLine(sayilar[index]);  /// 54
            Console.WriteLine(sayilar[index_]); /// 54
            
            #endregion

            #region System.Range
            
            int[] sayilar_ = { 3, 5, 87, 54, 7, 99, 4, 13, 95, 45, 6, 98 };

            // 7 ile 95 aralığındaki sayıları seçmek istiyorum.

            Range range = 4..^3;

            // bunun yerine 4..8 de olabilirdi. veya ^8..^3 de olabilirdi.

            var sayilar2 = sayilar_[range];  // yeni bir dizi oluşturduk ve o aralığı bu diziye attık.

            // sayilar2 dizisi -> 7, 99, 4, 13, 95 elemanlarından oluşuyor.
            
            #endregion

            #region .. operatörü

            Range range_ = ..; // tüm diziye karşılık gelir

            var sayilar3 = sayilar[range_];  // diziyi başka bi diziye kopyaladık.

            ///////////////////////////////////

            int[] sayilar4 = { 3, 5, 87, 54, 7, 99, 4, 13, 95, 45, 6, 98 };

            Index i1 = 4, i2 = ^3;

            Range range4 = i1..i2;

            var sayilar5 = sayilar4[range4];

            ////////////////////////////////////////

            int[] sayilar6 = { 3, 5, 87, 54, 7, 99, 4, 13, 95, 45, 6, 98 };

            Index i1_ = 4, i2_ = ^3;

            var sayilar7 = sayilar6[i1..i2];

            #endregion

            #region ^ operatörü
            
            int[] sayilar8 = { 3, 5, 87, 54, 6, 989, 4, 13 };

            Index i = ^4;  // 6 elemanını i değişkenine atadım.

            Console.WriteLine(sayilar8[i]);

            ////////////////////////////////

            Console.WriteLine(sayilar8[^4]);  // bu da kullanılabilir.
            
            #endregion

            
            System.Console.ReadKey();
        }
    }
}