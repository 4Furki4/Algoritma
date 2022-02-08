using System;
namespace Algoritma
{
    public class Konsol_Islemleri
    {
       public void GirdiMesajı()
       {
           Console.Write("Lütfen aralarında boşluk olacak şekilde bir kelime ve sayı giriniz.");
       }
       public string[] CumleAlma()
       {
           string st = Console.ReadLine();
           return st.Split(",");
       } 
    }
}