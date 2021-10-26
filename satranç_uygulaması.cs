/******************************************************************************************************************************************************************************************************
**                                                                             SAKARYA ÜNİVERSİTESİ 
**                                                                    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                                                                       BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                                                                      NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                                                            2020-2021 BAHAR DÖNEMİ
**                                                                              İLAYDA YILMAZ
******************************************************************************************************************************************************************************************************/
using System;

namespace ndp_ödev1_soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[8, 8]; //  8x8lik int dizi oluşturdum.
            Random rnd = new Random(); //random 
            for (int i = 0; i < 8; i++) //8den küçük olacak şekilde for döngüsü kurdum.
            {
                for (int j = 0; j < 8; j++)  //8den küçük olacak şekilde for döngüsü kurdum
                {
                    Console.Write("0"); //8x8lik matrisin tüm elemanlarına 0 yazdırdım.
                }
                Console.WriteLine();
            }
            for (int y = 0; y < 8; y++) //8den küçük olacak şekilde for döngüsü kurdum.
            {
                int x = rnd.Next(0, 8); //random belirlenecek bir x değişkeni yazdım.
                Console.SetCursorPosition(x,y); //x ve y koordinatlarını belirledim.
                Console.Write("k"); //belirlediğim koordinatlara k harfini yazdırdım.
                Console.WriteLine();
                Console.ReadKey(); 
                
            }
        }
    }
}
