using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumModel
{
    class Logger
    {
        public Logger()
        { 
        
        }
        
        public void w(string l)
        {
            Console.WriteLine(l);

        }

        internal void L(string v)
        {
            throw new NotImplementedException();
        }
    }

    
}
