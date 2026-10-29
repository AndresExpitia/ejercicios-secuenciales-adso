//area y perimetro circulo
//variable
double rad, p, a, per;
//entradas
Console.WriteLine("ingrese el radio del circulo: ");
rad=Convert.ToDouble(Console.ReadLine());
//procesos
p=3.1415;
a = rad * rad * p;
per = 2 * rad * p;
//salida
Console.WriteLine($"el area del circulo es {a} y el perimetro es {per}");
