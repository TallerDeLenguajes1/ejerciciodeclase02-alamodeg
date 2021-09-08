using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    class CajaAhorroPeso:IOperacion
    {
        float capital;

        public float Capital { get => capital; set => capital = value; }

        public CajaAhorroPeso(float capital)
        {
            this.Capital = capital;
        }

        public string Insercion(int monto)
        {
            //falta control de monto negativo
            this.capital += monto;
            return ($"Se ha insertado ${monto} pesos a la cuenta");
        }
        public string Extraccion(int monto, TipoExtraccion tipo)
        {
            return ($"FALTA..");
        }
    }
}
