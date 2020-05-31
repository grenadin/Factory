using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Factory
{
    // This is the system. it the core of logistic
    // how is the way have ti delivery by track,ship or plane
    // The output of Logistic is product
    // This is the priority task.
    // When Logistics creted it. it done. 
    abstract class Logistics  
    {

        public string PlanDelivery() //Way
        {
            ITransport product = CreateTransport();
            
            return $"Logistics: The same Creator's code has just worked with {product.Deliver()}";
        }
        public abstract ITransport CreateTransport(); //Any Vehicle
        

    }
}
