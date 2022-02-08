using System;
namespace Algoritma
{
    public class Algoritma_Kurma
    {
        public int[] SayılarıKaydetme(string[] arr)
        {
            int[] s =new int[arr.Length/2];
            int counter=0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if(i%2!=0)
                {
                    s[counter]= int.Parse(arr[i]);
                }
            }
            return s;
        }
        public string[] GirilenMetniSilme(string[] arr, int[]sayılar)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2==0)
                {
                    arr[i].Remove(sayılar[i],sayılar[i+1]);
                }
            }
            return arr;
        }
    }
}