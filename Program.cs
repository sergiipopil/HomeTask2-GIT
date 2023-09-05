// See https://aka.ms/new-console-template for more information
using HomeTask2_GIT.Classes;


var sum = new Calculator(2, 3).Sum();
var subs = new Calculator(12, 3).Subtraction();
Console.WriteLine($"2+3={sum}");
Console.WriteLine($"12-3={subs}");