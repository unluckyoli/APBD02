// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("and here comes sebastian vettel");
Console.WriteLine("and lando norris is on pole");
Console.WriteLine("soy lago");


Console.WriteLine("=============================================");


static double GetAverage(int[] tab)
{
    int sum = 0;
    foreach (var VARIABLE in tab)
    {
        sum += VARIABLE;
    }

    return (double)sum / tab.Length;
}

int [] numbers = {1,2,6,10,4,5,8};
double avg = GetAverage(numbers);
Console.WriteLine("srednia: "+avg);





Console.WriteLine("=============================================");


static int GetMax(int[] tab)
{
    
    if (tab == null || tab.Length == 0)
    {
        Console.WriteLine("tablica jest pusta wiec zle");
    }
    
    
    int maxValue = tab[0];
    foreach (int num in tab)
    {
        if (num > maxValue)
        {
            maxValue = num;
        }
    }
    return maxValue;
}


int maksymalna = GetMax(numbers);
Console.WriteLine("maksymalna: "+maksymalna);

Console.WriteLine("=============================================");


