using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Plane : ITransport
    {
       public string Deliver() => "Plane deliver cargo by Air.";
    }
}
