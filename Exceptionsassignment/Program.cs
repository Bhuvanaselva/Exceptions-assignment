// See https://aka.ms/new-console-template for more information

using System;
using Exceptionsassignment;
using System.IO;

//step 1

string input = "10,20,30,40,abc,50,60,xyz";
Console.WriteLine($"\nString: {input}");

List<int> result = WordsDTO.GetNumbersInDescending(input);

Console.WriteLine("\nNumbers in descending order:");
   
foreach (int number in result)
{
Console.WriteLine(number);
}


//Step 3   

string filePath = "C:\\Users\\bhuva\\source\\repos\\Exceptionsassignment\\Exceptionsassignment\\sample.txt";
WordsDTO wordsDTO = WordsDTO.ReadFileContent(filePath);
Console.WriteLine("\nWordsDTO!");
Console.WriteLine("\nString Array:\n\n" + string.Join(", ", wordsDTO.StringArray));
Console.WriteLine("\nBool: " + wordsDTO.BoolValue);
Console.WriteLine("\nString: " + wordsDTO.StringValue);

if (wordsDTO.BoolValue!= null)
{
Console.WriteLine("\nWords read from the file:\n");

   foreach (string word in wordsDTO.StringArray)
    {
    Console.WriteLine(word);
    }
}
else
{
Console.WriteLine("Error: " + wordsDTO.StringValue);
}



