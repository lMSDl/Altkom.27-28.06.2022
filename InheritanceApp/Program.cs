using InheritanceApp.Models;


Shape shape = new Line(2);

var output = Figgle.FiggleFonts.SubZero.Render(shape.ToString());
Console.WriteLine(output);

shape.AbstractMethod();

shape.VirtualMethod();

