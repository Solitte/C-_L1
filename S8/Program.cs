// Заполнить двухмерный массив и поменять местами строки со столбцами

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

/*
int[,] SwapColumnRowArray(int[,] table)
{
    int m = table.GetLength(1);
    int n = table.GetLength(0);
    int[,] array = new int[m,n];
    for(int i=0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        array[i,j] = table[j,i];
    }
    return array;
}
*/
/*
int[,] SwapColumnRowArray(int[,] table)
{
    int temp;
    for(int i=0; i < table.GetLength(0); i++)
    
        for(int j = 0; j < table.GetLength(1) && i != j; j++)
            {
                temp = table[i,j];
                table[i,j] = table[j,i];
                table[j,i] = temp;
            }
    return table;  
    
}
int[,] array = Random2DArray();
Print2DArray(array);
//int[,] arr = SwapColumnRowArray(array);
int[,] arr = SwapColumnRowArray(array);
Print2DArray(arr);
*/
// Заполните двухмерный массив МxN и удалите строку и столбец на пересечении наименьшего элемента

int[] DeleteRowColumn2DArray(int[,] table)
{
    int min=table[0,0];
    int m=0;
    int n=0;
        for(int i=0; i < table.GetLength(0); i++)
                for(int j = 0; j < table.GetLength(1); j++)
                    if (table[i,j] < min)
                       {
                         min = table[i,j];
                         m = i;
                         n = j;
                    }
        Console.WriteLine($"{min}; {m}; {n}");
        int[] arr = {m,n};
    return arr;
}
void PrintDel2DArray(int[,] table, int m, int n)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        if(i == m) i++;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if(j == n) j++;
            Console.Write($"{table[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();   
}
int[,] array = Random2DArray();
Print2DArray(array);
int[] arr = DeleteRowColumn2DArray(array);
PrintDel2DArray(array, arr[0], arr[1]);
