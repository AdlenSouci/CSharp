using TPCalc;
// Class = Calculatrice (=type)
// Object = CALC

Calculatrice CALC = new Calculatrice();


decimal a = 5;
decimal b = 6;
Console.WriteLine(CALC.Addition(a,b));

Console.WriteLine(CALC.Soustraction(a,b));

Console.WriteLine(CALC.Multiplication(a,b));

Console.WriteLine(CALC.Division(a,b));
Console.WriteLine(CALC.Modulo(a,b));