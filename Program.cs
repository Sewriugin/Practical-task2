// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//                                      ПРАКТИЧЕСКОЕ ЗАДАНИЕ 2
// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//            1) 456 -> 5; 2) 782 -> 8; 3) 918 -> 1

// --- 1 способ, реализация без метода ---
System.Console.Write("Введите число трёхзначное число: ");
int threeDigitNumber1 = Convert.ToInt32(Console.ReadLine());
threeDigitNumber1 = (threeDigitNumber1 / 10) % 10;
Console.WriteLine("вторая цифра числа: " + threeDigitNumber1);

// --- 2 способ, реализация с использованием метода ---
void threeDigitNumber ()// реализация метода
{
    System.Console.Write("Введите число трёхзначное число: ");
    int threeDigitNumber2 = Convert.ToInt32(Console.ReadLine());
    threeDigitNumber2 = (threeDigitNumber2 / 10) % 10;
    Console.WriteLine("вторая цифра числа: " + threeDigitNumber2);
}

 threeDigitNumber ();// вызов метода

// -------------------------------------------------------------------------------------------------------------

//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//           1) 456 -> 5; 2) 782 -> 8; 3) 918 -> 1
//--- 1 способ, реализация без метода ---
int threeDigitNumber3 = new Random().Next(100, 1000);
Console.Write("Трёхзначное число: " + threeDigitNumber3 + "; ");
int threeDigitNumber31 = (threeDigitNumber3 % 10);
int threeDigitNumber32 = (threeDigitNumber3 / 100) % 10;
Console.Write("первая цифра числа: " + threeDigitNumber31 + "; " + "третья цифра числа: " + threeDigitNumber32);
Console.WriteLine(" число: " + threeDigitNumber31 + threeDigitNumber32);

// --- 2 способ, реализация с использованием метода ---
void threeDigitNumber4 ()// реализация метода
{
    int threeDigitNumber4 = new Random().Next(100, 1000);
    Console.Write("Трёхзначное число: " + threeDigitNumber4 + "; ");
    int threeDigitNumber41 = (threeDigitNumber4 % 10);
    int threeDigitNumber42 = (threeDigitNumber4 / 100) % 10;
    Console.Write("первая цифра числа: " + threeDigitNumber41 + "; " + "третья цифра числа: " + threeDigitNumber42);
    Console.WriteLine(" число: " + threeDigitNumber41 + threeDigitNumber42);
}

threeDigitNumber4 ();// вызов метода

// -------------------------------------------------------------------------------------------------------------

//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//          1) 645 -> 5; 2) 78 -> третьей цифры нет; 3) 32679 -> 6

// --- 1 способ, реализация без метода ---
System.Console.Write("Введите число: ");
int digitNumber1 = Convert.ToInt32(Console.ReadLine());
if (digitNumber1 > 100)
{
    digitNumber1 = (digitNumber1 / 100) % 10;
    Console.WriteLine("третья цифра числа: " + digitNumber1);
}
else
{
   Console.WriteLine("третьей цифры числа нет");
}

// --- 2 способ, реализация с использованием метода ---
void digitNumber2 ()// реализация метода
{
    System.Console.Write("Введите число: ");
    int digitNumber2 = Convert.ToInt32(Console.ReadLine());
    if (digitNumber2 > 100)
        {
        digitNumber2 = (digitNumber2 / 100) % 10;
        Console.WriteLine("третья цифра числа: " + digitNumber2);
        }
        else
        {
        Console.WriteLine("третьей цифры числа нет");
        }
}

digitNumber2();// вызов метода

// -------------------------------------------------------------------------------------------------------------

//Задача 4. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
//является ли этот день выходным.
//             1) 6 -> да; 2) 7 -> да; 3) 1 -> нет
System.Console.Write("Введите день недели: ");
double a = Convert.ToInt32(Console.ReadLine());
if (a < 1 || a > 7 || a == 6 || a == 7) Console.WriteLine("Нет такого дня недели");
else
if (a == 1) Console.WriteLine("Понедельник");
if (a == 2) Console.WriteLine("Вторник");
if (a == 3) Console.WriteLine("Среда");
if (a == 4) Console.WriteLine("Четверг");
if (a == 5) Console.WriteLine("Пятница");
if (a == 6) Console.WriteLine("Суббота - выходной день");
if (a == 7) Console.WriteLine("Воскресенье - выходной день");


