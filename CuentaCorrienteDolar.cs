using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    class CuentaCorrienteDolar
    {
        float capital;

        public float Capital { get => capital; set => capital = value; }

        public CuentaCorrienteDolar(float capital)
        {
            this.Capital = capital;
        }
        public string Insercion(int monto)
        {
            //falta control de monto negativo
            this.capital += monto;
            return ($"Se ha insertado {monto}$ a la cuenta");
        }

        public string Extraccion(int monto, TipoExtraccion tipo)
        {
            if (monto < 0) return $"No tiene fondos en su cuenta";

            if (tipo == TipoExtraccion.CajeroAutomatico)
            {
                if (monto > 200) return $"No se puede extraer mas de $200 dolares diarios";
            }
            capital -= monto;
            return $"Se extrajo ${monto}";
        }
    }
}
