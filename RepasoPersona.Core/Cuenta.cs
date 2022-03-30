using System;
namespace RepasoPersona.Core 
{
    public class Cuenta : EnteConSaldo
    {
        int CBU {get;set;}
        
        Persona persona;
        
        public Cuenta(int cbu, double saldo)
        {
            CBU = cbu;
           Saldo = saldo;
        }

        
    }
}