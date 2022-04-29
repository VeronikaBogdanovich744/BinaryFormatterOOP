using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3.SerializedElements
{
    [Serializable]
    public class Horse: Animal
    {
        public override string Sound()
        {
            return "Neigh";
        }
    }
}
