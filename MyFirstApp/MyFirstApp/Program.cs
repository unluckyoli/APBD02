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

int [] numbers = {1,2,4,5};
double avg = GetAverage(numbers);
Console.WriteLine(avg);



static double GetMax(int[] tab)
{
    
}