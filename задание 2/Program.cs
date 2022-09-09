//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum=0;


while(a>9)  //555
{
sum=sum+a%10;
a=a/10;

}
sum=sum+a;

Console.WriteLine(sum);