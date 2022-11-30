Console.WriteLine("Введите первое число: ");
int num_a = 2;

Console.WriteLine("Введите второе число: ");
int num_b = 3;

Console.WriteLine("Введите третье число: ");
int num_c = 7;

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