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
Console.WriteLine();

//Switch Block

int monat = 9;

switch (monat)
{
    case 1:
        Console.WriteLine("Januar");
        break;
    
    case 2:
        Console.WriteLine("Februar");
        break;

    case 3:
        Console.WriteLine("März");
        break;

    case 4:
        Console.WriteLine("April");
        break;
    
    case 5:
        Console.WriteLine("Mai");
        break;

    case 6:
        Console.WriteLine("Juni");
        break;

    case 7:
        Console.WriteLine("Juli");
        break;

    case 8:
        Console.WriteLine("August");
        break;
        
    default:
        Console.WriteLine("Ungültig!");
        break;
}


Console.WriteLine("----------------------------------------------------------------------");

string username;
int alter4;

Console.WriteLine("Herzlich Willkommen in meinem ersten C# Programm!");
Console.Write("Wie lautet dein Name: ");
username = Console.ReadLine();
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine("Willkommen " + username + "!");
Console.Write("Wie alt bist du, " + username + ": ");
alter4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("----------------------------------------------------------------------");
Console.WriteLine(username + ", du bist " + alter4 + " Jahre alt!");
Console.ReadKey();

//While und Do-While

int zahl = 0;

while (zahl <100)
{
    zahl += 1;
    Console.WriteLine(zahl);
}

Console.WriteLine();
Console.WriteLine();

int zahl5 = 20;

do
{
    zahl5 += 1;
    Console.WriteLine(zahl5);
} while (zahl5 < 10); 
    
