//promedio ponderado
//variables
double pricor, segcor, tercor, prom;
//entradas
Console.Write("digite la nota del primer corte: ");
pricor=Convert.ToDouble(Console.ReadLine());
Console.Write("digite la nota del segundo corte: ");
segcor=Convert.ToDouble(Console.ReadLine());
Console.Write("digite la nota del tercer corte: ");
tercor=Convert.ToDouble(Console.ReadLine());
//proceso
prom = pricor * 0.25 + segcor * 0.35 + tercor * 0.4;
//salida
Console.WriteLine($"el promedio ponderado es: {prom}");
