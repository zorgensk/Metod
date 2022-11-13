//  Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 0)
{

for(int x = 2; x < num1; x++)

{
    if(x % 2 == 0)
    Console.WriteLine(x);
}

}
else 
{
    for(int x = 0; x > num1; x--)
   { 
    if(x % -2 == 0)
    Console.WriteLine(x);
   }
}