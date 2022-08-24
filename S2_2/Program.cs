
void Kratno12(int number1, int number2)
{
    if (number1%number2 == 0)
{
 Console.WriteLine($"{number2} kranto {number1}");
}
    else 
    {
        int ost = number1%number2;    


Console.WriteLine($"{number2} ne kranto {number1}, ostatok raven {ost}");

}
}

// start program
Console.WriteLine("Imput integer first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput integer second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

Kratno12(number1,number2);
