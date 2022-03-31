using System;
using System.Collections.Generic;
using System.Linq;

namespace RepasoPersona.Core 
{
    public class Persona : EnteConSaldo
    {
        
        public int DNI {get; private set;}
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public override double Saldo { get => base.Saldo; internal set => base.Saldo = value; }
        public List<Cuenta> cuenta;
        public Persona() => Saldo = 0;
        public Persona(int dni, string nombre, string apellido, double efectivo)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
            cuenta = new List<Cuenta>();
        } 
        double TotalSaldo =>  cuenta.Sum(x => x.Saldo);
        
    }
}
