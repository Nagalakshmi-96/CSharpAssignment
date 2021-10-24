using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment.Entities
{
    public class DecimalFields<T>
    {
        public T decimalfield1 { get; set; }
        public T decimalfield2 { get; set; }
        public T decimalfield3 { get; set; }
        public T decimalfield4 { get; set; }
        public T decimalfield5 { get; set; }
        public T decimalfield6 { get; set; }
        public T decimalfield7 { get; set; }
        public T decimalfield8 { get; set; }
        public T decimalfield9 { get; set; }
        public T decimalfield10 { get; set; }

        public DateTime datefield1 { get; set; }
        public DateTime datefield2 { get; set; }

        public int intfield1 { get; set; }
        public int intfield2 { get; set; }

        public DecimalFields<T> Copy()
        {
            return (DecimalFields<T>)this.MemberwiseClone();
        }
    }
}
