// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Enter Number: ");
int N = int.Parse(Console.ReadLine());
int a = 1;

while (a <= N)
    {
        int b = a * a * a;
        int c = b % 10;

        if(c % 2 == 0)
            {
                Console.WriteLine($"Как сказал мой САНСЕЙ, что если вспомнить математику: то как то так получается {b}");
            }

            a++;
    }

