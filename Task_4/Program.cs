int max = 0;
Console.WriteLine("input first number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input third number: ");
int C = Convert.ToInt32(Console.ReadLine());

if (A > max)
{
  max = A;   
}


if (B > max)
{
  max = B;   
}

if (C > max)
{
  max = C;   
}
Console.WriteLine("max = " + max);