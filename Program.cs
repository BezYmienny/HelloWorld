using System;

namespace SystemZlecen
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Test_old();
            ProcesEzlecenia Nowe=new ProcesEzlecenia();
           
            Nowe.Run();
            Nowe.Run2();
            
           
            Console.ReadKey();

        }

        


    }

}
