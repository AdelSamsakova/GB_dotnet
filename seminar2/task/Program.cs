// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // Решение 1
// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string res = Convert.ToString(num);
// Console.WriteLine($"Вторая цифра числа {num} равна {res[1]}");

// // // Решение 2
// Console.WriteLine("Введите трехзначное число: ");
// int num_2 = Convert.ToInt32(Console.ReadLine());
// int res_2 = (num_2 / 10) % 10;
// Console.WriteLine(res_2);


// Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного числа или сообщает, что третьей цифры нет.
// // Решение 1
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string res = Convert.ToString(num);
// try {
//     Console.WriteLine($"Третья цифра числа {num} равна {res[2]}");
// }
// catch (Exception) {
//     Console.WriteLine("Третьей цифры у заданного числа нет");
// }

// // Решение 2
// Console.WriteLine("Введите число: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int poryadok = 10;
// if (num_1 < 100) {
//     Console.WriteLine("Третьей цифры у заданного числа нет");
// }
// else {
//     while (num_1/100 >= 10) {
//     num_1 = num_1/poryadok;
//     }
//     Console.WriteLine($"Третья цифра числа равна {num_1 % 10}");
// }


// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Введите цифру дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day == 6 | day == 7) {
//     Console.WriteLine("День является выходным днем");
// } 
// else if (day > 7 | day <= 0) {
//     Console.WriteLine("Такого дня нет");
// }
// else {
//     Console.WriteLine("Этот день рабочий");
// }



