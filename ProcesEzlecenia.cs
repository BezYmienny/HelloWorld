using System;

namespace SystemZlecen
{
    public class ProcesEzlecenia
        {
            private int _idPeZ;

            public int GetIdPeZ()
            {
                return _idPeZ;
            }
            
            public ProcesEzlecenia()
            {
                _idPeZ++;
            }

            public void Run()
                {
                    // Utworzenie pracowników !
                    Employee kierownikZmiany=new Employee("Kier Zmian");
                    Employee koordynatorUrMnt=new Employee("Koor Ur Mnt");
                    Employee serwisantUrMnt=new Employee("Srerwisant Ur Mnt");

                    // Cykl od zlecenia do wykonania - logika tworzenia obiektow
                    
                    try{
                            Console.WriteLine("Run na procesie nr : {0}",GetIdPeZ());
                    
                            DokumentEz kwit=kierownikZmiany.WystawiaZlecenie("WZ PaczkaDanychInicjujacyh ",GetIdPeZ());

                            
                            DokumentEz zlecenie=koordynatorUrMnt.ZatwierdzaZlecenie(kwit,"KW-ZL Dane wymagane do zatwierdzenie",GetIdPeZ());

                            
                            DokumentEz zadanie=serwisantUrMnt.WykonujeZlecenie(zlecenie,"ZL-WZ Uwagi od serwisanta po wykonaniu zadania",GetIdPeZ());
                            

                    // Cykl od wykonania/zamkniecie zlecenia/informacja do kierownikZmiany - logika modyfikacji obiektow

                            zlecenie.ZamkniecieZlecenia(koordynatorUrMnt.ZamykaZlecenie(zadanie,"Z-ZZ Uwagi do zamkniecia zadania",GetIdPeZ()));  
                            kwit.ZamkniecieKwitu(zlecenie.PotwierdzenieZamkniecia());

                    }
                    catch(Exception ex)
                    {
                            Console.WriteLine("Znowu wysypało się : => \n",ex);
                    }
                    
                    
                    
                    

                }
                

 public void Run2()
                {
                    // Utworzenie pracowników !
                    Employee kierownikZmiany=new Employee("Kier Zmian");
                    Employee koordynatorUrMnt=new Employee("Koor Ur Mnt");
                    Employee serwisantUrMnt=new Employee("Srerwisant Ur Mnt");

                    // Cykl od zlecenia do wykonania - logika tworzenia obiektow
                    
                    try{
                            Console.WriteLine("Run na procesie nr : {0}",GetIdPeZ());
                    
                            DokumentEz kwit=kierownikZmiany.WystawiaZlecenie("WZ PaczkaDanychInicjujacyh ",GetIdPeZ());

                            
                            DokumentEz zlecenie=koordynatorUrMnt.ZatwierdzaZlecenie(kwit,"KW-ZL Dane wymagane do zatwierdzenie",GetIdPeZ());

                            
                            DokumentEz zadanie=serwisantUrMnt.WykonujeZlecenie(zlecenie,"ZL-WZ Uwagi od serwisanta po wykonaniu zadania",GetIdPeZ());
                            

                    // Cykl od wykonania/zamkniecie zlecenia/informacja do kierownikZmiany - logika modyfikacji obiektow

                            zlecenie.ZamkniecieZlecenia(koordynatorUrMnt.ZamykaZlecenie(zadanie,"Z-ZZ Uwagi do zamkniecia zadania",GetIdPeZ()));  
                            kwit.ZamkniecieKwitu(zlecenie.PotwierdzenieZamkniecia());

                    }
                    catch(Exception ex)
                    {
                            Console.WriteLine("Znowu wysypało się : => \n",ex);
                    }
                    
                    
                    
                    

                }
        }

}
