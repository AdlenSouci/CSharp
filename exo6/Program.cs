Console.WriteLine($"deviner le nombre mystere");

Random random = new Random();
int nombreMystere = random.Next(1, 100);
int nombreUtilisateur;
int essai = 0;

while (essai < 5)
{
    Console.WriteLine($"entrer un nombre entre 1 et 100");
    nombreUtilisateur = int.Parse(Console.ReadLine());
    if (nombreUtilisateur == nombreMystere)
    {
        Console.WriteLine($"bravo vous avez gagner");
        break;  //sortir de la boucle
    }
    else if (nombreUtilisateur < nombreMystere)
    {
        Console.WriteLine($"le nombre mystere est plus grand");
    }
    else
    {
        Console.WriteLine($"le nombre mystere est plus petit");
    }
    essai++;
    if (essai == 5)
    {
        Console.WriteLine($"vous avez perdu, le nombre mystere est {nombreMystere}");
    }

}

