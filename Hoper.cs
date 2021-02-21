using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Hoper:IWagon
    {
        double loadingCapacity;

        public double LoadingCapacity { get => loadingCapacity; set => loadingCapacity = value; }

        public Hoper()
        {

        }

        public Hoper(double loadingCapacity)
        {
            this.loadingCapacity = loadingCapacity;
        }

        //public void ConnectWagon(Train train) { }
        //public void DisconnectWagon(Train train) { }

        public void ConnectWagon(Train train) { train.Wagons.Add(this); }
        public void DisconnectWagon(Train train)
        {
            if (train.Wagons.Contains(this))
            {
                train.Wagons.Remove(this);
            }
        }




        public override string ToString()
        {
            return $"--{GetType().Name} a ma kapacitu nakladu {loadingCapacity}";
        }
    }
}
