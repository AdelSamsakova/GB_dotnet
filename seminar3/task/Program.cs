// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки A в 3D пространстве через запятую");
string A = Console.ReadLine();
A = A.Replace(",", "").Replace(" ", "");
Console.WriteLine("Введите координаты точки B в 3D пространстве через запятую");
string B = Console.ReadLine();
B = B.Replace(",", "").Replace(" ", "");
double result = 0;
Console.WriteLine($"{A}, {B}");
for (int i = 0; i < A.Length; i++) {
    double res = Math.Round(Math.Pow((B[i] - A[i]), 2), 2);
    result += res;
}
Console.WriteLine($"Расстояние между точками равно: {Math.Round(Math.Sqrt(result), 2)}");


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine("Введите свое число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; i++ ) Console.Write($"{i*i*i} ");

