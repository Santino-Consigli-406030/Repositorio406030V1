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
       

        public Cuenta(int id_cliente, int id_tipo_cuenta, int cbu, int saldo, DateTime ultimoMovimiento)
        {
           
            this.id_cliente = id_cliente;
            this.id_tipo_cuenta= id_tipo_cuenta;
            this.cbu = cbu;
            this.saldo = saldo;
            this.ultimoMovimiento = ultimoMovimiento;
        }
       
    }
}
