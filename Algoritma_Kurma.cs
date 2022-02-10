using System;
namespace Algoritma
{
    public class Algoritma_Kurma
    {
        public int[] SayılarıKaydetme(string[] arr) //Her kelimeden sonra gelen ","den sonraki sayıları yeni bir diziye kaydeden metot.
        {
            int[] s =new int[arr.Length/2];
            int counter=0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if(i%2!=0)
                {
                    s[counter]= int.Parse(arr[i]);
                    counter++;
                }
            }
            return s;
        }
        public string[] GirilenMetniSilme(string[] arr, int[]sayılar)
        {
            string[] FinalCut= new string[arr.Length/2+1];
            int sayac=0; //FinalCut isimli silnmiş cümlelerin dizisi ve SayılarıKaydetme adlı metottan gelecek dizide kullanılacak sayac
                         // 1. cümle - 1. sayı eş güdümlü gideceği için yeni bir değişkenle bu işi kotardım.
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2==0)
                {
                    string disposable = arr[i];
                    FinalCut[sayac]=disposable.Remove(sayılar[sayac], 1); //Burada olduğu gibi yukardaki eş güdümlülük sağlandı
                    sayac++;
                    
                }
            }
            return FinalCut;
        }
        public void SonucYazdırma(string[] arr) //Oluşan yeni kelimeleri GirilenMetniSilme metodundan dönen string diziyle
                                                // parametre alarak kullanacağız ve yazdıracağız.
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}