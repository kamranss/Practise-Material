// See https://aka.ms/new-console-template for more information
using Practicing;
using System;
using System.Text;


#region Make Password unvisable
////Make password unvisable
//Console.Write("You password please: ");
//StringBuilder passwordBuilder = new StringBuilder();
//bool continueReading = true;
//char newLineChar = '\r';


//while (continueReading)
//{
//    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
//    char passwordChar = consoleKeyInfo.KeyChar;

//    if (passwordChar == newLineChar)
//    {
//        continueReading = false;
//    }
//    else
//    {
//        Console.Write("*");
//        passwordBuilder.Append(passwordChar.ToString());
//    }
//}
//Console.WriteLine();
//Console.Write("Your password in plain text is {0}", passwordBuilder.ToString());
#endregion

Calculator Calculation1 = new Calculator();

Console.WriteLine(" Write First number ->>");
Calculation1.Num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Write Second number ->>");
Calculation1.Num2 = double.Parse(Console.ReadLine());
Console.WriteLine(" choose one of the following methods");
Console.WriteLine(" for  +  ->>press->> 1");
Console.WriteLine(" for  *  ->>press->> 2");
Console.WriteLine(" for  -  ->>press->> 3");
Console.WriteLine(" for  /  ->>press->> 3");

Calculation1.Variation = Console.ReadLine();
Console.WriteLine($"Result =" + Calculation1.CalculatorMethod(Calculation1.Num1, Calculation1.Num2, Calculation1.Variation));
        


