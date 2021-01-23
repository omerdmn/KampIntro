using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ILoggerService> loggers = new List<ILoggerService> {new DataBaseLoggerService(),new FileLoggerService()};
            List<IKrediManager> manager = new List<IKrediManager> { new IhtiyacKrediManager(), new TasitKrediManager()};



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap( manager,loggers);
            

        }
    }
}
