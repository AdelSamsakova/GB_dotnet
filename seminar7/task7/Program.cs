// Функция для создания массива с рандомными элементами
int[,] RandomIntArr(int len_str, int len_col, int min_num, int max_num) {
    // len_str - количество строк массива
    // len_col - количество столбцов массива
    // min_num - начало диапазна
    // max_num - конец диапазона
    int[,] my_arr = new int[len_str, len_col];
    for (int i = 0; i < len_str; i++) {
        for (int j = 0; j < len_col; j++) {
            my_arr[i, j] = new Random().Next(min_num, max_num);
            Console.Write(my_arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    return my_arr;
} 
// //__________________________________________________________________________________________________________
// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // Решение
double[,] RandomDoubleArr(int n, int m) {
    double[,] result = new double[n, m];
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            result[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(-100, 100)), 2);
            Console.Write(result[i, j] + " ");
        }
         Console.WriteLine();
    }
    return result;
}
// RandomDoubleArr(3, 5);
// //__________________________________________________________________________________________________________

// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// // и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Решение 1
double[,] my_arr = RandomDoubleArr(3, 5);
// string Element(double[,] arr, int i, int j) {
//     try { return Convert.ToString(arr[i, j]); }
//     catch { return "Такой позиции в заданном массиве нет"; }
// }
// Console.WriteLine("\nРезультат: " + Element(my_arr, 5, 2));

// Решение 2
string MyElement(double[,] arr, int i, int j) {
    if (i >= arr.GetLength(0) | (j >= arr.GetLength(1))) return "Такой позиции в заданном массиве нет";
    else return $"Элемент на позиции ({i}, {j}) равен {arr[i, j]}";
}
Console.WriteLine(MyElement(my_arr, 2, 3));

// // Решение в случае, если пользователь задает число, а мы выводим результат, есть ли такое число или нет
// int[,] my_int_arr = RandomIntArr(5, 5, -100, 100);
// string result = "Числа в массиве нет";
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < my_int_arr.GetLength(0); i++) {
//     for (int j = 0; j < my_int_arr.GetLength(1); j++) {
//         if (my_int_arr[i, j] == num) result = $"Число {num} есть в массиве на позиции ({i},{j})";
//     }
// }
// Console.WriteLine(result);
//_______________________________________________________________________________________________________________
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// int[,] intarr = RandomIntArr(5, 6, 1, 10);
// double[] res_arr = new double[intarr.GetLength(1)];
// for (int i = 0; i < intarr.GetLength(0); i++) {
//     for (int j = 0; j < intarr.GetLength(1); j++) {
//         res_arr[j] += intarr[i, j];
//     };
// }
// for (int i = 0; i < res_arr.Length; i++) {
//     res_arr[i] = res_arr[i]/intarr.GetLength(0);
//     Console.Write($"Среднее арифметическое {i+1} столбца равно: {res_arr[i]}\n");
// }