using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VWW_Reflections
{
    class VwwAttribute : Attribute
    {
        public int VL { get; set; }

        public VwwAttribute(int vl)
        {
            this.VL = vl;
        }
    }
}
