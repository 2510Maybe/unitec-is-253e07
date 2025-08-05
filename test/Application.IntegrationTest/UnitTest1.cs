using System;
using Xunit;
using Application253E07;

namespace Application.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Theory]
        [InlineData(3, 4, 5, 2, 60)]
        [InlineData(5, 6, 7, 3, 315)]
        [InlineData(6, 2, 3, 4, 72)]
        [InlineData(8, 3, 4, 2, 96)]
        [InlineData(10, 5, 6, 1, 150)]
        [InlineData(7, 3, 5, 2, 105)]
        [InlineData(9, 2, 4, 3, 108)]
        [InlineData(12, 1, 3, 4, 72)]
        [InlineData(4, 4, 2, 2, 32)]
        [InlineData(6, 6, 6, 1, 108)]
        [InlineData(6, 4.0, 10.0, 4.3, 516)] // volumen esperado = ((6*4)*4.3/2) * 10 = 516
        public void TestVolumenPoligonoRegular(int numeroLados, double baseLado, double altura, double apotema, double volumenEsperado)
        {
            // Arrange – Set up
            double perimetro = numeroLados * baseLado;
            double areaBase = (perimetro * apotema) / 2;

            // Act – Perform
            double resultado = Figura253E07.Volumen(areaBase, altura);

            // Assert – Verify
            Assert.Equal(volumenEsperado, resultado, precision: 1); // Permite pequeña tolerancia si hay decimales
        }
    }
}

