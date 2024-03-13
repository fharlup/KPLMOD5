using System;

class Fungsi
{
    public enum Buah
    {
        Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung,Kurma,Durian,Anggur,Melon,Semangka
    }
    public enum Kode
    {
         A00,B00,C00,D00,E00,F00,G00,H00,I00,J00,K00,L00,M00,N00,O00
        
     
    };

    static void Main(string[] args)
    {
        foreach (Buah buah in Enum.GetValues(typeof(Buah)))

        {
            {
                foreach (Kode kode in Enum.GetValues(typeof(Kode)))
                {
                    Console.WriteLine(buah);
                    Console.WriteLine(kode);
                 

                }
            } }

    }
}