Console.WriteLine("input number =>");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number =>");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number =>");
int C = Convert.ToInt32(Console.ReadLine());


if (A > B && A > C)
{
Console.WriteLine("A самое большое число");
}

else if (B > A && B > C)
{
Console.WriteLine("В самое большое число" );
}
else
{
Console.WriteLine("С самое большое число");
}