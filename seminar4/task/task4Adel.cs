// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // Решение 1 через цикл for, без использование метода Pow():
// int PowerUp(int A, int B) {
//     int result = 1;
//     for (int i = 0; i < B; i++) result *= A;
//     return result;
// }
// Console.WriteLine(PowerUp(3, 5));

// // Решение 2 через цикл while:
// int PowerUp2(int A, int B) {
//     int result = 1;
//     while (B > 0) {
//         result *= A;
//         B --;
//     } 
//     return result;
// }
// Console.WriteLine(PowerUp2(2, 3));
// //______________________________________________________________________________________________________________________________
// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // Решение 1
// int NumSum(int num) {
//     int result = 0;
//     while (num > 0) {
//         result += num % 10;
//         num /= 10;
//     }
//     return result;
// }
// Console.WriteLine(NumSum(567));

// // Решение 2
// int SumNum() {
//     Console.WriteLine("Введите число");
//     string num = Console.ReadLine();
//     int result = 0;
//     for (int i = 0; i < num.Length; i++) result += Convert.ToInt32(Convert.ToString(num[i])); 
//     // Пришлось применить метод Convert.ToString , так как при преобразовании ToInt32 брался номер позиции в кодовой таблице ASCII
//     return result;
// }
// Console.WriteLine(SumNum());

// //_________________________________________________________________________________________________________________________________
// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // Решение 1 
// void NewArray() {
//     int[] arr = new int[8];
//     for (int i = 0; i < 8; i++) arr[i] = new Random().Next(1, 1000);
//     for (int i = 0; i < 8; i++) Console.Write($"{arr[i]} ");
// }
// NewArray();

// // Решение 2
// void ArrayNew() {
//     string[] arr = new string[8];
//     for (int i = 0; i < 8; i++) {
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         arr[i] = Console.ReadLine();
//     }
//     int count = 0;
//     while (count < arr.Length) {
//         Console.Write($"Полученный массив: {arr[count]} ");
//         count ++;
//     }
// }
// ArrayNew();
