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

        //Test sin pasar datos como parámetros

        //[Fact]
        //public void DivisionTest()
        //{
        //    Assert.Equal(1, iCalculadora.Division(2, 2));
        //    //Assert.Fail();
        //}

        //Test parametrizado
        [Theory]
        [InlineData(4, 2, 2)]
        [InlineData(9, 3, 3)]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.Equal(resultado, iCalculadora.Division(num1, num2));
            //Assert.Fail();
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(9, 3, 27)]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.Equal(resultado, iCalculadora.Multiplicacion(num1, num2));
            //Assert.Fail();
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(9, 3, 6)]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.Equal(resultado, iCalculadora.Resta(num1, num2));
            //Assert.Fail();
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(7, 3, 10)]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.Equal(resultado, iCalculadora.Suma(num1, num2));
            //Assert.Fail();
        }
    }
}
