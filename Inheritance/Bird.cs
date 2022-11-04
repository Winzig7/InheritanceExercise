using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool CanFLy { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public int BeakSize { get; set; }
    }
}
