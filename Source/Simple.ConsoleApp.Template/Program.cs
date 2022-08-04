// See https://aka.ms/new-console-template for more information
using Simple.ConsoleApp.Template;

Console.WriteLine("Hello, World!");

var calcualtor = new Calculator();
Console.WriteLine($"Addition of 2 and 3 is {calcualtor.Add(2, 3)}");
Console.WriteLine($"Substraction of 2 and 3 is {calcualtor.Substract(2, 3)}");
Console.WriteLine($"Multiplications of 2 and 3 is {calcualtor.Multiply(2, 3)}");
Console.WriteLine($"Division of 2 and 3 is {calcualtor.Divide(10, 2)}");
