using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    class CuentaCorrientePesos : Cuenta
    {
        public override void Extraccion(int monto, TipoExtraccion tipo)
        {
            if (tipo == TipoExtraccion.CajeroAutomatico)
            {
                if (this.Capital - monto < -5000)
                {
                    Console.WriteLine($"No puede quedar con menos de -5000");
                }
                else
                {
                    if (monto > 20000) Console.WriteLine("No se puede extraer mas de $20.000");
                    else Capital -= monto;
                }
            }
            else Capital -= monto; //Si es cajero humano
        }
    }
}
