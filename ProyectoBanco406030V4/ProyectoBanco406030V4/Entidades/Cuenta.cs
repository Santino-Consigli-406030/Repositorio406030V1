using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco406030V4.Entidades
{
    internal class Cuenta
    {
        public int id_cuenta { get; set; }
        public int id_cliente { get; set; }
        public int id_tipo_cuenta { get; set; }
        public int cbu { get; set; }
        public int saldo { get; set; }
        public DateTime ultimoMovimiento { get; set; }
    }
}
