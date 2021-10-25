int x,y,max;

Console.Write("x: ");
x=Convert.ToInt32(Console.ReadLine());

Console.Write("y: ");
y=Convert.ToInt32(Console.ReadLine());

if(x>y)  //Ищет наибольшее число из двух.
{
 max=x;
}
else
{
    max=y;
}
Console.WriteLine("Max = "+max.ToString());