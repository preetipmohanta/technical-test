using System;
using System.Collections.Generic;
using System.Linq;
namespace TechnicalTestCore
{
    using TechnicalTestUtilities;

    internal class ChildClass : ParentClass
    {
        // Adapt the Childclass definition so that the corresponding unit test in the 'TechnicalTestUnitTests' project will pass


        public override double AnonymousMathematicalFunction(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
