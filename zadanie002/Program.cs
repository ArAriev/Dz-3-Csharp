// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine());
int B = 0;
int rez = 0;

while (A > 0)
    {
        B = A % 10;
        rez = rez + B;
        A = A / 10;
    }
Console.WriteLine($"Сумма введенного числа равна {rez}");
