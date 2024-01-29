using Prop;
TestProp test =new TestProp();
test.Nb1 = 2; // Accès à la donnée (membre) data de l'objet test
test.Nb2 = 0;

Console.WriteLine(test.Somme()); // Affiche la valeur de la donnée (membre) data de l'objet test
Console.WriteLine(test.Quotient());