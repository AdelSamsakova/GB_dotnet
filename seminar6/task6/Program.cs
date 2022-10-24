// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// Решение 1.
Console.WriteLine("Какое количество чисел вы желаете ввести?");
int count = Convert.ToInt32(Console.ReadLine());
int result = count;
for (int i = 0; i < count; i++) {
    Console.Write($"Введите {i+1} число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0) result--;
}
if (result > 0) Console.WriteLine($"Количество чисел больше нуля: {result}");
else Console.WriteLine($"Чисел больше нуля нет");

// // Решение 2. 
Console.WriteLine("Введите свои числа через запятую");
string[] numbers = Console.ReadLine().Split(',');
int result = 0;
for (int i = 0; i < numbers.Length; i++) {
    if (Convert.ToInt32(numbers[i]) > 0) result++;
}
if (result > 0) Console.WriteLine($"Количество чисел больше нуля: {result}");
else Console.WriteLine($"Чисел больше нуля нет");


//____________________________________________________________________________________________________________________________________________
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
string[] koeff = {"b1", "k1", "b2", "k2"};
double[] koeff_val = new double[4];
double[] result = new double[2];
for (int i = 0; i < koeff.Length; i++) {
    Console.Write($"Введите значение {koeff[i]}: ");
    koeff_val[i] = Convert.ToInt32(Console.ReadLine());
}
result[0] = (koeff_val[2] - koeff_val[0])/(koeff_val[1]-koeff_val[3]);
result[1] = (koeff_val[1]*(koeff_val[2] - koeff_val[0])/(koeff_val[1]-koeff_val[3]) + koeff_val[0]);
Console.WriteLine($"Результат ({result[0]}; {result[1]})");


