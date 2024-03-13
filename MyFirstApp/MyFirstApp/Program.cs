// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("and here comes sebastian vettel");
Console.WriteLine("and lando norris is on pole");
Console.WriteLine("soy lago");

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



static int GetMax(int[] tab)
{
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

