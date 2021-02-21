using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class NightWagon:PersonalWagon
    {
        List<Bed> beds;
        int numberOfBeds;

        public NightWagon()
        {

        }
            

        public NightWagon(int numberOfBeds, int numberOfChairs):base(numberOfChairs)
        {
            this.numberOfBeds = numberOfBeds;

            List<Bed> beds = new List<Bed>(numberOfBeds);

            for (int i = 0; i < numberOfBeds; i++)
            {
                var postel = new Bed(i);
                beds.Add(postel);
            }

        }

        public override string ToString()
        {
            return $"{base.ToString()} a ma {numberOfBeds} posteli";
        }
    }
}
