
Console.WriteLine("Välkomen till affären");
Console.WriteLine("du har hundra kronor");
Console.WriteLine("Du kan köpa en Cola [1], Fanta [2] eller Sprite [3]");
Console.WriteLine("Priser: n\ Cola: 8kr n\ Fanta: 5kr n\ Sprite: 10kr")
Console.WriteLine("vad vill du köpa")
int pengar = 100;
köpaVad(pengar);



static int råd()
{
    
}

static void kAntal(int pengar)
{
    Console.WriteLine("Hur många vill du köpa")
    bool success = false;
    string fs = Console.ReadLine();
    success = int.TryParse(fs, out int antal);
    if (success == true)
    {

    }
    else if (antal < 1)
    {
        Console.WriteLine("du kan inte köpa mindre än en av föremålet")
        kAntal(pengar);
    }
    }
    else if (success == false)
    {
        Console.WriteLine("du kan inte köpa mindre än en av föremålet")
        kAntal(pengar);
    }


}

static void köpaVad(int pengar)
{
    bool success = false;
    string fs = Console.ReadLine();
    success = int.TryParse(fs, out int vad);
    if (success == true)
    {
        if (vad > 0 || 3 > vad)
        {
            kAntal(pengar);
        }
        else
        {
            Console.WriteLine("Du kan bara köpa Cola [1], Fanta [2] eller Sprite [3]")
            köpaVad(pengar);
        }
    }
}

Console.ReadLine();