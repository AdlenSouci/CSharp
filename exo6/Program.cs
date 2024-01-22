//Présentation

List<string> listeSTRING = new List<string>();



Console.WriteLine("Bonjour et bienvenue dans le jeu : 'Devine quelle nombre je suis !'");
const int MAX = 1000;

// Création de la variable random
Random rnd = new Random();
int variable_mystere = rnd.Next(0, MAX);

// Création des variables
bool trouver = false;
int nb_essais = 1;
string nombre = "0";
int nombre_choisi = 0;
int plus_petit = 0;
int plus_grand = 1000;

// Boucle
while (!trouver)
{
    // Rentrer de la valeur
    Console.WriteLine("Veuillez rentrer un nombre entre 0 et 1000 :");
    nombre = Console.ReadLine();
    nombre_choisi = Convert.ToInt32(nombre);
    listeSTRING.Add(nombre); // Add the entered number to the list
    switch (nombre_choisi)
    {
        case int n when (n > variable_mystere):
            nb_essais += 1;
            plus_grand = nombre_choisi;
            Console.WriteLine($"Le nombre est plus petit ! Il est entre {plus_petit} et {plus_grand}!");
            break;

        case int n when (n < variable_mystere):
            nb_essais += 1;
            plus_petit = nombre_choisi;
            Console.WriteLine($"Le nombre est plus grand ! Il est entre {plus_petit} et {plus_grand}!");
            break;

        case int n when (n == variable_mystere):
            Console.WriteLine($"Félicitations, vous avez trouvé le bon nombre soit {nombre_choisi} !");
            trouver = true;
            break;
    }
}

// ...

if (trouver)
{
    Console.WriteLine($"Vous avez réussi en {nb_essais} essais !");
    Console.WriteLine("Vous avez testé les nombres suivants :");
    foreach (var number in listeSTRING)
    {
        Console.WriteLine(number);
    }
}

