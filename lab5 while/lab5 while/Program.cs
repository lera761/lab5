int a, b, c, d, s;
s = 0;

Console.WriteLine("введите первый промежуток");
Console.WriteLine("введите от");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите до");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второй промежуток");
Console.WriteLine("введите От");
c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите До");
d = Convert.ToInt32(Console.ReadLine());

if (a <= b && b <= c && c <= d)
{
    int i = c; 

    while (i <= d) 
    {
        if (i % 2 == 0)
        {
            s += i;
        }
        i++;
    }

    Console.WriteLine("Сумма четных чисел: " + s);
}
else
{
    Console.WriteLine("Не соответствует условию a ≤ b ≤ c ≤ d");
}