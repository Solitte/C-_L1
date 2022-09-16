// Напишите прогу, которая выдает натуральные числа от М до N.
/*
void SeriesNumbers(int m, int n)
{
    if(n > m) 
    {
        SeriesNumbers(m, n-1);
        Console.Write(n+" ");
    }
    if(m > n) 
    {
        SeriesNumbers(m, n+1);
        Console.Write(n+" ");
    }
    if(n==m) Console.Write(n+" ");
}
Console.WriteLine("Input numbers diapozon");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
SeriesNumbers(m, n);
*/

//  A в степени целочисленного B.

double AtoB( int a, int b)
{
    if (b > 0) return (AtoB(a, b-1)*a);
    
    if (b < 0) return (AtoB(a, b+1)/a);

    return 1;
    
}
Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input integer degree");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(AtoB(a, b));

