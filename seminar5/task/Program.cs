// Функция для создания массива с рандомными элементами
int[] RandomArr(int len, int min_num, int max_num) {
    // len - размер массива
    // min_num - начало диапазна
    // max_num - конец диапазона
    int[] my_arr = new int[len];
    for (int i = 0; i < my_arr.Length; i++) my_arr[i] = new Random().Next(min_num, max_num);
    return my_arr;
} 

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] my_arr = RandomArr(15, 100, 1000);
int count = 0;
for (int i = 0; i < my_arr.Length; i++) {
    Console.Write($"{my_arr[i]}, ");
    if (my_arr[i] % 2 == 0) count++;
}
Console.WriteLine($"\nКоличество четных чисел: {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] my_arr = RandomArr(15, -100, 100);
int sum_even = 0;
for (int i = 0; i < my_arr.Length; i++) {
    Console.Write($"{my_arr[i]}, ");
    if (i % 2 != 0) sum_even += my_arr[i];
}
Console.WriteLine($"\nСумма чисел, стоящих на нечетных позициях: {sum_even}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Решение 1.
int[] my_arr = RandomArr(15, -100, 100);
int max_num = my_arr[0];
int min_num = my_arr[0];
for (int i = 0; i < my_arr.Length; i++) {
    Console.Write($"{my_arr[i]}, ");
    if (max_num < my_arr[i]) max_num = my_arr[i];
    if (min_num > my_arr[i]) min_num = my_arr[i];
}
Console.WriteLine($"\nРазница между максимальным и минимальным элементом равна: {max_num - min_num}");

