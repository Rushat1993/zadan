
Console.Write("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3-е число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1);
}
else if (num2 > num3)
{
    Console.WriteLine(num2);
}
else
{
    Console.WriteLine(num3);
}