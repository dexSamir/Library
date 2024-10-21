using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    internal class Journal : Product
    {
        public string Company { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Price:{Price} Company: {Company}\n");
        }
    }
}
