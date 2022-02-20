// Задача 2: Даны два числа. Показать большее и меньшее число
int num1 = 7;
int num2 = 9;
Console.Clear();
Console.Write("Даны два числа: ");
Console.Write(num1);
Console.Write(" и ");
Console.WriteLine(num2);    
if (num1==num2)
{
Console.WriteLine("Числа равны");
}
else if (num1>num2)
{
    Console.WriteLine("Большее из чисел - " + num1);
    Console.WriteLine("Меньшее из чисел - " + num2);
}else 
{
    Console.WriteLine("Большее из чисел - " + num2);
    Console.WriteLine("Меньшее из чисел - " + num1);
}