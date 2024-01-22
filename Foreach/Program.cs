

List<string> listeSTRING = new List<string>();
listeSTRING.Add("bonjour");
listeSTRING.Add("à");
listeSTRING.Add("tous");


for(int i = 0; i < listeSTRING.Count; i++)
{
    Console.WriteLine(listeSTRING[i]);
}

foreach (string item in listeSTRING)
{
    Console.WriteLine(item);
}
