// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




// Create an array to store the names of five students.
/*
string[] arrayNames = { "Lohit", "Chandu", "Srikanth", "Radha", "Rishi" };


//Create a list to store the scores of each student corresponding to their position in the array.

int[] arrayList = new int[5];

arrayList[0] = 100;
arrayList[1] = 90;
arrayList[2] = 60;
arrayList[3] = 85;
arrayList[4] = 95;

*/
/*

//Accept a string input from the user.

Console.Write("Enter a string: ");
string userInput = Console.ReadLine();
Console.WriteLine(userInput);
Console.WriteLine("The Length of the string is " + userInput.Length);
Console.WriteLine("The upper case of the string is " + userInput.ToUpper());
Console.WriteLine("The Replaced string is" + userInput.Replace('a', '*'));
int vowelCount = 0;
foreach (char c in userInput.ToLower())
{
    if ("aeiou".Contains(c))
    {
        vowelCount++;
    }
}
Console.WriteLine($"Number of vowels in the string: {vowelCount}");

char[] charArray = userInput.ToCharArray();
Array.Reverse(charArray);
string reversedString = new string(charArray);
Console.WriteLine($"Reversed string: {reversedString}");

//Check if the input string contains the word "CSharp" (case-insensitive) and display the result.
Console.WriteLine(userInput.Contains("CSharp"));

*/


/*string[] array = { "Lohit", "Chandu", "Rishi", "Srikanth", "Akhil" };
Console.WriteLine(array[0]);
*/

int[] array = new int[5];
//List<int> studentScores = new List<int>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter the name of the student : ");
    array[i] = int.Parse (Console.ReadLine());

    Console.WriteLine("Enter the marks of the student");
    int score = int.Parse (Console.ReadLine());

}
