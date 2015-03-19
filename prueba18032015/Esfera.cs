using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prueba18032015
{
    class Esfera: Figura
    {
        private double radio;
        private static double PI = 3.1416;

        public Esfera(double radio)
        {
            this.radio = radio;
        }
        public override void calcularArea()
        {
            this.area= 4 * PI * radio * radio;
        }
        public override void calcularVolumen()
        {
            this.volumen = (4/3)*PI*radio*radio*radio;
        }
        public override void pintar()
        {
            //implementacion del metodo;
        }
    }
}
