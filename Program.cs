using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Program
    {
        static void Main(string[] args)
        {

            var w1 = new BusinessWagon(100, new Person("Lenka","Kozakova"));
            var w2 = new NightWagon(50,50);
            var w3 = new Hoper(1000);
            var lok1 = new Locomotive(new Person("Karel","Novak"), new Engine("diesel"));
            var train1 = new Train(lok1,new List<IWagon>() {w1,w2,w3 } );
            var w4 = new Hoper(500);
            train1.ConnectWagon(w4);
            var lok2 = new Locomotive(new Person("Josef", "Kaplan"), new Engine("parni"));
            var wx1 = new EconomyWagon(80);
            var wx2 = new EconomyWagon(80);
            var wx3 = new EconomyWagon(80);
            var wx4 = new EconomyWagon(80);
            var wx5 = new EconomyWagon(80);
            var train2 = new Train(lok2, new List<IWagon>() {wx1, wx2, wx3, wx4, wx5 });
            train2.ConnectWagon(new EconomyWagon(50));
            train2.ReserveChair(3,3);
            //pokus o rezervovani v hoppru
            train1.ReserveChair(3,5);
            //pokus o rezervovani jiz rezervovaneho sedadla
            train2.ReserveChair(3, 3);
            train2.ReserveChair(1, 79);
            train1.ListReservedChairs();
            train2.ListReservedChairs();

            Console.WriteLine(  train1.ToString() );
            Console.WriteLine(  train2.ToString() );
           


            Console.ReadLine();
        }
    }
}
