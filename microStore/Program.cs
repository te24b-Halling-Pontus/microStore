
using System.ComponentModel.DataAnnotations.Schema;
start();
static void start()
{
Console.WriteLine("Välkomen till affären");
Console.WriteLine("du har hundra kronor");
Console.WriteLine("Du kan köpa en Cola, Fanta eller Sprite");
Console.WriteLine("Priser:\nCola: 8kr\nFanta: 5kr\nSprite: 10kr");
Console.WriteLine("vad vill du köpa");
int pengar = 100;
int pris = 1;
string vad = "1";
köpaVad(pengar, vad, pris);
}

static int råd()
{
    return 1;
}

static void kAntal(int pengar, string vad)
{
    Console.WriteLine("Hur många vill du köpa");
    bool success = false;
    string fs = Console.ReadLine();
    success = int.TryParse(fs, out int antal);
    if (success == true)
    {

    }
    else if (antal < 1)
    {
        Console.WriteLine($"du kan inte köpa mindre än en {vad}");
        kAntal(pengar, vad);
    }
    else if (success == false)
    {
        Console.WriteLine("du kan inte använda bokstäver eller över integer limiten");
        kAntal(pengar, vad);
    }
}

static string köpaVad(int pengar, string vad, int pris)
{
    vad = Console.ReadLine();
    if (vad == "Cola")
    {
        return vad;
        pris = 8;
    }
    else if (vad == "Fanta")
    {
        return vad;
        pris = 5;
    }
    else if (vad == "Sprite")
    {
        return vad;
        pris = 10;
    }
    else
    {
        Console.WriteLine("Du kan bara köpa Cola, Fanta eller Sprite");
        köpaVad(pengar, vad, pris);
        return "1";

    }
    return "1";
}

Console.ReadLine();