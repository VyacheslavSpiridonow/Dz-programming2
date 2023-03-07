//Задача 13: Напишите программу, 
//которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number = 645;
int count = number.ToString().Length;
Console.Write(Array(number, count));
int Array(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.WriteLine("Третьей цифры нет, ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}