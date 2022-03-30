using System;

namespace RepasoPersona.Core 
{
    public class Persona : EnteConSaldo
    {
        
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public override double Saldo { get => base.Saldo; set => base.Saldo = value; }
        public Persona() => Saldo = 0;
        public Persona(string nombre, string apellido, double efectivo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = efectivo;
        } 

        
    }
}
