// Ввести номер четверти, в которой находится точка и получить результат диапозон (x,y)

void Diapozon(int num)
{
    if (num == 1) Console.WriteLine("Diapozon x>0 i y>0");
    if (num == 2) Console.WriteLine("Diapozon x<0 i y>0");    
    if (num == 3) Console.WriteLine("Diapozon x<0 i y<0");    
    if (num == 4) Console.WriteLine("Diapozon x>0 i y<0");
    if (num < 1 || num > 4) Console.WriteLine("Neverno vvedena chetvert");

}
Console.WriteLine("Vedite nomer chetverti");
int number = Convert.ToInt32(Console.ReadLine());
Diapozon(number);