// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
char[] new_num = num.ToCharArray();
int j = num.Length - 1;
for (int i = 0; i <= j; i++) {
    new_num[j] = num[i];
    new_num[i] = num[j];
    j = j - 1;
}
Console.WriteLine(new_num);
if (String.Join("", new_num) == num) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");



// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки A в 3D пространстве через запятую");
string[] A = Console.ReadLine().Split(',');
Console.WriteLine("Введите координаты точки B в 3D пространстве через запятую");
string[] B = Console.ReadLine().Split(',');
double result = 0;
for (int i = 0; i < A.Length; i++) {
result += Math.Pow((Convert.ToInt32(B[i]) - Convert.ToInt32(A[i])), 2);
}
Console.WriteLine($"Расстояние между точками равно: {Math.Round(Math.Sqrt(result), 2)}");


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите свое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++ ) Console.Write($"{i*i*i} ");

