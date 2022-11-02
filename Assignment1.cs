//NAME: AARSH PARIMAL PATEL 
//Assignment-1
//Semester-2

using System.Diagnostics;
namespace A1_CSharp;
public class Assignment1
{

    public static void Main(string[] args)

    {

        //Asking the user for value of pressure:

        Console.WriteLine("Enter the value for pressure P: ");

        float pressure = float.Parse(Console.ReadLine());

        //Asking the user for length:

        Console.WriteLine("Enter the value for Length: ");

        float length = float.Parse(Console.ReadLine());

        //Asking the user for breadth:

        Console.WriteLine("Enter the value for Breadth: ");

        float breadth = float.Parse(Console.ReadLine());

        //Asking the user for height:

        Console.WriteLine("Enter the value for Height: ");

        float height = float.Parse(Console.ReadLine());

        //For calculating the volume:

        float volume = length * breadth * height;

        //Asking the user to input the value for temperature:

        Console.WriteLine("Enter the value for temperature (in Celsius): ");

        float temp = float.Parse(Console.ReadLine());

        //Converting the temperature from Celsius to Kelvin:

        float temperature = temp + 273.14f;

        //Adding float variable for gas:

        float gas = 8.314f;

        //Using the ideal gas equation for finding moles:

        float moles = (pressure * volume) / (gas * temp);


        int i = (int)Math.Floor(moles);

        Console.WriteLine("Original Value = {0}", moles);

        //For rounding off the number:

        Console.WriteLine("Rounded Value = {0}", i);

        //Adding a loop:

        if (i % 2 == 0)

        {

            Console.WriteLine("Even value changes to an odd value by 
            incrementation of 1: " + (i + 1));



}

        else

        {

            Console.WriteLine("Odd value changes to an even value by 
            incrementation of 1: " + (i + 1));



}

    }
}
