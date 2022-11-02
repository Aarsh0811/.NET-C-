//NAME: AARSH PARIMAL PATEL
//Activity-2
//Semester-2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///adding our namespace
namespace Midterm2
{
 
public class Question2
 
{
 
public static void rangeSum()
 
{
 
//the below code is for taking input from user and executing it 
according to the requirements
 
Console.Write("Enter the first Integer here:");
 
String intgrfirst = Console.ReadLine();
 
int intgrfirstInt = Convert.ToInt16(intgrfirst);
 
Console.Write("Enter the second Integer here:");
 
String intgrsecond = Console.ReadLine();
 
int intgrsecondInt = Convert.ToInt16(intgrsecond);
 
int sum = 0;
 
for (int i = intgrfirstInt; i <= intgrsecondInt; i++)
 
{
 
sum += i;
 
}
 
Console.Write("The first integer is: " + intgrfirstInt + " The second 
integer is: " + intgrsecondInt + " The sum of consecutive integers is: " + sum);
 
}
 
public static void Main(string[] args)
 
{
 
//the below code is for executing our code that we wrote above
 
rangeSum();
 
}
 
}
}
//end of the code
