//equation du second degre
console.Write("entrer valeur de a : ");
int a = int.Parse(Console.ReadLine());
console.Write("entrer valeur de b : ");
int b = int.Parse(Console.ReadLine());
console.Write("entrer valeur de c : ");
int c = int.Parse(Console.ReadLine());


double discriminant = Math.Pow(b,2) - 4*a*c; // discriminant = b*b - 4*a*c;


if (discriminant > 0)
{
    double racinePos = (-b + Math.Sqrt(discriminant)) / (2*a);
    double racineNeg = (-b - Math.Sqrt(discriminant)) / (2*a);
    Console.WriteLine("les solutions de l'equation sont : {racinePos} et  {racineNeg}");
}
else if (discriminant == 0)
{
    double racineUnique = -b / (2*a);
    Console.WriteLine($"l'equation a une seule solution : {racineUnique}");
}
else
{
    Console.WriteLine("l'equation n'a pas de solution");

}

Console.ReadLine();


