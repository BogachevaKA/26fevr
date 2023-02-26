//Задача:
// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int y = num * num;
// Console.WriteLine(y);

// if (num > 9)
// {
//     Console.WriteLine("Число больше 9");
// }
// else
// {
//     Console.WriteLine("Число меньше 9");
// }

//Задача:
// Console.WriteLine("Введите целое число a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число b");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a == b * b)
// {
//     Console.WriteLine(b + " - Я вляется числом a ");
// }
// else
// {
//     Console.WriteLine(b + "- Не является числом a ");
// }


//Задача:
// //напишите программу, которая будет выводить день недели по заданному числу:
// //4="четверг"
// Console.WriteLine("Введите день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//     case 1:
//         Console.WriteLine("понедельник");
//         break;
//     case 2:
//         Console.WriteLine("вторник");
//         break;
//     case 3:
//         Console.WriteLine("среда");
//         break;
//     case 4:
//         Console.WriteLine("четверг");
//         break;
//     case 5:
//         Console.WriteLine("пятница");
//         break;
//     case 6:
//         Console.WriteLine("суббота");
//         break;
//     case 7:
//         Console.WriteLine("воскресенье");
//         break;
//     default:
//         Console.WriteLine("неправильно введено число");
//         break;
// }

//Задача:
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
//последнюю цифру этого числа.
//пример: 456 -> 6

// Console.Write("Введите число: ");

// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int lastNumber = number % 10;
//     System.Console.WriteLine("Последнее число: " + lastNumber);
// }
// else
// {
//     System.Console.WriteLine("Неправильный номер: ");
// }

//Задача:
// Console.WriteLine("номер");
// int numberA = Convert.ToInt32(Console.ReadLine());
// for (int i = -numberA; i <= numberA; i++)
// {
//   Console.Write(i + " ");
// }

//Задача:
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
//Например: 78 -> 8, 12-> 2
// int num = new Random().Next(10, 100);
// Console.WriteLine("Было сгенерировано " + num);
// Console.WriteLine($"Было сгенерировано число {num}");
// int x1 = num / 10;
// int x2 = num % 10;
// if (x1 > x2)
//     Console.WriteLine(x1);
// else if (x1 < x2)
//     Console.WriteLine(x2);
// else
//     Console.WriteLine("обе цифры этого числа равны");
// for (int i=0;i<=10;i++)
//     Console.Write($"{i} ");

//Задача:
//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// int num = new Random().Next(100, 1000);
// Console.WriteLine("Было сгенерировано " + num);
// int lastNumber1 = num / 100;
// int lastNumber2 = num % 10;
// System.Console.WriteLine("число: " + lastNumber1 + lastNumber2);

//Задача:
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно
// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = num1 % num2;
// if (num3 == 0)
//     Console.WriteLine("Кратно");
// else
//     Console.WriteLine("Не кратно. Остаток: " + num3);

//Задача:
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да
// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = num % 7;
// int num3 = num % 23;
// if (num2 == 0 && num3 == 0)
//     Console.WriteLine("Кратно");
// else
//     Console.WriteLine("Не кратно");


//Задача. Решение 1
//Найти в числе вторую цифру в числе и исключить её. Число может быть разной разрядности.
// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = Convert.ToInt32(Math.Log10(num)); //Math считает длину строки
// Console.WriteLine($"Разрядность числа - {i+1}"); //считает 10 в степени в той, которая равна длине строки
// int stepen = i;
// int num1 = Convert.ToInt32(Math.Pow(10, stepen));
// int num2 = num / num1;
// int num3 = Convert.ToInt32(Math.Pow(10, stepen - 1));
// int num4 = num % num3;
// Console.WriteLine($"Полученное число - {num2}{num4}");

//Задача. Решение 2
// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2=num;
// int count=0;
// while (num > 0)
// {
//     count++;
//     num = num / 10;
// }

// Console.WriteLine($"Разрядность введенного числа {count}");
// string res="";
// for (int i=1;i<=count;i++)
//     {
//         if (i!=count-1) //Игнорирует вторую цифру
//             res = num2%10 + res ;
//         num2=num2/10;
//     }

// Console.WriteLine(res);

Задачи к Уроку 1
