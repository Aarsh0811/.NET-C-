//NAME: AARSH PARIMAL PATEL
//Activity-1
//Semester-2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//adding our namespace
namespace Midterm1
{
 
public class Question1
 
{
 
//declaring the variable
 
public static int abs_val(int num)
 
{
 
//adding if statements
 
if (num < 0)
 
{
 
num = num * -1;
 
}
 
else
 
{
 
num = num;
 
}
 
return num;
 
}
 
public static void Main(string[] args)
 
{
 
//the below code is for inputting the integers
 
Console.Write("Input any integer value here:");
 
String a = Console.ReadLine();
 
int b = Convert.ToInt16(a);
 
int y = abs_val(b);
 
Console.Write(y);
 
 
}
 
}
}
//end of the code
