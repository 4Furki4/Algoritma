using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri Konsol =new Konsol_Islemleri();
            Algoritma_Kurma Alg= new Algoritma_Kurma();
            Konsol.GirdiMesajı();
            
            string[] CumleVeSayı=Konsol.GirdiyiDiziyeAtma();
            int[] sayılar=Alg.SayılarıKaydetme(CumleVeSayı);
            string[] silinmisCumleler=Alg.GirilenMetniSilme(CumleVeSayı,sayılar);
            Alg.SonucYazdırma(silinmisCumleler);
        }
    }
}
