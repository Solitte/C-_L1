// Является ли первое число квадратом второго или наоборот
bool Proverka(int number1, int number2)
{
if (number1*number1 == number2 || number2*number2 == number1)
{
    return true;
}
else
{
    return false;
}
}

Console.WriteLine("Input integer number1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input integer number2 ");
int number2 = Convert.ToInt32(Console.ReadLine());
bool result = Proverka(number1, number2);
Console.WriteLine($"Proverka: {result}");