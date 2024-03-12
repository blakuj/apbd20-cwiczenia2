

Console.WriteLine("Hello, World!");
Console.WriteLine("Zmiana nr 1");


static double GetAverage(int [] tab)
{
    double srednia;
    double suma = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        suma += tab[i];
        
    }

    srednia = suma / tab.Length;

    return srednia;
}

