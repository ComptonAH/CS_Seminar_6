Console.WriteLine("Enter a number in decimal numeral system : ");
int Decimal = Convert.ToInt32(Console.ReadLine());
string s = "";
while (Decimal > 0)
{
    s = Decimal%2 + s;
    Decimal /= 2;
}
Console.Write(s);