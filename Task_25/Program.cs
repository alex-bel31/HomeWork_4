// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Применять Math.Pow нельзя!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetAndPrintValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}
int Exponentiation(int numberB, int numberA)
{
int result = 1;
for (int i = 1; i <= numberB; i++)
{
    result = result * numberA;
}
return result;
}
int numberA = GetAndPrintValue("Введите число А: ");
int numberB = GetAndPrintValue("Введите число B: ");
int result = Exponentiation(numberB, numberA);
Console.WriteLine($"{numberA}, {numberB} -> {result}");