using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherAssembly
{
    [Equals]
    public class AnotherClass
    {
        public AnotherClass(int number)
        {
            this.Number = number;
        }

        public int Number { get; set; }
    }
}
