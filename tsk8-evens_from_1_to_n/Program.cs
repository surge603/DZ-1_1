// Задача 8: Показать чётные числа от 1 до N.
int N =13;
int count =2;
Console.Clear();
Console.WriteLine("Четные числа от 1 до "+N+":");
if (N<count) Console.WriteLine("Отсутствуют");

while (count <= N){
Console.WriteLine(count);
count +=2;
}