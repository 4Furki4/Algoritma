using System;
namespace Algoritma
{
    public class Konsol_Islemleri
    {
       public void GirdiMesajı()
       {
           Console.Write("Lütfen aralarında boşluk olacak şekilde önce bir kelime ve sonra sayı giriniz:");
       }
       public string[] GirdiyiDiziyeAtma() //Metot ismi CumleAlma'dan GirdiyiDiziyeAtma'ya dönüştürüldü.
       {
           string st = Console.ReadLine();
           return st.Split(","); //Kelime ve sayıların arasında "," olacağı için , ile ayırıp oluşan diziyi döndürdüm.
       } 
    }
}