// See https://aka.ms/new-console-template for more information

using System.Text;

var nums = Enumerable.Range(1, 100).ToList();

//Números divisibles entre 7
var numsDiv7 = nums.Where(x => x % 7 == 0).ToList();

StringBuilder cadena = new();
cadena.Append("Números divisibles entre 7: ");

foreach (var num in numsDiv7)
{
    cadena.Append($"{num} ");
}

Console.WriteLine(cadena.ToString());

cadena.Clear();

//Separar pares e impares
var numsPar = numsDiv7.GroupBy(n => n%2 == 0);

foreach (var grupo in numsPar)
{
    if (grupo.ElementAt(0) % 2 == 0)
    {
        cadena.Append("\n\nPares: ");
    }
    else
    {
        cadena.Append("\nImpares: ");
    }

    foreach (var num in grupo)
    {
        cadena.Append($"{num} ");  
    }
}

Console.WriteLine(cadena);