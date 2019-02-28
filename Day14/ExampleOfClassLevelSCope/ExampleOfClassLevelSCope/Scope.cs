using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfClassLevelSCope
{
    public class Scope
    {
        bool b = true; // b1 has scope of entire class
        int x = 88; // x1 has scope of entire class

        Scope()
        {
            double d = 9.0;
            example(d);
            classVariable();
        }

        private void classVariable()
        {
            throw new NotImplementedException();
        }


        private void example(double d)
        {
            throw new NotImplementedException();
        }
    }
}
