// Найти !N

int Factorial(int N)
{
int sum = 1;
for (int i = 2; i <= N; i++)
{
sum = sum * i;
}
return sum;
}
Console.WriteLine("Vedite polojitelnoe chislo");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Factorial chisla {number} is {Factorial(number)}");
