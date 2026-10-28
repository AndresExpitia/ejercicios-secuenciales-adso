//ejerciciointercambio sin auxiliar
//variables
int a, b;
//
//entradas
Console.WriteLine("escriba la variable a");
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("escriba la variable b");
b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"las variables son A: {b}  B: {a}");
//proceso
a = a + b;
b = a - b;
a = a - b;
//salida
Console.WriteLine($"las variables intercambiadas son: A: {b}  b: {a}");
