/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Ошибка. Введите пятизначное число");
    return;
}
//Идея такая: среднюю цифру не трогаем, т.к. она не меняется. Последние две цифры меняем местами, после эти две цифры сравниваем с первыми двумя.

//Поиск последней цифры в числе:
int number5 = number % 10;

//Поиск 4 цифры в числе:
int tempNumber4 = number / 10;
int number4 = tempNumber4 % 10;

//Переворачиваем цифры 4 и 5:
int number45 = Convert.ToInt32(number5.ToString() + number4.ToString());

//Выделяем первые две цифры из числа:
int number12 = number / 1000;

//Сравниваем number45 с number 12:
if (number45 == number12)
{
   Console.WriteLine("Число является палиндромом");
}
else
{
   Console.WriteLine("Число не является палиндромом");
}