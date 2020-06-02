using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cartera
    {
        public double  Capital { get; set; }
        public double DineroPrestado { get; set;}
        public double DineroRestante { get; set;}
        public int CantidadDeudores { get; set;}

        private IList<Cliente> Clientes = new List<Cliente>();
        private IList<Credito> Creditos = new List<Credito>();
        private IList<Pago> Pagos = new List<Pago>();


    }
}
