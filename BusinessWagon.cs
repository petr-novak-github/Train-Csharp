using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class BusinessWagon:PersonalWagon
    {
        Person steward;

        internal Person Steward { get => steward; set => steward = value; }

        public BusinessWagon()
        {

        }

        public BusinessWagon(Person steward)
        {
            this.steward = steward;
        }

        public BusinessWagon(int numberOfChairs):base(numberOfChairs)
        {

        }

        public BusinessWagon(int numberOfChairs, Person steward):base(numberOfChairs)
        {
            this.steward = steward;
        }

        public override string ToString()
        {
            return $"{base.ToString()} a ma stewarda {steward.ToString()}";
        }
    }
}
