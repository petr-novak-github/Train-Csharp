using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Door
    {
        double height;
        double width;

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public Door()
        {

        }

        public Door(double height, double width)
        {
            this.height = height;
            this.width = width;
        }




    }
}
