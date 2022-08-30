// Написать прогу, которая заполнит массив из 8 элементов рандомно 0 и 1.

void PrintArray(int size, int a, int b)
{
    int[] zzz = new int [size]; 
    for (int i = 0; i < size; i++)
    {
       zzz [i] = new Random().Next(a,b+1);
       Console.Write(zzz[i]);
    }
}
Console.WriteLine("Vedite razmer massiva");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vedite chislo A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vedite chislo B");
int b = Convert.ToInt32(Console.ReadLine());
PrintArray(size, a, b);
