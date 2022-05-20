using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasBDConectada
{
    public class entidadcliente
    {
        public int idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string apellidoCliente { get; set; }
        public string ciudadCliente  { get; set; }
        public string direccionCliente { get; set; }
        public int celularCliente { get; set; }
        public Boolean estadoCliente { get; set; }
    }
}
