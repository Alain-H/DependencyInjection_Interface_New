using dipendency_Injection_mit_Interface_New;

var pfleger = new Tierpfleger();

while(true)
{
    try
    {
        Console.WriteLine("Möchten sie weiter? Mit J/j weiter mit N/n beenden.");
        Console.Write("Eingabe: ");
        string str = Console.ReadLine();
        if (str == "N" || str == "n")
        {
            Console.WriteLine("Das programm wurde beendet!");
            break;
        }
        else if (str == "J" || str == "j")
        {
            int wahl = 0;
            Menu(ref wahl);
            switch(wahl)
            {
                case 1:
                    pfleger.setHund();
                    break;
                case 2:
                    pfleger.setKatze();
                    break;
                default:
                    Console.WriteLine("Falsche Eingabe!");
                    break;
                    }
        }
        else
        {
            Console.WriteLine("Geben Sie bitte den Richtigen Buchstaben ein !");
        }
    }
    catch (Exception ex)
    { Console.WriteLine(ex.ToString()); }
    
}
Console.Clear();

pfleger.getTiere();

Console.WriteLine("Möchten Sie ein Tier entfernen mit J/j bestätigen mit N/n Abbruch");
Console.Write("Eingabe: ");
string JN = Console.ReadLine();

if(JN == "N"|| JN == "n")
{
    Console.WriteLine("\nOK Selber Schuld!");
}
else if (JN == "J" || JN == "j")
{
    pfleger.tierEntfernen();
}
else
{
    Console.WriteLine("Falsche Eingabe!");
}

pfleger.getTiere();

Console.ReadKey();

static void Menu(ref int x)
{
    try
    {
        Console.WriteLine("Wählen Sie ein Tier:");
        Console.WriteLine("Hund             (1)");
        Console.WriteLine("Katze            (2)");
        Console.Write("Eingabe              : ");
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    { Console.WriteLine(ex); }
}
