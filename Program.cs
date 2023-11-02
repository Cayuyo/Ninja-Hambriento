// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Buffet buffet = new();
Ninja ninja = new();

while (!ninja.IsFull)
{
    Comida comida = buffet.Serve();
    ninja.Comer(comida);
}
Console.WriteLine("El Ninja está que revienta, no puede comer más!");