// Napisat` progu zarkalo chisel
/*
int[] RandomArray(int size, int minElem, int maxElem)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minElem, maxElem+1);
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

int[] MirrorArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = arr[i]*-1;        
    }
    return arr;
}

Console.WriteLine("Vvedite razmer massiva");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo max");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
Console.WriteLine();
PrintArray(MirrorArray(array));
*/
/*
// Zadat` massiv i opredelit` est` li zadannoe chislo v massive

int[] RandomArray(int size, int minElem, int maxElem)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minElem, maxElem+1);
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

bool NumberArray(int[] arr, int number)
{
    for (int i=0; i<arr.Length; i++)
    {
        if (arr[i]==number)
        {
            return true;
            
        }
    }   
    return false;
}

Console.WriteLine("Vvedite razmer massiva");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo max");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo dlya proverki na nalichie v massive");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Result: {NumberArray(array, number)}");
*/

// Zadat` massiv [15]. Naiti kollichestvo elementov massiva, znachenie kotorih ot 10 do 95.

int[] RandomArray(int size, int minElem, int maxElem)
{
    int[] array = new int[size];
    for (int i = 0; i<size; i++)
    {
        array[i] = new Random().Next(minElem, maxElem+1);
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

int CountArray(int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (a <= array[i] && array[i] <= b)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Vvedite razmer massiva");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite  minimalnoe chislo massiva");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite maximalnoe chislo massiva");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = RandomArray(size, min, max);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Vvedite  diapozon poiska znachenii elementov massiva");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result: {CountArray(array, a, b)}");