using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P1_BasicInheritance
{
    // MiniVan "is-a" Car
    class MiniVan : Car
    {
        public void TestMethod()
        {
            // OK! Can access public members
            // of a parent within a derived type.
            Speed = 10;
            // Error! Cannot access private
            // members of parent within a derived type.
            //currSpeed = 10;
        }
    }
}
