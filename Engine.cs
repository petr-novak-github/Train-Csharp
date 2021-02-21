using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjTrain
{
    class Engine
    {
        string type;

        public string Type { get => type; set => type = value; }

        public Engine()
        {

        }

        public Engine(string type)
        {
            this.type = type;
        }

        public override string ToString()
        {
            return $"Motor je typu: {type}";
        }
    }
}
