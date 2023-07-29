// Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
/*

void WriteCube(int number)
{
    int current = 1;
    while (current <= number)
    {
        Console.WriteLine($"{current} - {current * current* current}");
        current++;
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
WriteCube (number);
*/
// Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

/*
 double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;
        double deltaZ = z2 - z1;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    }

Console.Write("Input x coordinate of point 1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y coordinate of point 1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z coordinate of point 1: ");       
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input x coordinate of point 2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input y coordinate of point 2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input z coordinate of point 2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine("The distance between the two points in 3D space is: " + distance);
*/

// Задача 19 Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

/*

bool IsPalindrome(int number)
{
  int realNumber = number;
  int reverseNumber = 0;

while (realNumber > 0)
{
    int digit = realNumber % 10;
    reverseNumber = reverseNumber * 10 + digit;
    realNumber = realNumber / 10;

}
return number == reverseNumber;
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (IsPalindrome(number))

Console.WriteLine("Да.");
else

Console.WriteLine("НЕТ!!!!.");  

*/



