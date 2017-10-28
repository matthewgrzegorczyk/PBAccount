using System;

namespace PBAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Konto konto = new Konto();

            Console.WriteLine(konto.CheckBalance());
            konto.Add(200);
            Console.WriteLine(konto.CheckBalance());

            
            KontoHis konto2 = new KontoHis();
            konto2.Add(500);
            konto2.Add(300);
            konto2.Withdraw(150);
            konto2.ViewHistory();
            
            try {
                konto2.Withdraw(1000);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            konto2.ViewHistory();


            KontoDeb konto3 = new KontoDeb();
            konto3.Add(500);
            konto3.Add(500);
            konto3.Add(500);
            konto3.Withdraw(500);
            Console.WriteLine(konto3.getDeb());
            konto3.ViewHistory();

            for (int i = 0; i < 30; i++) {
                Random rnd = new Random();
                konto3.Add(rnd.Next(1, 2000));
            }

            konto3.ViewHistory();
        }
    }
}
