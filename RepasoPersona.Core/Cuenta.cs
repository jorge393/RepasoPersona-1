using System;
namespace RepasoPersona.Core 
{
    public class Cuenta : Clasabs
    {
        int CBU {get;set;}
        double Efectivo {get;set;}
        
        public Cuenta(int cbu, double efectivo)
        {
            CBU = cbu;
            Efectivo = efectivo;
        }

        public new void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Efectivo)
                throw new InvalidOperationException("El monto supera al efectivo.");
            Efectivo -= monto;
        }
        public new void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new Exception("El monto tiene que ser mayor a cero.");
            Efectivo += monto;
        }
    }
}