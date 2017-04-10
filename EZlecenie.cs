using System;

namespace SystemZlecen
{
    public class EZlecenie
    {
        private static int _idZlecenia ;
        private string nazwaUzytkownika;//idTworcyTicketa;

 // Constructor 
        public EZlecenie(string nazwaUzytkownika)
        {
            this.nazwaUzytkownika = nazwaUzytkownika;
            _idZlecenia++;
        }
         public void WypelnionePrzez(Employee pracownik, string v2, string v3, string v4, string v5, string v6, string v7, string v8)
        {
            //("kto","kiedy","gdzie","odebral","Dotyczy","Powód","Opis","SrodkiZaradcze");

            Console.WriteLine("WypelnijZl nr: {0} przez pracownika : {1}",_idZlecenia,pracownik.GetLogin());
        }

        public int GetIdZlecenia()
        {
            return _idZlecenia;
        }

        public void SetIdZlecenia()
        {
            _idZlecenia=OstatnieIdzBazy();
        }

        private int OstatnieIdzBazy()
        {
            Console.WriteLine("OstatnieIdzBazy");
            return 1;
        }

        

        public void SerializujZlecenie(EZlecenie eZlecenie)
        {
            Console.WriteLine("SerializujZlecenie");
        }

        internal void OpracowanePrzez(Employee pracownik, string v2)
        {
            Console.WriteLine("OpracownieZlecenia : {0} , przez : {1}",_idZlecenia,pracownik.GetLogin());
            
        }

        private void AktualizujSerializacjeZlecenia(EZlecenie eZlecenie)
        {
            Console.WriteLine("AktualizujSerializacjeZlecenia");
            
        }

        public void ZatwierdzonePrzez(Employee pracownik, string v2)
        {
            Console.WriteLine("ZatwierdzenieZlecenia : {0} , przez : {1}",_idZlecenia,pracownik.GetLogin());
            
        }

       


       



        
    }

}
