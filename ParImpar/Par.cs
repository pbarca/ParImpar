using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    class Par
    {
        private double valor;
        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value);
            }
        }
        public string envia//
        {
            get
            {
                if (valor%2==0) return "O número "+ valor +" é Par.";
                else return "O número " + valor + " é Ímpar.";
            }
        }
    }
}
