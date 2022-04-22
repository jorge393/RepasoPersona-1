using System;
using RepasoPersona.Core;
using Xunit;

namespace RepasoPersona.Test
{
    public class CuentaTest
    {
        
        public Cuenta Cuetna { get; set; }

        public CuentaTest() => Cuetna = new Cuenta(000010, 0);

        [Fact]
        public void Constructor()
        {
            Assert.Equal(000010, Cuetna.CBU);
        }

        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Cuetna.Acreditar(esperado);
            
            Assert.Equal(esperado, Cuetna.Saldo, 3);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => Cuetna.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            Cuetna.Acreditar(monto);
            Cuetna.Debitar(debito);

            Assert.Equal(monto - debito, Cuetna.Saldo, 2);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Cuetna.Debitar(1000));
            Assert.Equal("El monto supera al efectivo.", ex.Message);
        }
    }
}