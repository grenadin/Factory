using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Truck : ITransport
    {
        public string Deliver() => "Trucks deliver cargo by land.";
       
    }
}
