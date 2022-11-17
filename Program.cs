Console.WriteLine("Write a number");
int num1 = Convert.ToInt32 (Console.ReadLine());

if (num1 / 100 >=1)
{
     while (num1/100>=10)
     {
        num1=num1/10;
     }
    if (num1 / 100 >=1 && num1 / 100 < 10)
    {
        num1 = num1%10;
        Console.WriteLine(num1);
    }
}
else 
{
    Console.WriteLine("Wrong");
}
