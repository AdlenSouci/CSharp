using System.ComponentModel.DataAnnotations;

class Utilisateur
{
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public string? Email { get; set; }
    public string Password { get; set; }

    public Utilisateur(string nom, string prenom, string email, string password)
    {
        Nom = nom;
        Prenom = prenom;
        Email = email;
        Password = password;
    }

    public void ModifierMotDePasse(string? nouveauMotDePasse)
    {
        // Console.Write("Saisir le nouveau mot de passe : ");
        // string? nouveauMotDePasse = Console.ReadLine();

        if (nouveauMotDePasse != null && nouveauMotDePasse != Password)
        {
            Password = nouveauMotDePasse;
            Console.WriteLine("Mot de passe modifié avec succès ! " + Password);
        }
        else if (nouveauMotDePasse == null)
        {
            Console.WriteLine("Erreur : mot de passe non saisi !");
        }
        else
        {
            Console.WriteLine("Erreur : le nouveau mot de passe ne peut pas être identique à l'ancien mot de passe !");
        }
    }
    private bool verifierpassword(string? password)
    {
        bool digit = false;
        bool letter = false;
        foreach (char c in password)
        {


            if (char.IsDigit(c))
            {
                digit = true;
            }
            if (char.IsLetter(c))
            {
                letter = true;
            }

        }
        if (digit && letter)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

partial class Program
{
    static void Main(string[] args)
    {
        Utilisateur u = new Utilisateur("zoulou", "gentil", "zoulou@gentil.unpeu", "A1");
        Console.WriteLine("saisir le nouveau mot de passe : ");
        string? nouveauMotDePasse = Console.ReadLine();
        u.ModifierMotDePasse(nouveauMotDePasse);
        u.verifierpassword(password);

    }
}