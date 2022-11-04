using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string LocatedWhere { get; set; }
        public string NumberOfEyes { get; set; }   
        public bool HasTail { get; set; }
        public bool CanSwim { get; set; }
    }
}
