using System;

namespace Application253E07
{
    public class Figura253E07
    {
        // Calcula el perímetro de un polígono regular
        public static double Perimetro(int numeroLados, double Base)
        {
            return numeroLados * Base;
        }

        // Calcula el área de un polígono regular
        public static double Area(int numeroLados, double Base, double Apotema)
        {
            return (numeroLados * Base * Apotema) / 2;
        }

        // Calcula el volumen de un prisma con base poligonal regular
        public static double Volumen(double area, double altura)
        {
            return area * altura;
        }

        // Calcula la apotema de un polígono regular
        public static double Apotema(int numeroLados, double Base)
        {
            double anguloCentral = Math.PI / numeroLados;
            return Base / (2 * Math.Tan(anguloCentral));
        }
    }
}