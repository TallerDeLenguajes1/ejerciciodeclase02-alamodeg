using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    public enum TipoExtraccion {CajeroHumano,CajeroAutomatico};
    public interface IOperacion
    {
        string Insercion(int monto);
        string Extraccion(int monto,TipoExtraccion tipo);


    }
}
