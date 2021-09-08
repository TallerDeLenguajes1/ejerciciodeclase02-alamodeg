using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    class CuentaCorrientePesos :IOperacion
    {
        float capital;

        public float Capital { get => capital; set => capital = value; }

        public CuentaCorrientePesos(float capital)
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
            if (monto<0) return $"Ingrese un monto positivo";

            if (tipo==TipoExtraccion.CajeroAutomatico)
            {
                if(monto>20000) return $"No se puede extraer mas de $20000 diarios";
            }
            capital -= monto;
            return $"Se extrajo ${monto}";
        }
    }
}
