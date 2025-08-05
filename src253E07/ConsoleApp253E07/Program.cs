int numeroLados = 6;       // Número de lados del polígono
double Base = 4.0;         // Longitud de cada lado
double altura = 10.0;      // Altura del poligono regular

double Apotema = Application253E07.Figura253E07.Apotema(numeroLados, Base); // Cálculo del apotema
double perimetro = Application253E07.Figura253E07.Perimetro(numeroLados, Base); // Cálculo del perímetro
double area = Application253E07.Figura253E07.Area(numeroLados, Base , Apotema);
double volumen = Application253E07.Figura253E07.Volumen(area, altura); // Volumen

Console.WriteLine($"El perímetro de la base de un poligono regular  regular de {numeroLados} lados de {Base}cm por lado es {perimetro:F2}cm");
Console.WriteLine($"El apotema del polígono regular es {Apotema:F2}cm");
Console.WriteLine($"El área de la base de un poligono  regular de {numeroLados} lados de {Base}cm por lado es {area:F2}cm²");
Console.WriteLine($"El volumen de un poligono  regular con área de base {area:F2}cm² y altura {altura}cm es {volumen:F2}cm³");