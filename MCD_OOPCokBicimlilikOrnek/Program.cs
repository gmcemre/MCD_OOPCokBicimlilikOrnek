using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPCokBicimlilikOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // polymorphism

            Console.WriteLine("Banka Seçiniz [A/B] : ");
            ConsoleKeyInfo secim;
            secim = Console.ReadKey();

            if (secim.Key ==ConsoleKey.A)
            {
                ABanka bankam = new ABanka();
                bankam.BilgileriAl();
                bankam.IndirimOraninaGöreIndirimYap();
            }
            else if (secim .Key ==ConsoleKey.B )
            {
                BBanka bankam = new BBanka();
                bankam.BilgileriAl();
                bankam.IndirimOraninaGöreIndirimYap();
            }
           
            //Banka B1 = new Banka();
            //B1.BankaAdi = "Yapıkredi";
            //B1.AlisverisTutari = 2500;
            //B1.BilgileriAl();
            //B1.IndirimOraninaGöreIndirimYap();

            Console.ReadKey();
        }
    }
}
