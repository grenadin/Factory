using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Ship : ITransport
    {
          public string Deliver() => "Ships deliver cargo by sea.";
    }
}
