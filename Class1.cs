using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAPI1
{
    class Class1
    {

        double valora, valorb;

        public Class1(double valora, double valorb)
        {
            this.valora = valora;
            this.valorb = valorb;
        }

        public double sumar()
        {
            return valora + valorb;
        }

        public double restar()
        {
            return valora - valorb;
        }

        public double multiplicar()
        {
            return valora * valorb;
        }

        public double dividir()
        {
            return valora / valorb;
        }

    }
}
