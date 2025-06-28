#region 1
//Write a program that allows the user to enter a number then print it.

//using System;

//namespace consoleapp1
//{
//    internal class program
//    {
//        static void main(string[] args)
//        {
//            Console.Write("Enter a number: ");
//            int num = int.Parse(Console.ReadLine());
//            Console.WriteLine("You entered: " + num);
//        }
//    }
//}
#endregion

#region 2

/*Write C# program that converts a string to an integer
    , but the string contains non-numeric characters. And mention what will happen.*/

//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = "123aaa";
//            int result;
//            bool success = int.TryParse(input, out result);
//            Console.WriteLine("Conversion Success: " + success);
//            Console.WriteLine("Result: " + result);

//        }
//    }
//}
#endregion

#region 3
//Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
//using System;
//using System.ComponentModel;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            float a = 2.5f;
//            float b = 1.5f;
//            float sum = a + b;
//            Console.WriteLine("Sum = " + sum);
//        }
//    }
//}

#endregion

#region 4
//Write C# program that Extract a substring from a given string.
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string text = "Hello World";
//            string sub = text.Substring(6, 5);
//            Console.WriteLine("Substring: " + sub);
//        }
//    }
//}

#endregion

#region 5
/*Write C# program that Assigning one value type variable to another
    and modifying the value of one variable and mention what will happen*/

//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 5;
//            int y = x;
//            y = 10;
//            Console.WriteLine("x = " + x); // 5
//            Console.WriteLine("y = " + y); // 10
//        }
//    }
//}
#endregion

#region 6
/*Write C# program that Assigning one reference type variable to another
and modifying the object through one variable and mention what will happen*/
//using System;

//class MyClass { public int Value; }

//MyClass obj1 = new MyClass();
//obj1.Value = 5;
//MyClass obj2 = obj1;
//obj2.Value = 10;

//Console.WriteLine("obj1.Value = " + obj1.Value); // 10
//Console.WriteLine("obj2.Value = " + obj2.Value); // 10
#endregion

#region 7
//Write C# program that take two string variables and print them as one variable 
//using System;
//using System.ComponentModel;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string first = "Hello";
//            string second = "World";
//            string combined = first + " " + second;
//            Console.WriteLine(combined);
//        }
//    }
//}
#endregion

#region 8
/*Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
Note : The formula for simple interest is Interest = (principal * rate * time ) /100.*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double principal = 1000, rate = 5, time = 2;
//            double interest = (principal * rate * time) / 100;
//            Console.WriteLine("Simple Interest: " + interest);
//        }
//    }
//}
#endregion

#region 9
/*Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. 
Note :The formula for BMI is BMI = (Weight)/(Height*Height)*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            double weight = 70; // kg
//            double height = 2.5; // meters
//            double bmi = weight / (height * height);
//            Console.WriteLine("BMI: " + bmi);
//        }
//    }
//}
#endregion

#region 10
/*Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
Note : 
that below 10 degrees is "Just Cold"
above 30 degrees is "Just Hot"
anything else is "Just Good"*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int temp = 25;
//            string result = (temp < 10) ? "Just Cold" :
//                            (temp > 30) ? "Just Hot" : "Just Good";
//            Console.WriteLine("Temperature: " + result);
//        }
//    }
//}
#endregion

#region 11
/*Write a program that takes the date from the user and displays it in various formats using string interpolation.
Ex :
Today’s date : 20 , 11 , 2001
Today's date : 20 / 11 / 2001
Today's date : 20 – 11 – 2001*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter day: ");
//            int day = int.Parse(Console.ReadLine());
//            Console.Write("Enter month: ");
//            int month = int.Parse(Console.ReadLine());
//            Console.Write("Enter year: ");
//            int year = int.Parse(Console.ReadLine());

//            Console.WriteLine($"Today's date : {day} , {month} , {year}");
//            Console.WriteLine($"Today's date : {day} / {month} / {year}");
//            Console.WriteLine($"Today's date : {day} – {month} – {year}");
//        }
//    }
//}
#endregion

#region 12
/*Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
    Example (1)
    Input: 12
    Output: Yes
    Example(2)
    Input: 9
    Output: No */
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int num = int.Parse(Console.ReadLine());
//            if (num % 3 == 0 && num % 4 == 0)
//                Console.WriteLine("Yes");
//            else
//                Console.WriteLine("No");
//        }
//    }
//}
#endregion

#region 13
/*Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
    Example (1)
    Input: -5
    Output: negative
    Example(2)
    Input: 10
    Output: positive */
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            Console.WriteLine(n < 0 ? "negative" : "positive");
//        }
//    }
//}
#endregion

#region 14
/*Write a program that takes 3 integers from the user then prints the max element and the min element.
    Example (1)
    Input:7,8,5
    Output:
    max element = 8
    min element = 5
—--------------------------------
    Example (2)
    Input: 3 6 9
    Outputs:
    Max element = 9
    Min element = 3*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            int c = int.Parse(Console.ReadLine());

//            int max = Math.Max(a, Math.Max(b, c));
//            int min = Math.Min(a, Math.Min(b, c));

//            Console.WriteLine("Max element = " + max);
//            Console.WriteLine("Min element = " + min);
//        }
//    }
//}
#endregion

#region 15
//Write a program that allows the user to insert an integer number then check If a number is even or odd.
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());
//            Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");
//        }
//    }
//}
#endregion

#region 16
/*Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
    Example (1)
    Input: O
    Output: vowel
    Example (2)
    Input: b
    Output: Consonant*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            char ch = char.ToLower(Console.ReadLine()[0]);
//            if ("aeiou".Contains(ch))
//                Console.WriteLine("vowel");
//            else
//                Console.WriteLine("consonant");
//        }
//    }
//}
#endregion

#region 17
/*Write a program to input the month number and print the number of days in that month.
    Example
    Input: Month Number: 1
    Output: Days in Month: 31*/
//using System;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter month number (1-12): ");
//            int month = int.Parse(Console.ReadLine());

//            int days = DateTime.DaysInMonth(2023, month);
//            Console.WriteLine("Days in Month: " + days);
//        }
//    }
//}
#endregion