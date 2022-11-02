//NAME: AARSH PARIMAL PATEL
//ASSIGNMENT-2
//Semester-2

using System;
//adding our name space
namespace Eligibility_check;
public class A2
{
 
public static void Main(string[] args)
 
{
 
//creating string arrays for our inputs
 
string[] arr1 = { "CS", "3", "2022", "Java" };
 
Console.Write("Enter your diploma initial here: ");
 
string diploma = Console.ReadLine();
 
Console.Write("Enter your experience (in years) here: ");
 
string expnce = Console.ReadLine();
 
Console.Write("Enter your year of graduation here: ");
 
string grdyrs = Console.ReadLine();
 
Console.Write("Enter an important skill you have here: ");
 
string impskill = Console.ReadLine();
 
string[] arr2 = { diploma, expnce, grdyrs, impskill };
 
// below code is for outputs
 
var output = true;
 
//adding a for loop
 
for (int i = 0; i < arr1.Length; i++)
 
{
 
if (arr1[i] != (arr2[i]))
 
{
 
output = false;
 
break;
 
}
 
else
 
{
 
output = true;
 
}
 
}
 
//if true the user will get outputs according to the criteria
 
if (output.Equals(true))
 
{
 
Console.WriteLine("Congrats! You are eligible, your interview is in 1 
week!
!
!");
 
}
 
else
 
{
 
Console.WriteLine("Sorry,we decided to move on with other candidates");
 
}
 
}
}
//end of the code
