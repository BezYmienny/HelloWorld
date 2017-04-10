using System;

namespace SystemZlecen
{
    public class ZadaniaPracownikow
    {
          internal DokumentEz WystawiaZlecenie(string DaneWejsciowe,int pid)
        {
                DokumentEz opracowanyDokument= new DokumentEz(DaneWejsciowe,pid);
                Console.WriteLine("WystawiaZlecenie -> {0}",DaneWejsciowe);
                return opracowanyDokument;
        }

        internal DokumentEz ZatwierdzaZlecenie(DokumentEz kwit, string DaneWejsciowe,int pid)
        {
            DokumentEz opracowanyDokument= new DokumentEz(DaneWejsciowe,pid);
            Console.WriteLine("ZatwierdzaZlecenie -> {0}",DaneWejsciowe);
                return opracowanyDokument;
        }

        internal DokumentEz WykonujeZlecenie(DokumentEz zlecenie, string DaneWejsciowe,int pid)
        {
            DokumentEz opracowanyDokument= new DokumentEz(DaneWejsciowe,pid);
            Console.WriteLine("WykonujeZlecenie -> {0}",DaneWejsciowe);
            return opracowanyDokument;
        }

        internal DokumentEz ZamykaZlecenie(DokumentEz zadanie, string DaneWejsciowe,int pid)
        {
            DokumentEz opracowanyDokument= new DokumentEz(DaneWejsciowe,pid);
            Console.WriteLine("ZamykaZlecenie -> {0}",DaneWejsciowe);
            return opracowanyDokument;
        }
    }
}


