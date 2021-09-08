using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    public enum TipoExtraccion { CajeroHumano, CajeroAutomatico };
    public class Cuenta
    {
        float capital;

        public float Capital { get => capital; set => capital = value; }

        public Cuenta()
        {
            this.Capital = 0;
        }

        public virtual void Insercion(int monto)
        {
            if (monto < 0) Console.WriteLine("El monto es negativo");
            this.capital += monto;
        }
        public virtual void Extraccion(int monto, TipoExtraccion tipo)
        {
        }
    }
}
