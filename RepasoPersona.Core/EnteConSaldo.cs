using System;

namespace RepasoPersona.Core
{
    public abstract class EnteConSaldo
    {
        
        public virtual double Saldo {get; internal set;}

        public EnteConSaldo() => Saldo = 0;
        public EnteConSaldo(double saldo)
        { 
            Saldo = saldo; 
        }
        public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Saldo -= monto;
        }
    
        public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Saldo += monto;
        }
    
    }
}