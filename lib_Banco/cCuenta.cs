using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class cCuenta
    {
        protected int numero;
        protected string nombre;
        protected double saldo;

        public virtual void Depositar(double cantidad)
        {
            saldo = saldo + cantidad;
        }

        public virtual void Retirar(double cantidad)
        {
            saldo = saldo - cantidad;
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }

    }

    public class Credito : cCuenta
    {
        public Credito()
        {
            saldo = 300;
        }

        public override void Retirar(double cantidad)
        {
            this.saldo = saldo - cantidad;
        }

        public override void Depositar(double cantidad)
        {
            saldo = saldo + cantidad;
        }

    }

    public class Debito : cCuenta
    {
        public Debito()
        {
            saldo = 300;
        }

        public override void Retirar(double cantidad)
        {
            this.saldo = saldo - cantidad;
        }

        public override void Depositar(double cantidad)
        {
            saldo = saldo + cantidad;
        }

    }

}
