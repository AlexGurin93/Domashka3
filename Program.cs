// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();
if 

(number[0]==number[4] || number[1]==number[3])

    Console.WriteLine($"Ваше число: {number} - палиндром.");

else 

Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
*/
//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N./
/*Random random = new Random();
int n= random.Next(2,12);
double number = 1;
double result;
Console.WriteLine($"Число {n}");
while (number <= n)
{
result = Math.Pow(number, 3);
Console.WriteLine($"{number}X{number}X{number}={result}");
number++;
}*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
Random random = new Random();
int x1 = random.Next(0,100);
int y1 = random.Next(0,100);
int z1 = random.Next(0,100);
int x2 = random.Next(0,100);
int y2 = random.Next(0,100);
int z2 = random.Next(0,100);
double dist= 0;
Console.WriteLine($"Координаты точки 1 : ({x1},{y1},{z1} и точки 2 : ({x2},{y2},{z2})");
dist = Math.Sqrt(Math.Pow(x2-x1, 2) +Math.Pow(y2-y1, 2) +Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние ({Math.Round(dist, 2)})");