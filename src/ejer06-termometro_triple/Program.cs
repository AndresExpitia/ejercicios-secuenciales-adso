//termometro triple
//variables
double c, k, f;
//entradas
Console.WriteLine("introduzca el valor en C°");
c=Convert.ToDouble(Console.ReadLine());
//procesos
f = (c * 1.8 + 32);
k = (c + 275.5);
//salidas
Console.WriteLine($"la temperatura en celcius es {c}, en fahrenheit es {f} y en kelvin es {k}");
