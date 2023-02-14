Console.WriteLine("Enter the first value of the side of the triangle: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second value of the side of the triangle: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third value of the side of the triangle: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b+c)
{
    if (b < a+c)
    {
        if (c < a+b)
        {
            Console.WriteLine("This triangle can be exist");
        }
        else Console.WriteLine("This triangle can NOT be exist");
    }
    else Console.WriteLine("This triangle can NOT be exist");
}
else Console.WriteLine("This triangle can NOT be exist");