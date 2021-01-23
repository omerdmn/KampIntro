using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
       
        public void BasvuruYap(List<IKrediManager> krediler,List<ILoggerService> loggerService)
        {   
            
            foreach (var kredi in loggerService)
            {             
                kredi.Log();
            }

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                

            }


        }
        public void BasvuruYap( List<ILoggerService> loggerService)
        {

            foreach (var kredi in loggerService)
            {
                kredi.Log();
            }

           


        }
        public void BasvuruYap(List<IKrediManager> krediManagers)
        {

            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }




        }


    }
}
