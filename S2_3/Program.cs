bool Proverka(int number, int a, int b)
{
if (number%a == 0 && number%b == 0)
{
    return true;
}
else
{
    return false;
}
}

Console.WriteLine("Imput integer number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput integer a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput integer b ");
int b = Convert.ToInt32(Console.ReadLine());
bool result = Proverka(number, a, b);
Console.WriteLine($"Proverka na kratnoct`: {result}");