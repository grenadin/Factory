using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport() => new Ship();
     
    }
}
