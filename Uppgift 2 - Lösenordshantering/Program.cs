//Uppgift 2: Lösenordshantering, “inputCheck”

using System.ComponentModel;
using Uppgift_2___Lösenordshantering;

void Lösenord()
{
    string input = ",";

    //Ska fråga vad lösenordet ska vara, säger även kraven till lösenordet
    info.lösenordinfo sparalösenord = new info.lösenordinfo();
    Console.WriteLine("Skapa ett lösenord, Krav: 5 till 20 tecken");

    while (input != "ex")
    {

        //Här ska den läsa av det lösenordet som skrivtsl om det fyller kraven ska den printa "Lösenordet du precis valde funkar bra!"
        input = Console.ReadLine();
        if (input == "ok")
        {
            Console.WriteLine(sparalösenord.visalösenord());
        }

        else
        {
            if (input.Length > 5)
            {
                if (input.Length < 20)
                {
                    sparalösenord.setlösenord(input);
                    Console.WriteLine("Lösenordet du precis valde funkar bra!");
                    Console.WriteLine("Vill du att ditt nuvarande lösenord ska skrivas ut? I så fall skriv 'ok'");
                }
            }

            //Här ska den läsa av det lösenordet som skrivits, om det inte fyllt kraven ska den printa ett error meddelande
            else
            {
                Console.WriteLine("Lösenordet du precis valde funkar ej.");
                Console.WriteLine("Kommentar: Lösenordet uppfyller inte kraven.");
                Console.WriteLine("Välj gärna ett nytt lösenord som uppfyller kraven.");
            }
        }
    }
}
Lösenord();