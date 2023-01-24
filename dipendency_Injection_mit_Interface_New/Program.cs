using dipendency_Injection_mit_Interface_New;

var pfleger = new Tierpfleger();

while(true)
{
    try
    {
        Console.WriteLine("Möchten sie das programm beenden? Mit J/j weiter mit N/n beenden.");
        Console.Write("Eingabe: ");
        string str = Console.ReadLine();
        if(str == "N" || str == "n")
        {
            Console.WriteLine("Das programm wurde beendet!");
            break;
        }
        else if(str == "J" || str == "j")
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
            Console.WriteLine("J/j oder N/n geben Sie bitte den Richtign Buchstaben ein !");
        }
    }
    catch (Exception ex)
    { Console.WriteLine(ex.ToString()); }
    
}
Console.ReadKey();  
static void Menu(ref int x)
{
    try
    {
        Console.WriteLine("\n_______Wählen Sie ein Tier:_______");
        Console.WriteLine("Hund_____________(1)");
        Console.WriteLine("Katze____________(2)");
        Console.WriteLine("Eingabe          : ");
        x = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception ex)
    { Console.WriteLine(ex); }
}