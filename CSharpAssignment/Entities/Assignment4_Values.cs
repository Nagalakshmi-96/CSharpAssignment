using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Entities
{
    public class Values
    {
        public string Column1;
        public string Column2;
        public double Column3;
        public int Column4;
        public Values Clone()
        {
            return (Values)this.MemberwiseClone();
        }
    }
}
