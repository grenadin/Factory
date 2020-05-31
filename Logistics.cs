using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Factory
{
    abstract class Logistics
    {
        public string PlanDelivery()
        {
            var product = CreateTransport();
            return $"Logistics: The same Creator's code has just worked with {product.Deliver()}";
        }

        public abstract ITransport CreateTransport();
        
    }
}
