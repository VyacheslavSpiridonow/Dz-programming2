//Задача 15: Напишите программу, 
//которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

int dayNumber = ReadInt("Введите число дня недели: ");
Console.WriteLine(weekend(dayNumber));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
string weekend(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Выходной");
        }
        else
        {
            Console.Write("Рабочий");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
    }
    return " день.";
}