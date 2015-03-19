using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba18032015
{
    class Rombo:Figura
    {
        private double a,b;

        public override void calcularArea()
        {
            area = a * b ;
        }
        public override void calcularVolumen()
        {
            
            throw new NotImplementedException();
        }


    }
}
