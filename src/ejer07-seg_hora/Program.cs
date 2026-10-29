//segundos a hora
//variables
int s, m, h;
//entradas
Console.WriteLine("ingrese el valor en segundos: ");
s=Convert.ToInt32(Console.ReadLine());
//proceso
h = s / 3600;
s = s % 3600;
m = s / 60;
s= s % 60;
//salidas
Console.WriteLine($"la hora es: {h}:{m}:{s}");