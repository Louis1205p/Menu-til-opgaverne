using ConsoleApp5;
using System;
using System.Security.Claims;

public class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Opgave Menuen");
            Console.WriteLine("Vælg en opgave:");
            Console.WriteLine("1. Variabler");
            Console.WriteLine("2. Strings");
            Console.WriteLine("3. Aritmetiske udtryk");
            Console.WriteLine("4. Variabler i udtryk");
            Console.WriteLine("5. Boolske variabler");
            Console.WriteLine("6. If-else statements");
            Console.WriteLine("7. Switch Case");
            Console.WriteLine("8. Loops");
            Console.WriteLine("9. Udvidet kontrolstrukturer");
            Console.WriteLine("10. Metoder og instanser");
            Console.WriteLine("11. Returtyper og parametre");
            Console.WriteLine("12. Nedarvning");
            Console.WriteLine("13. Arrays");
            Console.WriteLine("14. Gennemløb af arrays");
            Console.WriteLine("15. Public, Private og Protected");
            Console.WriteLine("0. Afslut");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    VariabelOpgaver();
                    break;
                case "2":
                    StringOpgaver();
                    break;
                case "3":
                    AritmetiskeUdtryk();
                    break;
                case "4":
                    VariablerIUdtryk();
                    break;
                case "5":
                    BoolskeVariabler();
                    break;
                case "6":
                    IfElseStatements();
                    break;
                case "7":
                    SwitchCaseOpgaver();
                    break;
                case "8":
                    LoopsOpgaver();
                    break;
                case "9":
                    UdvidetKontrolstrukturer();
                    break;
                case "10":
                    MetoderOgInstanser();
                    break;
                case "11":
                    ReturtyperOgParametre();
                    break;
                case "12":
                    Nedarvning();
                    break;
                case "13":
                    ArraysOpgaver();
                    break;
                case "14":
                    GennemloebAfArrays();
                    break;
                case "15":
                    PublicPrivateProtected();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }

            if (!exit)
            {
                PauseAndReturnToMenu();
            }
        }
    }

    // Metoder for hver opgavekategori
    static void VariabelOpgaver()
    {
        bool runProgram = true;

        while (runProgram)
        {
            ShowVariabelOpgaverMenu();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Opgave1og2();
                    break;
                case "2":
                    Opgave3();
                    break;
                case "3":
                    Opgave4();
                    break;
                case "4":
                    Opgave5();
                    break;
                case "5":
                    Opgave6();
                    break;
                case "0":
                    runProgram = false;
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    PauseAndReturnToMenu();
                    break;
            }
        }
    }

    static void ShowVariabelOpgaverMenu()
    {
        Console.Clear(); // Rydder skærmen før vi viser menuen
        Console.WriteLine("Vælg en opgave:");
        Console.WriteLine("1. Opgave 1 og 2");
        Console.WriteLine("2. Opgave 3");
        Console.WriteLine("3. Opgave 4");
        Console.WriteLine("4. Opgave 5");
        Console.WriteLine("5. Opgave 6");
        Console.WriteLine("0. Tilbage til hovedmenu");
        Console.Write("Indtast dit valg: ");
    }

    static void Opgave1og2()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 1 og 2...");

        // Opgave 1 og 2
        int tal1 = 5;
        int tal2 = 3;

        Console.WriteLine("tal1 er " + tal1);
        Console.WriteLine("tal2 er " + tal2);

        PauseAndReturnToMenu();
    }

    static void Opgave3()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 3...");

        // Opgave 3
        string Navn = "Søren";
        int Alder = 16;
        double Penge = 1234.34;

        Console.WriteLine("Jeg hedder " + Navn + ", er " + Alder + " år gammel og har tjent " + Penge + "kr. på at lappe cykler.");

        PauseAndReturnToMenu();
    }

    static void Opgave4()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 4...");

        // Opgave 4
        double kagePris = 23.56;
        double ølPris = 34.67;
        double pølsePris = 65.34;

        Console.WriteLine("Kage " + kagePris);
        Console.WriteLine("Øl " + ølPris);
        Console.WriteLine("Pølse " + pølsePris);

        PauseAndReturnToMenu();
    }

    static void Opgave5()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 5...");

        // Opgave 5
        Console.Write("Indtast dit navn: ");
        string navn = Console.ReadLine();

        Console.Write("Indtast din alder: ");
        string alder = Console.ReadLine();

        Console.WriteLine("Jeg hedder " + navn + " og er " + alder + " år gammel.");

        PauseAndReturnToMenu();
    }

    static void Opgave6()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 6...");

        // Opgave 6
        Console.Write("Indtast radius af cirklen: ");
        string radiusInput = Console.ReadLine();

        double radius;
        bool succes = double.TryParse(radiusInput, out radius);

        if (succes)
        {
            double areal = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Arealet af cirklen er " + areal);
        }
        else
        {
            Console.WriteLine("Ugyldigt input, prøv igen.");
        }

        PauseAndReturnToMenu();
    }

    static void StringOpgaver()
    {
        bool runProgram = true;

        while (runProgram)
        {
            ShowStringOpgaverMenu();

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Opgave1();
                    break;
                case "2":
                    Opgave2();
                    break;
                case "3":
                    StringOpgave3();
                    break;
                case "4":
                    StringOpgave4();
                    break;
                case "0":
                    runProgram = false;
                    Console.WriteLine("Tilbage til hovedmenu...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    PauseAndReturnToMenu();
                    break;
            }
        }
    }

    static void ShowStringOpgaverMenu()
    {
        Console.Clear(); // Rydder skærmen før vi viser menuen
        Console.WriteLine("Vælg en opgave:");
        Console.WriteLine("1. Opgave 1");
        Console.WriteLine("2. Opgave 2");
        Console.WriteLine("3. Opgave 3");
        Console.WriteLine("4. Opgave 4");
        Console.WriteLine("0. Tilbage til hovedmenu");
        Console.Write("Indtast dit valg: ");
    }

    static void Opgave1()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 1...");

        // Variablerne får værdier
        int tal1 = 10;
        string tal2;
        double tal3;

        // Bruger division til at få output til at være decimal
        double decimaltal = tal1 / 4.0; //  
        tal2 = "1.2"; // Skal være en tekststreng
        tal3 = 1.3; // Skal være et decimaltal

        Console.WriteLine("int: " + decimaltal);
        Console.WriteLine("string: " + tal2);
        Console.WriteLine("double: " + tal3);

        PauseAndReturnToMenu();
    }

    static void Opgave2()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 2...");

        // Variablerne får værdier
        int tal1 = 10;
        string tal2;
        double tal3;

        // Bruger division til at få output til at være decimal
        double decimaltal = tal1 / 4.0; //  
        tal2 = "1.2"; // Skal være en tekststreng
        tal3 = 1.3; // Skal være et decimaltal

        Console.WriteLine("int: " + decimaltal);
        Console.WriteLine("string: " + tal2);
        Console.WriteLine("double: " + tal3);

        double nyVærdi = tal3 + 2.0;

        Console.WriteLine("Ny værdi for double: " + nyVærdi);

        PauseAndReturnToMenu();
    }

    static void StringOpgave3()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 3...");

        // Variablerne får værdier
        string idag;

        idag = "I dag har vi den 24. December.";

        Console.WriteLine(idag);

        PauseAndReturnToMenu();
    }

    static void StringOpgave4()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 4...");

        // Erklærer variablerne
        double tal1;
        string tekst1;
        string tekst2;

        // Giver variablerne værdier
        tal1 = 200.50;
        tekst1 = "Jeg har ";
        tekst2 = " kr. i banken";

        // Udskriver det
        Console.WriteLine("" + tekst1 + tal1 + tekst2);

        PauseAndReturnToMenu();
    }

    static void PauseAndReturnToMenu()
    {
        Console.WriteLine("\nTryk på en vilkårlig tast for at vende tilbage til menuen...");
        Console.ReadKey(true); // Brug true for at ignorere tastetryk fra input buffer
    }

    static void AritmetiskeUdtryk()
    {
        Console.WriteLine("Udfører opgaver relateret til aritmetiske udtryk...");
        // Beregningerne gemmes i variabler
        int resultat1 = 2 + 1 * 2;    // Resultat: 4
        int resultat2 = (2 + 1) * 2;// Resultat: 6
        double resultat3 = 5 / 2.0;// Resultat: 2.5
        int resultat4 = 8 % 3; // Resultat: 2
        int resultat5 = 1 - 5;// Resultat: -4

        // Udskrivning af resultaterne
        Console.WriteLine("2 + 1 * 2 = " + resultat1);
        Console.WriteLine("(2 + 1) * 2 = " + resultat2);
        Console.WriteLine("5 / 2 = " + resultat3);
        Console.WriteLine("8 % 3 = " + resultat4);
        Console.WriteLine("1 - 5 = " + resultat5);
    }

    static void VariablerIUdtryk()
    {
        Console.WriteLine("Udfører opgaver relateret til variabler i udtryk...");
        bool runProgram = true;

        while (runProgram)
        {
            Console.Clear();
            Console.WriteLine("Vælg en opgave:");
            Console.WriteLine("1. Opgave 1");
            Console.WriteLine("2. Opgave 2");
            Console.WriteLine("0. Afslut");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    VariablerIUdtrykOpgave1();
                    break;
                case "2":
                    VariablerIUdtrykOpgave2();
                    break;
                case "0":
                    runProgram = false;
                    Console.WriteLine("Afslutter programmet...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    PauseAndReturnToMenu();
                    break;
            }
        }
    }

    static void VariablerIUdtrykOpgave1()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 1...");

        // Erklærer variablerne 
        int int1 = 23;
        int int2 = 12;
        int int3 = 13;

        // Beregner resultatet
        int result = (int1 + int2) * int3;

        // Udskriver resultatet
        Console.WriteLine("result = " + result);

        PauseAndReturnToMenu();
    }

    static void VariablerIUdtrykOpgave2()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgave 2...");

        // Erklærer variablerne 
        int int1 = 23;
        int int2 = 12;
        int int3 = 13;

        // Beregner resultatet
        int result = (int1 + int2) * int3;
        Console.WriteLine("Resultatet af (int1 + int2) * int3 = " + result);

        // Blander variabler og tal
        int mix1 = int1 + 5;
        int mix2 = int2 * 2;
        int mix3 = int3 - 7;
        int mix4 = int1 % int2;

        // Resultaterne af blandede udtryk
        Console.WriteLine("int1 + 5 = " + mix1);
        Console.WriteLine("int2 * 2 = " + mix2);
        Console.WriteLine("int3 - 7 = " + mix3);
        Console.WriteLine("int1 % int2 = " + mix4);

        PauseAndReturnToMenu();
    }

    static void BoolskeVariabler()
    {
        Console.WriteLine("Udfører opgaver relateret til boolske variabler...");
        // erklærer variablerne
        int var1 = 23;
        int var2 = 12;

        // giver værdien var1 > var
        bool erVar1StørreEndVar2 = var1 > var2;

        Console.WriteLine(" er var1 større end var2? " + erVar1StørreEndVar2);

        // ændrer på var1 så det bliver false
        var1 = 11;
        erVar1StørreEndVar2 = var1 > var2;

        Console.WriteLine(" er var1 større end var2? " + erVar1StørreEndVar2);
    }

    static void IfElseStatements()
    {
        Console.WriteLine("Udfører opgaver relateret til if-else statements...");
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Opgave Menuen");
            Console.WriteLine("Vælg en opgave:");
            Console.WriteLine("1. If-Else Opgave 1");
            Console.WriteLine("2. If-Else Opgave 2");
            Console.WriteLine("3. If-Else Opgave 3");
            Console.WriteLine("4. Login Opgave");
            Console.WriteLine("5. Brugernavn og Password Opgave");
            Console.WriteLine("6. Fradrag Opgave");
            Console.WriteLine("7. Farve og Alder Opgave");
            Console.WriteLine("0. Afslut");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    IfElseOpgave1();
                    break;
                case "2":
                    IfElseOpgave2();
                    break;
                case "3":
                    IfElseOpgave3();
                    break;
                case "4":
                    LoginOpgave();
                    break;
                case "5":
                    BrugernavnOgPasswordOpgave();
                    break;
                case "6":
                    FradragOpgave();
                    break;
                case "7":
                    FarveOgAlderOpgave();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }

            if (!exit)
            {
                PauseAndReturnToMenu();
            }
        }
    }

    static void IfElseOpgave1()
    {
        Console.Clear();
        Console.WriteLine("Udfører If-Else opgave 1...");

        // Erklær variablerne
        int tal1 = 42;
        int tal2 = 64;

        // Beregn resultatet
        int result = tal1 + tal2;

        // Tjek resultatet og udskriv besked
        switch (result)
        {
            case int n when (n > 100):
                Console.WriteLine("Summen er større end 100!");
                break;
            case int n when (n < 100):
                Console.WriteLine("Summen er mindre end 100.");
                break;
            default:
                Console.WriteLine("Summen er 100");
                break;
        }
    }

    static void IfElseOpgave2()
    {
        Console.Clear();
        Console.WriteLine("Udfører If-Else opgave 2...");

        // Brugeren skal indtaste sin alder
        Console.Write("Indtast din alder: ");
        if (int.TryParse(Console.ReadLine(), out int alder))
        {
            // Kontrollere alderen
            switch (alder)
            {
                case int a when (a > 57):
                    Console.WriteLine("Du er for gammel.");
                    break;
                default:
                    Console.WriteLine("Du er ikke for gammel.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input.");
        }
    }

    static void IfElseOpgave3()
    {
        Console.Clear();
        Console.WriteLine("Udfører If-Else opgave 3...");

        // Brugeren skal indtaste sin alder
        Console.Write("Indtast din alder: ");
        if (int.TryParse(Console.ReadLine(), out int alder))
        {
            // Kontrollere alderen
            switch (alder)
            {
                case int a when (a > 60):
                    Console.WriteLine("Du er for gammel.");
                    break;
                case int a when (a < 50):
                    Console.WriteLine("Du er ikke for gammel.");
                    break;
                default:
                    Console.WriteLine("Du er hverken for gammel eller for ung.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input.");
        }
    }

    static void LoginOpgave()
    {
        Console.Clear();
        Console.WriteLine("Udfører Login Opgave...");

        // Giver variablerne værdier
        string korrektNavn = "Louis";
        string korrektBrugernavn = "Louis123";
        string korrektPassword = "1234";

        // Brugeren skal indtaste oplysninger
        Console.Write("Indtast dit navn: ");
        string navn = Console.ReadLine();

        Console.Write("Indtast dit brugernavn: ");
        string brugernavn = Console.ReadLine();

        Console.Write("Indtast dit password: ");
        string password = Console.ReadLine();

        // Kontrollere brugernavn, password og navn
        switch (true)
        {
            case var _ when (brugernavn == korrektBrugernavn && password == korrektPassword):
                Console.WriteLine("Velkommen " + korrektNavn);
                break;
            default:
                Console.WriteLine("Brugernavn eller password er forkert");
                break;
        }
    }

    static void BrugernavnOgPasswordOpgave()
    {
        Console.Clear();
        Console.WriteLine("Udfører Brugernavn og Password Opgave...");

        // Giver variablerne værdier
        string korrektBrugernavn = "Louis123";
        string korrektPassword = "1234";

        // Brugeren skal indtaste oplysninger
        Console.Write("Indtast dit brugernavn: ");
        string brugernavn = Console.ReadLine();

        if (brugernavn == korrektBrugernavn)
        {
            Console.Write("Indtast dit password: ");
            string pass = Console.ReadLine();

            switch (pass)
            {
                case var p when (p == korrektPassword):
                    Console.WriteLine("Velkommen " + korrektBrugernavn);
                    break;
                default:
                    Console.WriteLine("Password er forkert");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Brugernavnet er forkert");
        }
    }

    static void FradragOpgave()
    {
        Console.Clear();
        Console.WriteLine("Udfører Fradrag Opgave...");

        // Spørger brugeren
        Console.Write("Hvor mange kilometer kører du hver dag til og fra arbejde? ");
        if (double.TryParse(Console.ReadLine(), out double kmPerDag))
        {
            double fradrag = 0;

            switch (kmPerDag)
            {
                case double km when (km < 25):
                    Console.WriteLine("Du får ikke noget fradrag.");
                    break;
                case double km when (km < 121):
                    fradrag = (km - 24) * 1.93;
                    Console.WriteLine("Dit fradrag er " + fradrag.ToString("F2") + " kr. pr. dag.");
                    break;
                default:
                    fradrag = 96 * 1.93 + (kmPerDag - 120) * 0.97;
                    Console.WriteLine("Dit fradrag er " + fradrag.ToString("F2") + " kr. pr. dag.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input.");
        }
    }

    static void FarveOgAlderOpgave()
    {
        Console.Clear();
        Console.Title = "Festen";

        // Spørger brugeren
        Console.Write("Hvilken farve kan du bedst lide af rød, grøn, blå og gul? ");
        string farve = Console.ReadLine().ToLower();

        Console.Write("Hvor gammel er du? ");
        if (int.TryParse(Console.ReadLine(), out int alder))
        {
            // Skifter baggrundsfarven
            switch (farve)
            {
                case "rød":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "grøn":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "blå":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "gul":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg");
                    break;
            }
            Console.Clear();

            // Viser besked baseret på alder
            switch (alder)
            {
                case int a when (a > 18):
                    Console.WriteLine("Velkommen til cocktailbaren");
                    break;
                default:
                    Console.WriteLine("Velkommen til sodavandsbaren");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input.");
        }
    }

    static void SwitchCaseOpgaver()
    {
        Console.WriteLine("Udfører opgaver relateret til switch-case...");
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Opgave Menuen");
            Console.WriteLine("1. Opgave 1: Number Selection");
            Console.WriteLine("2. Opgave 2: Drink Selection");
            Console.WriteLine("0. Afslut");

            Console.Write("Vælg en opgave (1-2) eller 0 for at afslutte: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    NumberSelection();
                    break;
                case "2":
                    DrinkSelection();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg. Prøv igen.");
                    break;
            }

            if (!exit)
            {
                PauseAndReturnToMenu();
            }
        }
    }

    static void NumberSelection()
    {
        Console.Clear();
        Console.WriteLine("Vælg et tal mellem 1 og 6:");

        // Indtast et tal fra 1 til 6
        Console.Write("Indtast et tal (1-6): ");
        if (double.TryParse(Console.ReadLine(), out double brugerTal))
        {
            switch (brugerTal)
            {
                case 1:
                    Console.WriteLine("Du har valgt tal 1");
                    break;
                case 2:
                    Console.WriteLine("Du har valgt tal 2");
                    break;
                case 3:
                    Console.WriteLine("Du har valgt tal 3");
                    break;
                case 4:
                    Console.WriteLine("Tillykke du har vundet");
                    break;
                case 5:
                    Console.WriteLine("Du har valgt tal 5");
                    break;
                case 6:
                    Console.WriteLine("Du har valgt tal 6");
                    break;
                default:
                    Console.WriteLine("FORKERT PRØV IGEN");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input. Indtast et gyldigt tal.");
        }
    }

    static void DrinkSelection()
    {
        Console.Clear();
        // Vis menuen med drinks
        Console.WriteLine("Vælg en drink:");
        Console.WriteLine("1. Isbjørn");
        Console.WriteLine("2. Champagnebrus");
        Console.WriteLine("3. Tequila Sunrise");
        Console.WriteLine("4. Mojito");
        Console.WriteLine("5. Brandbil");
        Console.WriteLine("6. Filur");

        // Indtast det tilsvarende tal for at vælge en drink
        Console.Write("Indtast det tilsvarende tal (1-6): ");
        if (double.TryParse(Console.ReadLine(), out double brugerTal))
        {
            switch (brugerTal)
            {
                case 1:
                    Console.WriteLine("Du valgte Isbjørn");
                    break;
                case 2:
                    Console.WriteLine("Du valgte Champagnebrus");
                    break;
                case 3:
                    Console.WriteLine("Du valgte Tequila Sunrise");
                    break;
                case 4:
                    Console.WriteLine("Du valgte Mojito");
                    break;
                case 5:
                    Console.WriteLine("Du valgte Brandbil");
                    break;
                case 6:
                    Console.WriteLine("Du valgte Filur");
                    break;
                default:
                    Console.WriteLine("FORKERT PRØV IGEN");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ugyldigt input. Indtast et gyldigt tal.");
        }
    }

    static void LoopsOpgaver()
    {
        Console.WriteLine("Udfører opgaver relateret til loops...");
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Clear();
            Console.WriteLine("Vælg en opgave:");
            Console.WriteLine("1. LoopsOpgave1: Tæl op fra 1 til 10");
            Console.WriteLine("2. LoopsOpgave2: Tæl ned fra 100 til 1");
            Console.WriteLine("3. LoopsOpgave3: Tæl op og gang med 5");
            Console.WriteLine("4. LoopsOpgave4: Tæl ned fra 20 til 0");
            Console.WriteLine("5. LoopsOpgave5: Tæl op og gang med 7");
            Console.WriteLine("6. LoopsOpgave6: Multiplikationstabellen for et brugerdefineret tal");
            Console.WriteLine("7. LoopsOpgave7: Tegn en rektangel med karakterer");
            Console.WriteLine("8. LoopsOpgave8: Tegn en rektangel med navn i midten");
            Console.WriteLine("9. LoopsOpgave9: Tegn en brugerdefineret rektangel med navn i midten");
            Console.WriteLine("0. Afslut");
            Console.Write("Indtast dit valg: ");

            int valg = int.Parse(Console.ReadLine());

            switch (valg)
            {
                case 1:
                    LoopsOpgave1();
                    break;
                case 2:
                    LoopsOpgave2();
                    break;
                case 3:
                    LoopsOpgave3();
                    break;
                case 4:
                    LoopsOpgave4();
                    break;
                case 5:
                    LoopsOpgave5();
                    break;
                case 6:
                    LoopsOpgave6();
                    break;
                case 7:
                    Console.Clear();
                    LoopsOpgave7();
                    break;
                case 8:
                    Console.Clear();
                    LoopsOpgave8();
                    break;
                case 9:
                    Console.Clear();
                    LoopsOpgave9();
                    break;
                case 0:
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    break;
            }

            if (valg != 0)
            {
                Console.WriteLine("Tryk på en vilkårlig tast for at fortsætte...");
                Console.ReadKey();
            }
        }
    }

    static void LoopsOpgave1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void LoopsOpgave2()
    {
        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }

    static void LoopsOpgave3()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i * 5);
        }
    }

    static void LoopsOpgave4()
    {
        int i = 20;
        while (i >= 0)
        {
            Console.WriteLine(i);
            i--;
        }
    }

    static void LoopsOpgave5()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i * 7);
        }
    }

    static void LoopsOpgave6()
    {
        Console.Write("Indtast et tal: ");
        int tal = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(tal * i);
        }
    }

    static void LoopsOpgave7()
    {
        int startX = 20;
        int startY = 4;
        int endX = 30;
        int endY = 8;

        for (int x = startX; x <= endX; x++)
        {
            Console.SetCursorPosition(x, startY);
            Console.Write("c");
            Console.SetCursorPosition(x, endY);
            Console.Write("c");
        }

        for (int y = startY; y <= endY; y++)
        {
            Console.SetCursorPosition(startX, y);
            Console.Write("u");
            Console.SetCursorPosition(endX, y);
            Console.Write("u");
        }

        Console.SetCursorPosition(0, endY + 2);
    }

    static void LoopsOpgave8()
    {
        int startX = 20;
        int startY = 4;
        int endX = 30;
        int endY = 8;

        for (int x = startX; x <= endX; x++)
        {
            Console.SetCursorPosition(x, startY);
            Console.Write("c");
            Console.SetCursorPosition(x, endY);
            Console.Write("c");
        }

        for (int y = startY; y <= endY; y++)
        {
            Console.SetCursorPosition(startX, y);
            Console.Write("u");
            Console.SetCursorPosition(endX, y);
            Console.Write("u");
        }

        string name = "Louis";
        int textWidth = name.Length;
        int middleX = (startX + endX) / 2;
        int middleY = (startY + endY) / 2;

        int adjustedX = middleX - textWidth / 2;

        if (adjustedX < startX) adjustedX = startX;
        if (adjustedX + textWidth > endX) adjustedX = endX - textWidth;

        Console.SetCursorPosition(adjustedX, middleY);
        Console.Write(name);

        Console.SetCursorPosition(0, endY + 2);
    }

    static void LoopsOpgave9()
    {
        Console.Write("Indtast rammens bredde: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Indtast rammens højde: ");
        int height = int.Parse(Console.ReadLine());

        int startX = 20;
        int startY = 4;
        int endX = startX + width - 1;
        int endY = startY + height - 1;

        Console.Write("Indtast dit navn: ");
        string name = Console.ReadLine();

        for (int x = startX; x <= endX; x++)
        {
            Console.SetCursorPosition(x, startY);
            Console.Write("c");
            Console.SetCursorPosition(x, endY);
            Console.Write("c");
        }

        for (int y = startY; y <= endY; y++)
        {
            Console.SetCursorPosition(startX, y);
            Console.Write("u");
            Console.SetCursorPosition(endX, y);
            Console.Write("u");
        }

        int textWidth = name.Length;
        int middleX = (startX + endX) / 2;
        int middleY = (startY + endY) / 2;

        int adjustedX = middleX - textWidth / 2;

        if (adjustedX < startX) adjustedX = startX;
        if (adjustedX + textWidth > endX) adjustedX = endX - textWidth;

        Console.SetCursorPosition(adjustedX, middleY);
        Console.Write(name);

        Console.SetCursorPosition(0, endY + 2);
    }

    static void UdvidetKontrolstrukturer()
    {
        Console.WriteLine("Udfører opgaver relateret til udvidet kontrolstrukturer...");
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Clear(); // Rydder skærmen
            Console.WriteLine("Vælg en opgave:");
            Console.WriteLine("1. Multiplikation og stop ved 21");
            Console.WriteLine("2. Multiplikation og fortsæt uden 16");
            Console.WriteLine("3. Befordringsfradrag beregning");
            Console.WriteLine("4. Skatteberegning");
            Console.WriteLine("5. Renteberegning");
            Console.WriteLine("0. Afslut");
            Console.Write("Indtast dit valg: ");

            int valg = int.Parse(Console.ReadLine());

            switch (valg)
            {
                case 1:
                    Console.Clear();
                    MultiplikationStopVed21();
                    break;
                case 2:
                    Console.Clear();
                    MultiplikationUden16();
                    break;
                case 3:
                    Console.Clear();
                    BefordringsfradragBeregning();
                    break;
                case 4:
                    Console.Clear();
                    Skatteberegning();
                    break;
                case 5:
                    Console.Clear();
                    Renteberegning();
                    break;
                case 0:
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Ugyldigt valg, prøv igen.");
                    break;
            }

            if (valg != 0)
            {
                Console.WriteLine("Tryk på en vilkårlig tast for at vende tilbage til menuen...");
                Console.ReadKey(); // Venter på brugeren
            }
        }
    }

    static void MultiplikationStopVed21()
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = i * 3;
            Console.WriteLine(result);

            if (result == 21)
            {
                Console.WriteLine("Loopen er nu stoppet");
                break;
            }
        }
    }

    static void MultiplikationUden16()
    {
        for (int i = 1; i <= 10; i++)
        {
            int result = i * 4;

            if (result == 16)
            {
                continue; // Hopper over resten af denne iteration
            }
            Console.WriteLine(result);
        }
        Console.WriteLine("Loopen er nu stoppet");
    }

    static void BefordringsfradragBeregning()
    {
        Console.Write("Indtast antal kilometer: ");
        double antalKilometer = Convert.ToDouble(Console.ReadLine());

        double fradrag = 0.0;

        if ((antalKilometer > 24 && antalKilometer <= 100) || antalKilometer > 100)
        {
            if (antalKilometer > 24 && antalKilometer <= 100)
            {
                fradrag += (antalKilometer - 24) * 1.54;
            }
            if (antalKilometer > 100)
            {
                fradrag += (100 - 24) * 1.54;
                fradrag += (antalKilometer - 100) * 0.77;
            }
        }

        Console.WriteLine("Dit befordringsfradrag er: " + fradrag + " DKK");
    }

    static void Skatteberegning()
    {
        Console.Write("Indtast din indkomst: ");
        double indkomst = Convert.ToDouble(Console.ReadLine());

        double skat = 0.0;
        double bundskat = 0.0;
        double mellemskat = 0.0;
        double topskat = 0.0;

        if (indkomst >= 42000 && indkomst < 280000)
        {
            bundskat = indkomst * 0.30;
        }
        else if ((indkomst >= 280000 && indkomst < 390000) || indkomst >= 390000)
        {
            bundskat = indkomst * 0.30;
            mellemskat = indkomst * 0.06;

            if (indkomst >= 390000)
            {
                topskat = indkomst * 0.15;
            }
        }

        skat = bundskat + mellemskat + topskat;

        Console.WriteLine("Din skat er " + skat + " kr.");
    }

    static void Renteberegning()
    {
        Console.Write("Indtast det beløb du vil se rente på: ");
        double beloeb = Convert.ToDouble(Console.ReadLine());

        double rente = 0.0;

        if (beloeb < 25000)
        {
            rente = beloeb * 0.25 / 100;
        }
        else if (beloeb >= 25000 && beloeb <= 150000)
        {
            rente = beloeb * 1.25 / 100;
        }
        else if (beloeb > 150000 || beloeb == 150000)
        {
            rente = (150000 * 1.25 / 100) + ((beloeb - 150000) * 0.5 / 100);
        }

        Console.WriteLine("Renten er " + rente.ToString("F2") + " kr.");
    }

    static void MetoderOgInstanser()
    {
        Console.WriteLine("Udfører opgaver relateret til metoder og instanser...");
        // Opretter et nyt Bog-objekt kaldet SherlockHolmes
        Bog SherlockHolmes = new Bog();

        // Kald PrintInfo metoden på SherlockHolmes objektet
        SherlockHolmes.PrintInfo();
    }

    static void ReturtyperOgParametre()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgaver relateret til returtyper og parametre...");

        Bil minBil = new Bil();

        minBil.StartMotor();
        minBil.StopMotor();

        double liters = 2.5;

        minBil.FillGas(liters, true);

        double remaining = minBil.RemainingGas();
        Console.WriteLine($"Remaining gas: {remaining} liters");

        Console.WriteLine($"Remaining gas: {minBil.RemainingGas()} liters");

        Console.WriteLine("\nTryk på en tast for at vende tilbage til hovedmenuen...");
        Console.ReadKey();

        Console.Clear();

    }

    static void Nedarvning()    
    {
        Console.Clear();
        Console.WriteLine("Udfører opgaver relateret til nedarvning...");

        Chair myChair = new Chair("Plastik", "Blå", 199.99, false);
        Computer myComputer = new Computer("Aluminium", "Sølv", 7999.99, "intel i7");

        Console.WriteLine("Stolen:");
        myChair.PrintInfo();

        Console.WriteLine("");

        Console.WriteLine("Computeren:");
        myComputer.PrintInfo();

        Console.WriteLine("\nTryk på en tast for at vende tilbage til hovedmenuen...");
        Console.ReadKey();

        Console.Clear();

    }

    static void ArraysOpgaver()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgaver relateret til arrays...");

        int[] array1 = { -2, -1, 0, 10 };

        int[] array2 = new int[4];
        array2[0] = -2;
        array2[1] = -1;
        array2[2] = 0;
        array2[3] = 10;


        Console.WriteLine("10 fra array1: " + array1[3]);
        Console.WriteLine("-1 fra array1: " + array1[1]);

        int sum = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            sum += array1[i];
        }
        Console.WriteLine("Summen af all ei array1: " + sum);

        Console.WriteLine("\nTryk på en tast for at vende tilbage til hovedmenuen...");
        Console.ReadKey();
        Console.Clear();
    }

    static void GennemloebAfArrays()
    {
        Console.Clear();
        Console.WriteLine("Vælg en opgave:");
        Console.WriteLine("1. Gennemløb af array med heltal og udregn summen");
        Console.WriteLine("2. Gennemløb af array med strenge og vis dem");
        Console.Write("Indtast dit valg (1 eller 2): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                GennemloebAfArrayOpg1();
                break;
            case "2":
                GennemloebAfArrayOpg2();
                break;
            default:
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                break;
        }
    }

    public static void GennemloebAfArrayOpg1()
    {
        int[] numbers = { 5, 10, 15, 20, 25, 30 };

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("Summen af elementerne i tal-arrayet: " + sum);
    }

    public static void GennemloebAfArrayOpg2()
    {
        string[] words = { "Æble", "Banan", "Appelsin", "Pære", "Drue" };

        Console.WriteLine("String array indeholder:");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }

    static void PublicPrivateProtected()
    {
        Console.Clear();
        Console.WriteLine("Udfører opgaver relateret til public, private og protected...");

        Console.WriteLine("Vælg et emne for at få en forklaring:");
        Console.WriteLine("1. Private");
        Console.WriteLine("2. Protected");
        Console.WriteLine("3. Public");
        Console.WriteLine("4. Indkapsling");
        Console.Write("Indtast dit valg (1-4): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("Private: Når noget er markeret som 'private', betyder det, at det kun kan bruges eller tilgås inden for den samme klasse, hvor det er defineret. Det skjuler data fra andre klasser.");
                break;
            case "2":
                Console.WriteLine("Protected: 'Protected' betyder, at noget kan bruges i den klasse, hvor det er defineret, og i alle klasser, der nedarver fra den. Det er tilgængeligt for underklasser, men skjult for andre klasser.");
                break;
            case "3":
                Console.WriteLine("Public: Når noget er 'public', kan det tilgås af alle, både inden for klassen og fra andre klasser eller objekter i programmet. Det er helt åbent.");
                break;
            case "4":
                Console.WriteLine("Indkapsling: Indkapsling handler om at beskytte data og kontrollere, hvordan de bruges. Det hjælper med at sikre, at data ikke ændres på uhensigtsmæssige måder og holder koden mere sikker og overskuelig.");
                break;
            default:
                Console.WriteLine("Ugyldigt valg. Prøv igen.");
                break;
        }

        Console.WriteLine("\nTryk på en tast for at vende tilbage til hovedmenuen...");
        Console.ReadKey();
        Console.Clear();
    }
}
