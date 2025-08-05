using System;
using Xunit;
using Application253E07;

namespace Application.UnitTest
{
    public class UnitTestPoligonoRegular
    {
        [Theory]
        [InlineData(3, 4, 12)]
         [InlineData(5, 6, 30)]
        [InlineData(6, 2, 12)]
        [InlineData(8, 3, 24)]
        [InlineData(10, 5, 50)]
        [InlineData(7, 3, 21)]
        [InlineData(9, 2, 18)]
        [InlineData(12, 1, 12)]
        [InlineData(4, 4, 16)]
        [InlineData(6, 6, 36)]

        [InlineData(6, 4, 24)] // 6 lados * 4 = 24
        public void TestPerimetro(int lados, double lado, double perimetroEsperado)
        {
            double resultado = Figura253E07.Perimetro(lados, lado);
            Assert.Equal(perimetroEsperado, resultado, 2);
        }
        [Theory]
        [InlineData(3, 4, 5, 30)]
        [InlineData(5, 6, 7, 105)]
        [InlineData(6, 2, 3, 18)]
        [InlineData(8, 3, 4, 48)]
        [InlineData(10, 5, 6, 150)]
        [InlineData(7, 3, 5, 52.5)]
        [InlineData(9, 2, 4, 36)]
        [InlineData(12, 1, 3, 18)]
        [InlineData(4, 4, 2, 16)]
        [InlineData(6, 6, 6, 108)]

        [InlineData(6, 4.0, 4.3, 51.6)]
        public void TestArea(int lados, double lado, double apotema, double areaEsperada)
       {
         double resultado = Figura253E07.Area(lados, lado, apotema);
          Assert.Equal(areaEsperada, resultado, 1); // precisión de 1 decimal
        }


        [Theory]
        [InlineData(30, 2, 60)]
        [InlineData(105, 3, 315)]
        [InlineData(18, 4, 72)]
        [InlineData(48, 2, 96)]
        [InlineData(150, 1, 150)]
        [InlineData(52, 2, 104)]
        [InlineData(36, 3, 108)]
        [InlineData(18, 4, 72)]
        [InlineData(16, 2, 32)]
        [InlineData(108, 1, 108)]

       
        public void TestVolumen(double area, double altura, double volumenEsperado)
        {
            double resultado = Figura253E07.Volumen(area, altura);
            Assert.Equal(volumenEsperado, resultado, 1);
        }
    }
}
