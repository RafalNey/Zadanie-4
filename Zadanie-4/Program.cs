string imie = "Ewa";
char plec = 'K';
int wiek = 33;

if (wiek >= 30)
{
    Console.WriteLine($"{imie}, lat {wiek}");
}
else if (plec == 'K')
{
    if (wiek < 18)
    {
        Console.WriteLine("Niepelnoletnia Kobieta");
    }
    else
    {
        Console.WriteLine("Kobieta ponizej 30 lat");
    }
}
else if (plec != 'K')
{
    if (wiek < 18)
    {
        Console.WriteLine("Niepelnoletni Mezczyzna");
    }
    else
    {
        Console.WriteLine("Mezczyzna ponizej 30 lat");
    }
}