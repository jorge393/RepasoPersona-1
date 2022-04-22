using System;
namespace RepasoPersona.Core 
{
    public class Cuenta : EnteConSaldo
    {
        public int CBU {get;set;}
        
        Persona persona;
        
        public Cuenta(int cbu, double saldo)
        {
            Saldo = saldo;
            CBU = cbu;
        }

        
    }
}