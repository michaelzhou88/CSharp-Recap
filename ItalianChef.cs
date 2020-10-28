using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffe
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Italian cheff makes pasta");
        }

        // Method overriding
        // The "override" keyword tells C# to override the default method in the super class
        public override void MakeSpecialDish()
        {
            Console.WriteLine("Italian chef makes pepperoni pizza!");
        }
    }
}
