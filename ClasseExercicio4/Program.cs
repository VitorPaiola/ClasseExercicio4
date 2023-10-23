using ClasseExercicio4;
using System.Globalization;

Retangulo ret = new Retangulo();

Console.WriteLine("Entre com a largura e altura do retângulo:");
ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERÍMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));