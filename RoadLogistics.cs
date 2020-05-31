using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class RoadLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Truck();
       
    }
}
