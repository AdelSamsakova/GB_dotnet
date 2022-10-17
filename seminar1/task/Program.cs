// Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2) {
    Console.WriteLine($"Первое число {num_1} больше");
}
else {
     Console.WriteLine($"Второе число {num_2} больше");
}

// Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
int max_num = 0; 
if (num_1 > num_2) {
    max_num = num_1;
}
else {
    max_num = num_2;
}
if (max_num > num_3) {
    Console.WriteLine($"Максимально число: {max_num}");
}
else {
    Console.WriteLine($"Максимально число: {num_3}");
}

// Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите своё число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) {
    Console.WriteLine($"{num} - является четным числом");
}
else {
    Console.WriteLine($"{num} - является нечетным числом");
}


// Задача №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
// // Решение 1
Console.WriteLine("Введите своё число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = 2;
while (res < num) {
    Console.Write($"{res} ");
    res = res + 2;
}
// Решение 2
Console.WriteLine("Введите своё число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < num) {
    if (i % 2 == 0) {
      Console.Write($"{i} ");  
    }
i ++;
}

