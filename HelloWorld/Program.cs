// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello World!");
Console.WriteLine("Hallo Welt!");
Console.WriteLine();
Console.WriteLine("Mein Name ist Timo!");
Console.WriteLine("Dieses ist mein erstes C# Projekt!");
Console.WriteLine();

//Variablen und Datentypen
int alter = 33;

Console.WriteLine("Ich bin " + alter + " Jahre alt!");
Console.WriteLine();


string name = "Klaus";
double grösse = 1.72;
decimal konto = 4321.45M;

Console.WriteLine(name + " ist " + grösse + "m groß und sein Kontostand beträgt " + konto + " Euro!");
Console.WriteLine();

//Mathematische Operationen

int zahl1 = 5;
int zahl2 = 10;
int ergebnis = zahl1 * zahl2;

Console.WriteLine("Das Ergenis lautet " + ergebnis);
Console.WriteLine();

//Modulo (Restwert-Operator)
int restwert = 10 % 8;
Console.WriteLine("Das Modulo von 10 % 8 ist " + restwert);
Console.WriteLine();

//Einfache If-Abfragen
int alter2 = 15;

if (alter2 >= 18)
{
    Console.WriteLine("Du darfst diese Webseite betreten! Herzlich Willkommen!");
}
else
{
    Console.WriteLine("Du darfst diese Webseite leider nicht betreten, da du noch nicht volljährig bist! Auf Wiedersehen...");
}
Console.WriteLine();

//Kombinations-Operatoren
int alter3 = 17;
bool eltern = true;

if (alter3 >= 18)
{
    Console.WriteLine("Du darfst den Kinofilm schauen!");
}
else if (alter3 > 16 && eltern == true)
{
    Console.WriteLine("Du darfst den Kinofilm zusammen mit deinen Eltern schauen!");
}
else
{
    Console.WriteLine("Du darfst nicht in den Kinosaal, tut mir Leid!");
}
Console.ReadKey();

