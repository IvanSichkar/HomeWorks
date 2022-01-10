using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13.Task2.Classes
{
    internal class MotorcycleNotFoundException : Exception
    {
        public MotorcycleNotFoundException()
        {
            
        }

        public MotorcycleNotFoundException(string message)
            : base($"Moto id={message} is not found")
        {
           
        }

        public MotorcycleNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
