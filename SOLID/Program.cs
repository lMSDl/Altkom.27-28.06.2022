

using SOLID.L;


Console.WriteLine("Podaj A:");
var aString = Console.ReadLine();

Console.WriteLine("Podaj B:");
var bString = Console.ReadLine();

var a = int.Parse(aString);
var b = int.Parse(bString);
var rectangle = CreateRectangle(a, b);

Console.WriteLine($"{a}*{b} = {rectangle.GetArea()}");






Rectangle CreateRectangle(int a, int b)
{
    var rectangle = new Square();
    rectangle.A = a;
    rectangle.B = b;
    return rectangle;
}