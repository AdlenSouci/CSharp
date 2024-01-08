// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hola seniorita , te amo bbcitaa!");
string s;
int i;
i = 0;
while (i < 10)
{
    i = i + 1;
    Console.WriteLine(i);
}
if (i == 10)
{
    Console.BackgroundColor = ConsoleColor.Blue; Console.WriteLine("i = 10");
    Console.BackgroundColor = ConsoleColor.White; Console.WriteLine("i = 10");
    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("i = 10");
}

const float tva = 19.6f;
const float pi = 3.14f;

s = Console.ReadLine();
Console.WhriteLine(s);


