/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double A = ReadInt("Введите число А ");
double B = ReadInt("Введите число B ");
double degree = Math.Pow(A, B);
while(true)
{
Console.WriteLine($"{A}, {B} -> {degree}");
break;
}


double ReadInt(string message)
{
Console.Write(message);
return Convert.ToDouble(Console.ReadLine());
}