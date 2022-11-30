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
