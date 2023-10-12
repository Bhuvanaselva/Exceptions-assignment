using Exceptionsassignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionsassignment
{
    internal class WordsDTO
    {
        // step 2
        public string[] StringArray { get; set; }
        public bool BoolValue{ get; set; }
        public string StringValue { get; set; }
    
        //step 1
    public static List<int> GetNumbersInDescending(string input)
    {
        string[] numberStrings = input.Split(',');
        List<int> numbers = new List<int>();

        foreach (string numberString in numberStrings)
        {
            try
            {
                int number = int.Parse(numberString);
                numbers.Add(number);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nEntry discarded: " + numberString);
            }
        }
            numbers.Sort((a, b) => b.CompareTo(a));
            return numbers;
    }

        //step 3
    public static WordsDTO ReadFileContent(string filePath)
    {
        WordsDTO dto = new WordsDTO();

        try
        {
            string fileContents = File.ReadAllText(filePath);
            dto.StringArray = fileContents.Split(',');
            dto.BoolValue = true;
            dto.StringValue = "Success";
        }
        catch (FileNotFoundException)
        {
            dto.BoolValue = false;
            dto.StringValue = "File not found";
        }
        catch (Exception ex)
            {
             Console.WriteLine("An error occurred: " + ex.Message);
            }
            return dto;
    }

}
}
