using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit;
using Xunit;

namespace PooVuelingXunitTests
{
    public class CalculadoraXunitTests
    {
        ICalculadora iCalculadora = new Calculadora();

        [Fact]
        public void DivisionTest()
        {
            Assert.Equal(1, iCalculadora.Division(2, 2));
            //Assert.Fail();
        }

        [Fact]
        public void MultiplicacionTest()
        {
            Assert.Equal(3, iCalculadora.Multiplicacion(2, 2));
            //Assert.Fail();
        }

        [Fact]
        public void RestaTest()
        {
            Assert.Equal(0, iCalculadora.Resta(2, 2));
            //Assert.Fail();
        }

        [Fact]
        public void SumaTest()
        {
            Assert.Equal(4, iCalculadora.Suma(2, 2));
            //Assert.Fail();
        }
    }
}
