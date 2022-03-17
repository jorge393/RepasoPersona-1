using System;

namespace Cuenta
{
    public class Class1
    {
        int CBU {get;set;}
        double Saldo {get;set;}


    public Cuenta(int cbu, double saldo)
    {
        CBU = cbu;
        Saldo = saldo;
    }

    public void Debitar(double monto)
    {
        Saldo -= monto;
    }
    public void Acreditar(double monto)
    {
        Saldo += monto;
    }
    }
}
