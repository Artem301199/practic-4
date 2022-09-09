// Напишите программу которая принимает два числа, и затем выдает степень числа 5 6


Console.WriteLine( "Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

//int Count=1;
//int Stepen=1;
//while( Count<= b)
//{
  //  Stepen=Stepen*a;
   // Count++;
//}
//Console.WriteLine(Stepen); 
Console.WriteLine(Math.Pow(a,b));