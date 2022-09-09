// заполнить двухмерный массив i+j
/*
int[,] Random2DArray()
{
    Console.WriteLine("Input the rows of the array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

   
    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            table[i,j] = i + j;
    
    return table;
}

void Print2DArray(int[,] table)
{
    Console.WriteLine();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write($"{table[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();   
}

int[,] table = Random2DArray();
Print2DArray(table);
*/
// Заполните двухмерный массив MxN, и найти элементы у которых оба индекса четные, и заменить элемент на его квадрад.

int[,] Random2DArray()
{
    Console.WriteLine("Input the rows of the array");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the columns of the array");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the minimum number of the array");
    int minElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the maximum number of the array");
    int maxElem = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] table = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            table[i,j] = new Random().Next(minElem, maxElem+1);
    
    return table;
}

void Print2DArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
            Console.Write($"{table[i,j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();   
}

int[,] SquarElements2DArray(int[,] table)
{
    for ( int i = 0; i < table.GetLength(0); i++)
    {
      if (i%2 == 0)
      {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (j%2 == 0) table[i,j] = Convert.ToInt32(Math.Pow(table[i,j],2));
        }
      }  
    }
    return table;
}

int[,] table = Random2DArray();
Print2DArray(table);
int[,] array = SquarElements2DArray(table);
Print2DArray(array);
