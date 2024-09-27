using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
           
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
            Console.WriteLine("");
        }
    }

    public void SaveToCsv(string fileName)//creating new filename
    {
        using (StreamWriter writer  = new StreamWriter(fileName))
        {
            //writing the csv header
            writer.WriteLine("Date,Prompttext,Entrytext");

            //looping through the _entries list
            foreach (Entry entry in _entries)
            {
                //escape commas, quotes, and new lines in the entry text and prompt
                string prompt = EscapeCsv(entry._promptText);
                string entryText = EscapeCsv(entry._entryText);
                string date = entry._date;

                //write the entry data in the csv format
                writer.WriteLine($"{date},{prompt},{entryText}");

            }
        }
    }

    public void Save(string fileName)//adding to an existing file
    {
        //opening the file in an append mode 
        using (StreamWriter sw = new StreamWriter(fileName, true))
        {
            //no need writing the csv header cos its already define in the existing file
            foreach (Entry entry in _entries)
            {
                //escape commas, quotes, and new lines in the entry text and prompt
                string prompt = EscapeCsv(entry._promptText);
                string entryText = EscapeCsv(entry._entryText);
                string date = entry._date;

                //write the entry data in the csv format
                sw.WriteLine($"{date},{prompt},{entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
       _entries.Clear(); //clearing existing entries(what if i dont clear it)
       using(StreamReader reader = new StreamReader(fileName))
       {
            //skip the header line
            reader.ReadLine();

            string line = ""; //holds each line of the csv file
            while ((line = reader.ReadLine()) != null)// a loop that continuesto run as long as the reader.Readline() has not finish reading all the lines
            {
                //this codes below stores the lines iterated in the loop into an an array of strings named values passing in the ParseCsvLine
                string[] values = ParseCsvLine(line); //splits CSV line into individual fields based on commas and quotes

                string normalTextLine = string.Join(", ", values);
                //this code joins the values array into a single string separated by comma
                
                // Print the values
                Console.WriteLine(normalTextLine);
                // You can now process these values (e.g., store them in a data structure)
                // for further use.
            }
        }
    }

    private string EscapeCsv(string text)//iniatially storing every field in double quote as csv rule
    {   //checking if the text fields contains (comma, quotes, and a newline) to excape them
        if (text.Contains(",") || text.Contains("\"") || text.Contains("\n"))
        {
            text = "\"" + text.Replace("\"", "\"\"") + "\""; //escaping double quotes with replace and wraping each fiels in quotes with "\" + .... + "\"
        }
        return text;
    }

       // Parse CSV line with handling for quoted fields
    private string[] ParseCsvLine(string line)//takes a single parameter which is an iterated line of the csv file
    {
        List<string> fields = new List<string>(); //this list initialised will hold the individual fields extracted from the csv line
        bool insideQuotes = false;
        string currentField = "";

        for (int i = 0; i < line.Length; i++)// if we are using double quote we would have put"\"" cos of c# rule since we are using SINGLE quote'' no need for \
        {
            char currentChar = line[i];

            if (currentChar == '"')
            {
                if (insideQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    // Handle escaped double quotes
                    currentField += '"';
                    i++; // Skip the next quote
                }
                else
                {
                    // Toggle the insideQuotes flag
                    insideQuotes = !insideQuotes;
                }
            }
            else if (currentChar == ',' && !insideQuotes)
            {
                // End of field
                fields.Add(currentField);
                currentField = "";
            }
            else
            {
                // Add character to the current field
                currentField += currentChar;
            }
        }

        // Add the last field
        fields.Add(currentField);

        return fields.ToArray();
    }

}

//so as the for loop is iterating each character in each field(seperated by ,)of the line there are some conditions being placed here
//which is the first (1)if block that checks if the current character is == '"' if true then 
//{another condition is run checking (1.1(nested if))if the next character following that " character above is a " meaning("") 
//which means its an ESCAPE QUOTE a literal quoted text in a field being escaped by adding another double quote if true then 
//the currentfield is added a string " to the previous character that has been appended to it already and i++ incrementing the current index to skep the next quote
//an else statement of the (1.1(nested if)) that returns the insidequote to false after runing the upper nested condition}
//BUT another condition is added to the (1)if condition that checks if the current character is comma which usually indicates the end of a field in csv file format
//and the insidequote is false we add the full wordings gotten by the iterated character added to the currentfield to be append to the field list
//then an else statement of the (1)if block is made that if none of the conditions are true(the " and the comma) the current character will be added to the currentfield as the iteration goes