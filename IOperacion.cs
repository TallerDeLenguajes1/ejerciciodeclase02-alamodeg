using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPClase_2
{
    /// <summary>
    /// Probando Interfase
    /// </summary>
    public enum TipoExtraccion2 {CajeroHumano,CajeroAutomatico};
    public interface IOperacion
    {
        string Insercion(int monto);
        string Extraccion(int monto,TipoExtraccion2 tipo);
    }
}
