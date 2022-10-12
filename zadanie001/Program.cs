// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int A = 1;

while (A <= N)
    {
        int B = A * A * A;
        Console.WriteLine($"Кубом числа {A} будет {B}");
        A++;
    }
    