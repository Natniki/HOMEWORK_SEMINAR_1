
Console.WriteLine("input number_A: ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number_B: ");
int number_B = Convert.ToInt32(Console.ReadLine());

if(number_A > number_B)
{
   int i = number_A;
    Console.WriteLine("max = " + i);
}
else
{
    int i  = number_B;
    Console.WriteLine("max = " + i);
}