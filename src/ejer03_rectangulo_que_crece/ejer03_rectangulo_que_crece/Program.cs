//rectangulo que crece
//variables
int bac, alto, area, perimetro;
//entradas
Console.WriteLine("Ingrese la base del rectangulo: ");
bac = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectangulo: ");
alto = Convert.ToInt32(Console.ReadLine());
//proceso
area = bac * alto;
perimetro = 2 * (bac + alto);
//salidas
Console.WriteLine($"El area del rectangulo es: {area}");
Console.WriteLine($"El perimetro del rectangulo es: {perimetro}");
//proceso de crecimiento
area=area * 2;
perimetro = perimetro * 2;
//salidas del crecimiento
Console.WriteLine($"El area del rectangulo despues de crecer es: {area}");
Console.WriteLine($"El perimetro del rectangulo despues de crecer es: {perimetro}");