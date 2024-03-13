

Console.WriteLine("Hello, World!");
Console.WriteLine("Zmiana nr 1");



int[] doPoliczenia = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 43 };
double wynik = GetAverage(doPoliczenia);

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
Console.WriteLine(wynik);



