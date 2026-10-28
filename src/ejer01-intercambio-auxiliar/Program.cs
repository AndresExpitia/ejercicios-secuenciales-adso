//intercambio variable auxiliar
//variables
int a, b, c;
//entradas
Console.WriteLine("ingrese la variable a");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese la variable b");
b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"las variables son: A: {a} B: {b}");
//proceso
c = a;
a = b;
b = c;
//salida
Console.WriteLine($"las variables intercambiadas quedan: a: {a}.  b: {b}");