using System;

namespace SystemZlecen
{

    public class Employee:ZadaniaPracownikow
    {
        static private int _id;
        private string _Login;
        private string Nazwisko;
        private string Imie;

        public Employee(string login)
        {
            // this.login = login;
            if (!string.IsNullOrWhiteSpace(login))
            {

                SetLogin(login);
                _id++;
            }
        }


        private void SetLogin(string login)
        {
            this._Login = login;
            SetImie(login);
            SetNazwisko(login);
        }

        public string GetLogin()
        {
            return this._Login;
            
        }

        private void SetNazwisko(string login)
        {
            this.Nazwisko = "NazwiskoXY";
            //throw new NotImplementedException();
        }

        private void SetImie(string login)
        {
            this.Imie = "ImieXY";
            //throw new NotImplementedException();

        }

        public int GetUserId()
        {
            return _id;
        }


      
    }
}


