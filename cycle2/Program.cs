/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
int ReadInt(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadInt("Введите буку А ");
int numberB = ReadInt("Введите буку B ");
Numbers(numberA, numberB);
void Numbers(int a, int b)
{
    int degree = 1;
    for(int i = 1; i <= b; i++)
    {
        degree = degree * a;
    }    
        Console.WriteLine(degree);
}

