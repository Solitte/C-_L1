// Запрашиваем число и на выходе получаем таблица чисел квадратов от 1 до N

void SquareNumbers(int N)
{
    int count = 1;
    while (count <= N)
    {
        int i = count * count;
        count ++;
        Console.Write($"{i} ");
    }
}
Console.WriteLine("Vedite naturalnoe chislo");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
   SquareNumbers(number);
}
else
{
    Console.WriteLine($"Vvedenoe chislo {number} ne naturalnoe");
}

