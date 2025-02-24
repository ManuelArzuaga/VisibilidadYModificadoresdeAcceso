using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilidadYModificadoresdeAcceso
{
    class CuentaBancaria
    {
        //tipos de encapsulamiento
        private double Saldo { get; set; } //propiedad solo se puede usar dentro de la clase

        public double SaldoPrivado { get; private set; } //para guardar saldo(set) solo se puede hacer en esta clase, se puede leer por fuera de la clase pero solo se puede cambiar su valor dentro de la clase

        public int Publico { get; set; } //se puede utilizar en todas partes

        protected int Privado { get; set; } //se puede utilizar solo cuando una clase hereda de esta clase


        //taambien se puede encapsular funciones o metodos
        public CuentaBancaria(double SaldoInicial)
        {
            Saldo = SaldoInicial;
        }

        public void Depositar(double cantidad)
        {
            Saldo = Saldo + cantidad;
        }

        public void Retirar(double cantidad)
        {
            if(cantidad <= Saldo)
            {
                Saldo = Saldo - cantidad;
            }
            else
            {
                Console.WriteLine("No tiene saldo suficiente");
            }
            
        }

        public double ObtenerSaldo()
        {
            return Saldo;
        }
    }
}
