using System;

namespace SystemZlecen
{
    internal class DokumentEz
    {
        private int _ids;
        private string _daneWejsciowe;
        private DokumentEz _zamkniecie;
        private int _pobranyIdsProcesu;

        // public DokumentEz(string daneWejsciowe)
        // {
            
        //     this._daneWejsciowe = daneWejsciowe;
        //     _ids++;
        //     Console.WriteLine("Tworzy dokument =>{0} o id:{1} z procesu {2}",daneWejsciowe,this._ids,GetIdsProcesu());
        // }
        public DokumentEz(string daneWejsciowe,int pobranyIdsProcesu)
        {

            this._daneWejsciowe = daneWejsciowe;
            _ids++;
            SetPobranyIdsProcesu(pobranyIdsProcesu);
            Console.WriteLine("Tworzy dokument =>{0} o id:{1}z procesu {2}", daneWejsciowe, this._ids, GetIdsProcesu());
        }

        

        public int GetIdDokumentu()
        {
            return this._ids;
        }

        public int GetIdsProcesu()
        {
            return this._pobranyIdsProcesu;
        }

        private void SetPobranyIdsProcesu(int pobranyIdsProcesu)
        {
            _pobranyIdsProcesu=pobranyIdsProcesu;
        }

        internal DokumentEz PotwierdzenieZamkniecia()
        {
            DokumentEz ZwracanyDokument=new DokumentEz("Dane zwracane",GetIdsProcesu());
            Console.WriteLine("Potwierdzenie Zamknięcia  o id:{0} z procesu {1}",this._ids,GetIdsProcesu());
            return ZwracanyDokument;
           // throw new NotImplementedException();
        }


        public void ZamkniecieZlecenia(DokumentEz dokumentEz)
        {
            
            _zamkniecie = dokumentEz;
            Console.WriteLine("Potwierdzenie Zamknięcia ZL o id:{0} z procesu {1}",this._ids,GetIdsProcesu());
        }

        internal void ZamkniecieKwitu(DokumentEz dokumentEz)
        {
            
             _zamkniecie = dokumentEz;
             Console.WriteLine("Potwierdzenie Zamknięcia ZK o id:{0} z procesu {1}",this._ids,GetIdsProcesu());
        }
    }
}