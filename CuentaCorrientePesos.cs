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
            this.capital = monto;
            return ($"Se ha insertado ${monto} pesos a la cuenta");
        }

        public string Extraccion(int monto, TipoExtraccion tipo)
        {
            if (monto<0)
            {
                return $"No tiene fondos en su cuenta";
            }
            if (tipo==TipoExtraccion.CajeroAutomatico)
            {
                if(monto>20000) return $"No se puede extraer mas de $20000 diarios";
            }
            return $"Se extrajo ${monto}";
        }
    }
}
