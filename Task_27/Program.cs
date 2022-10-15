// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int GetAndPrintValue(string msg)
{
    Console.WriteLine(msg);
    string input = Console.ReadLine();
    int value = int.Parse(input);
    return value;
}
int SumOfDigits(int number)
{
int result = 0;
while (number > 0)
{
    result = result + number % 10;
    number = number /10 ;
}
return result;
}
int number = GetAndPrintValue("Введите число: ");
int result = SumOfDigits(number);
Console.WriteLine($"{number} -> {result}");
