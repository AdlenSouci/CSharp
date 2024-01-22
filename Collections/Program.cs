


//type[] tableauEntiers = new int[10];
int[] tableauEntiers = new int[5] { 11, 22, 33, 44, 55 };

string[] tableauChaine = new string[] {"bonjour", "à", "tous" };

string[] mois = new string[12] { "janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };


Console.WriteLine(mois[0]);
Console.WriteLine("<select>");

for (int i = 0; i < mois.Length; i++)
{
   // Console.WriteLine($"<option value= {i+1}>{mois[i]}</option>");
}

Console.WriteLine("</select>");

List<string> listeSTRING = new List<string>();
listeSTRING.Add("bonjour");
listeSTRING.Add("à");
listeSTRING.Add("tous");
Console.WriteLine(listeSTRING[0]);    
Console.WriteLine(listeSTRING[1]);    
Console.WriteLine(listeSTRING[2]);    

List<int> listeINT = new List<int>();
listeINT.Add(11);
listeINT.Add(22);
listeINT.Add(33);

listeINT.Remove(11);
listeINT.RemoveAt(0);
listeINT.Add(44);
listeINT.Reverse();



Console.WriteLine($"{listeINT.Count} éléments dans la liste");

foreach (int i in listeINT)
{
    Console.WriteLine(i);
}
Console.WriteLine(listeINT.ToString());
Console.WriteLine(listeINT.Contains(33));
Console.WriteLine(listeINT.ToString());

