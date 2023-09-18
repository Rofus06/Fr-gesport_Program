﻿using System.Drawing;
int points = 0;

Console.WriteLine("Vilket är det besta sättet att bypass spel i?.");
Thread.Sleep(1000);
Console.WriteLine("1. C#");
Thread.Sleep(1000);
Console.WriteLine("2. C++");
Thread.Sleep(1000);
Console.WriteLine("3. Python");
Thread.Sleep(1000);
string name = Console.ReadLine().ToLower();

if (name == "1" || name == "a")
{
    Console.WriteLine("Nope, det är inte C#");
    Thread.Sleep(1000);
}


else if (name == "2" || name == "b")
{
    points++;
    Console.WriteLine("Rätt C++ är det bästa när det kommer till bypassa spel så man kan fuska");
    Thread.Sleep(2000);
    Console.WriteLine("Vilket är det bästa att använda när det kommer till börja ett eget spel för första gången?");
    Thread.Sleep(2000);
    Console.WriteLine("1. C++");
    Thread.Sleep(1000);
    Console.WriteLine("2. C#");
    Thread.Sleep(1000);
    Console.WriteLine("3. Java");
    Thread.Sleep(1000);

    string door = Console.ReadLine();
    if (door == "1" || door == "a")
    {
        Console.WriteLine("Nope, C++ är bättre om du vet hur man gör spel redan");
    } 
    else if (door == "2" || door == "b")
    {
        points++;
        Console.WriteLine("Rätt, C# är bäst när det kommer till att börja sitt eget spel");
        Thread.Sleep(2000);
        Console.WriteLine("ok sista vad är 9+10?");
        Thread.Sleep(1000);
        Console.WriteLine("1. 21");
        Thread.Sleep(1000);
        Console.WriteLine("2. 19");
        Thread.Sleep(1000);
        Console.WriteLine("3. 911");
        Thread.Sleep(1000);

        string door2 = Console.ReadLine();
        if (door2 == "1" || door2 == "a")
        {
            Console.WriteLine("what's 9 + 10...21 you stupid");
        }
        else if (door2 == "2" || door2 == "b")
        {
            points++;
            Console.WriteLine("Yay du visste det svåraste some finns");
        }
        else if (door2 == "3" || door2 == "c")
        {
           Console.WriteLine("Jag raporterar dig till twin tower bilding nu (nej du hade fel)"); 
        }
        else
        {
            Console.WriteLine("du valde inte 1, 2, 3 eller a, b, c");
        }
    }
    else if (door == "3" || door == "c")
    {
        Console.WriteLine("Nope...Nope");        
    }
    else
    {
        Console.WriteLine("du valde inte 1, 2, 3 eller a, b, c");
    }
}
else if (name == "3" || name == "c")
{
    Console.WriteLine("Nej, bara...nej");
    Thread.Sleep(1000);    
}
else
{
    Console.WriteLine("du valde inte 1, 2, 3 eller a, b, c");
}
// -----------------------------------------------------------------------------
Console.WriteLine($"Du fick {points} poäng.");
Thread.Sleep(1000);
if (points == 0)
{
  Console.WriteLine("Du är sämst grattis");
  Thread.Sleep(1000);
}
else if (points < 3)
{
  Console.WriteLine("Du vet nästan ingenting om det här HAHA");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt undrar hur, den sista var next lvl stuff");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();