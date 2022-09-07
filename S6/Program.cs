// Написать прогу, которая переводит десятичные цифры в двоичные.
/*
void InTwo (int number)
{
    string s = String.Empty;
    while (number > 0)
    {
        s = s + number%2;
        number = number/2;       
    }
       Console.WriteLine("Input 10 number of 2 is ");
    for (int j = s.Length-1; j >= 0; j--)
    {
        Console.Write(s[j]);
    }
}

Console.WriteLine("Input integer number ");
int number = Convert.ToInt32(Console.ReadLine());
InTwo (number); 
*/
// Вывести первые N чисел Фибоначи, где первые два числа a,b

int[] FibonachchiAr(int N, int a, int b)
{
    int[] array = new int[N];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i<N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
}

Console.WriteLine("Input number Fibonachchi: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input first number Fibonachchi: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number Fibonachchi: ");
int b = Convert.ToInt32(Console.ReadLine());
PrintArray(FibonachchiAr(N, a, b));