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
        }
    }
    return my_arr;
} 

// Функция для печати массива 
void PrintArr(int[,] my_arr){
    for (int i = 0; i < my_arr.GetLength(0); i++) {
        for (int j = 0; j < my_arr.GetLength(1); j++) { 
            Console.Write(my_arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//Решение:
int[,] SortArrStr(int[,] arr) {
    int[,] result_arr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i=0; i < arr.GetLength(0); i++) {
        for (int j=0; j < arr.GetLength(1); j++) {
            for (int t = 0; t < arr.GetLength(1) - 1; t++) {
                if (arr[i, t+1] > arr[i, t]) {
                    int tmp_var = arr[i, t];
                    arr[i, t] = arr[i, t+1];
                    arr[i, t+1] = tmp_var;
                }
            }
        }
    }
        return arr;
}

int[,] my_arr = RandomIntArr(3, 4, 1, 10);
PrintArr(my_arr);
Console.WriteLine();
PrintArr(SortArrStr(my_arr));
//____________________________________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] arr_2 = RandomIntArr(3, 4, 1, 20);
void MinSum(int[,] arr) {
    int result = 1;
    int sum = 0;
    for (int i=0; i < arr.GetLength(0); i++) {
        int temp_sum = 0;
        for (int j=0; j < arr.GetLength(1); j++) {
            temp_sum += arr[i, j];   
        }
        if (temp_sum < sum) { 
            sum = temp_sum; 
            result = i+1;
        }
        else sum = temp_sum;
    }
    Console.WriteLine($"Наименьшая сумма элементов находится в {result} строке");
}
PrintArr(arr_2);
MinSum(arr_2);

//____________________________________________________________________________________________________________________________________
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] my_arr1 = RandomIntArr(2, 2, 1, 10);
int[,] my_arr2 = RandomIntArr(3, 4, 1, 10);

int [,] ArrProd(int[,] arr1, int [,] arr2) {
    int[,] result_arr = new int [arr1.GetLength(0),arr1.GetLength(1)];  
    if (arr1.GetLength(1) == arr2.GetLength(0)) {
        for (int i=0; i < arr1.GetLength(0); i++) {
            for (int j=0; j < arr1.GetLength(0); j++) {
                for (int t = 0; t < arr2.GetLength(0); t++) {
                    result_arr[i, t] += arr1[i, j] * arr2[j, t];
                }
            }  
        }
    }
    else Console.WriteLine("К сожалению размерности строк первого массива и столбцов второго массива не совпадают");
    return result_arr;
}
PrintArr(my_arr1);
Console.WriteLine();
PrintArr(my_arr2);
Console.WriteLine();
PrintArr(ArrProd(my_arr1, my_arr2));

