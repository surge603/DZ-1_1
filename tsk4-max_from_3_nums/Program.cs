// Задача 4: Найти максимальное из трёх чисел.

int num1 = 13;
int num2 = 25;
int num3 = 7;

Console.Clear();

Console.Write("Даны три числа: ");
Console.Write(num1);
Console.Write(", ");
Console.Write(num2);  
Console.Write(" и ");
Console.WriteLine(num3);  
Console.Write("Максимальным из этих чисел является ");

if (num1>=num2 && num1 >= num3) Console.WriteLine(num1);  
else if (num2>=num1 && num2 >= num3) Console.WriteLine(num2);  
else Console.WriteLine(num3);  
