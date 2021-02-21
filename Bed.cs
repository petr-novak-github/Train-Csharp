using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Bed
    {
        int number;
        bool reserved;

        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }

        public Bed()
        {

        }

        public Bed(int number)
        {
            this.number = number;
        }

        public Bed(int number, bool reserved) : this(number)
        {
            this.reserved = reserved;
        }


    }
}
