using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        // Method overriding
        // The "virtual" keyword allows the method to be overriden in any sub-classes
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }
}
