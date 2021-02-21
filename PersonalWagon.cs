using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    abstract class PersonalWagon : IWagon
    {
        List<Door> doors;
        List<Chair> sits;
        int numberOfChairs;

        public int NumberOfChairs { get => numberOfChairs; set => numberOfChairs = value; }
        internal List<Chair> Sits { get => sits; set => sits = value; }

        public PersonalWagon()
        {

        }

        public void ConnectWagon(Train train)
        {
            if (train.Wagons.Count() < 5)
            {
                train.Wagons.Add(this);
            }


            else
            {
                Console.WriteLine("too many wagons, not possible connect another..");
            }
        }

        public void DisconnectWagon(Train train)
        {
            if (train.Wagons.Contains(this))
            {
                train.Wagons.Remove(this);
            }
        }

        protected PersonalWagon(int numberOfChairs)
        {
            this.NumberOfChairs = numberOfChairs;

            this.sits = new List<Chair>(numberOfChairs);

            for (int i = 0; i < numberOfChairs; i++)
            {
                var kreslo = new Chair(i);
                sits.Add(kreslo);
            }


        }

        public override string ToString()
        {
            return $"--{GetType().Name} s poctem sedadel {NumberOfChairs} ";
        }
    }
}
