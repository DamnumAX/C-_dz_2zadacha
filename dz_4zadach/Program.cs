// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int num_a = int.Parse(Console.ReadLine());;

Console.WriteLine("Введите второе число: ");
int num_b = int.Parse(Console.ReadLine());;

Console.WriteLine("Введите третье число: ");
int num_c = int.Parse(Console.ReadLine());;

int max = num_a;

if (num_b > max)
{
max = num_b;
}

if (num_c > max)
{
max = num_c;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);
