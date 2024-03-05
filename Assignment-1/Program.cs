// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Assignment

// 3.//Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
//     if less than 60 cm small , greater than 60 and less than 160 medium , greater than 160 is tall.
/*
Console.WriteLine("Please enter your height in CM");
var hieght = Console.ReadLine();
if (Convert.ToInt32(hieght) <= 60)
{
    Console.WriteLine("Small");
}
else if(Convert.ToInt32(hieght) > 60 && Convert.ToInt32(hieght) < 160)
{
    Console.WriteLine("Medium");
}
else
{
    Console.WriteLine("Tall");
}

/*
//Write a C# Sharp program to find the largest of three numbers.

Console.WriteLine("Please enter the value of a");
var a = Console.ReadLine();
Console.WriteLine("Please enter the value of b");
var b = Console.ReadLine();
Console.WriteLine("Please enter the value of c");
var c = Console.ReadLine();
if(Convert.ToInt32(a) > Convert.ToInt32(b) && Convert.ToInt32(a) > Convert.ToInt32(c))
{
    Console.WriteLine("A is greater");
}
else if ((Convert.ToInt32(a) < Convert.ToInt32(b) && Convert.ToInt32(b) > Convert.ToInt32(c)))
{
    Console.WriteLine("B is greater");
}
else
{
    Console.WriteLine("C is greater");
}

*/

// 5.Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and garde. 
//      if percentage is less than 35 F , if between 35 to 60 C , between 60 to 80 B, more than 80 is A

Console.WriteLine("Please enter your roll num");
var RollNum = Console.ReadLine();
Console.WriteLine("Please enter your name");
var Name = Console.ReadLine();
Console.WriteLine("Please enter your marks 1st subject marks");
var M1 = Console.ReadLine();
Console.WriteLine("Please enter your marks 2nd subject marks");
var M2 = Console.ReadLine();
Console.WriteLine("Please enter your marks 3rd subject marks");
var M3 = Console.ReadLine();
int Total = Convert.ToInt32(M1) + Convert.ToInt32(M2) + Convert.ToInt32(M3);
Console.WriteLine("Your total marks is" + Total);
double percentage = (double)Total / 300 * 100;
Console.WriteLine("Your Percentage is" + percentage);
if (percentage < 35)
{
    Console.WriteLine("Your Grade is F");
}
else if (percentage > 35 && percentage < 60)
{
    Console.WriteLine("Your Grade is C");
}
else if (percentage > 60 && percentage < 80)
{
    Console.WriteLine("Your Grade is B");
}
else
{
    Console.WriteLine("Your Grade is A");
}



