using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Train
    {
        Locomotive locomotive;
        List<IWagon> wagons;

        internal List<IWagon> Wagons { get => wagons; set => wagons = value; }
        internal Locomotive Locomotive { get => locomotive; set => locomotive = value; }

        public Train()
        {
            this.wagons = new List<IWagon>();    
        }

        public Train(Locomotive locomotive)
        {
            this.locomotive = locomotive;
            this.wagons = new List<IWagon>();
        }

        public Train(Locomotive locomotive, List<IWagon> wagons) : this(locomotive)
        {
            this.wagons = wagons;
        }

        public void ConnectWagon(IWagon wagon) {
            if (wagons.Count()<5)
            {
                wagons.Add(wagon);
            }

            else
            {
                Console.WriteLine("Nelze pripojit dalsi vagon, vlak muze mit max 5 wagonu.");
            }
        }
        public void DisconnectWagon(IWagon wagon)
        {
            if (wagons.Contains(wagon))
            {
                wagons.Remove(wagon);

            } }

        public void ReserveChair(int cisloWagonu, int cisloSedadla) {

            int pocetWagacu = wagons.Count();
            IWagon[] poleWagacu = new IWagon[pocetWagacu];
            poleWagacu = wagons.ToArray();
            IWagon thisWagonek = poleWagacu[cisloWagonu];

            if (thisWagonek is PersonalWagon)
            {
            PersonalWagon thisWagonekPW = (PersonalWagon)thisWagonek;
            int pocetKreselVeWagaci = thisWagonekPW.Sits.Count();


            if (poleWagacu[cisloWagonu] is PersonalWagon & cisloWagonu<=pocetWagacu)
            {
                Chair[] poleKreselVeWagaci = new Chair[pocetKreselVeWagaci];
                poleKreselVeWagaci = ((PersonalWagon)(thisWagonek)).Sits.ToArray();
                if (poleKreselVeWagaci[cisloSedadla].Reserved == true)
                {
                    Console.WriteLine("Sedadlo uz je reserved.");
                }


                if (((PersonalWagon)thisWagonek).NumberOfChairs>cisloSedadla)
                {
                    
                    poleKreselVeWagaci[cisloSedadla].Reserved = true; 
                }
            }
            }
            else
            {
                Console.WriteLine($"Nelze reservovat ve vagonu typu {poleWagacu[cisloWagonu].GetType().Name} ");
            }
            //else
            //{
            //    Console.WriteLine($"Nelze reservovat v{poleWagacu[cisloWagonu].GetType().Name} ");
            //}

        }
        public void ListReservedChairs() {

            int pocetWagacu = wagons.Count();
            IWagon[] poleWagacu = new IWagon[pocetWagacu];
            poleWagacu = wagons.ToArray();
            string ret2 = "Reserved seats: \n";
          //  string ret = "";
            for (int i = 0; i < pocetWagacu; i++)
            {
                
            if (poleWagacu[i] is PersonalWagon)
            {
                    PersonalWagon thisPersonalniWagac = (PersonalWagon)poleWagacu[i];
                    int pocetKresell = thisPersonalniWagac.Sits.Count();

                    Chair[] poleKreselVeWagaci = new Chair[pocetKresell];
                   
                    poleKreselVeWagaci = thisPersonalniWagac.Sits.ToArray();
                   
                    for (int j = 0; j < poleKreselVeWagaci.Length; j++)
                    {
                        if (poleKreselVeWagaci[j].Reserved==true)
                        {
                           
                            ret2 += i + ". wagon - " + j + ". sedadlo \n";
                        }
                    }

                }
                
            }


            Console.WriteLine($"V tomto vlaku jsou rezervovana tyto sedadla (cisloWagonu - cisloSedadla) \n  {ret2}");
        }

        public override string ToString()

        {
            string ret="";
            foreach (IWagon item in wagons)
            {
                ret += item.ToString() + "\n";
            }
            return $"Vlak s lokomotivou {locomotive.ToString()} a s vagonama: \n{ret} ";
        }
    }
}
