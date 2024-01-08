// See https://aka.ms/new-console-template for more information
Console.WriteLine("conversions");

int i = 42;
string s = i.ToString();

Console.WriteLine(s);

string s2 = "1234";
//convertir une chaine de caractère en entier
int i2 = int.Parse(s2);

string chaine123 = "123";
int i123 = Convert.ToInt32(chaine123);

Console.WriteLine("entrer votre age :");
string input = Console.ReadLine();
int age= int.Parse(input);
int annee = 2024 - age;
Console.WriteLine($"votre annees de naissance : {annee}");


