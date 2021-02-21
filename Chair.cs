using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Chair
    {
        bool nearWindow;
        int number;
        bool reserved;

        public bool NearWindow { get => nearWindow; set => nearWindow = value; }
        public int Number { get => number; set => number = value; }
        public bool Reserved { get => reserved; set => reserved = value; }

        public Chair()
        {

        }

        public Chair(int number)
        {
            this.number = number;
        }

        public Chair(int number, bool reserved) : this(number)
        {
            this.reserved = reserved;
        }

        public Chair(bool nearWindow, int number, bool reserved):this(number,reserved)
        {
            this.nearWindow = nearWindow;
           
        }




    }
}
