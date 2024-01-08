// See https://aka.ms/new-console-template for more information



Console.WriteLine("Hello DONNE TON PRENOM");
string prenom = Console.ReadLine();
Console.WriteLine("Hello DONNE TON age");
string age = Console.ReadLine();
Console.WriteLine("Hello DONNE Ta couleur exemple red");
string couleur = Console.ReadLine();
if (couleur == "red")

{
    texte.BackgroundColor = Texte.Color.Red;
}
else
{
    texte.BackgroundColor = texte.Color.Blue;
}

string texte = $"Bonjour {prenom}, tu as {age} ans";

Console.WriteLine(texte);
