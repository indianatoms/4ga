using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Simple
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is C#");
            

            var fileStream = new FileStream(@"C:\Users\PC\source\repos\ConsoleApp8\ConsoleApp8\new1.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line, newLine;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //single line
                    List<string> words = line.Split(' ').ToList<string>();
               

                    newLine = String.Concat('"',words[0],".cs-SD-", FirstLetterToUpper(words[2]), FirstLetterToUpper(words[3]), FirstLetterToUpper(words[4]),'"',words[1],' ','"');
                    words.RemoveRange(0, 2);
                    foreach (var word in words)
                    {
                        newLine += word + ' ';
                        
                    }
                    newLine = newLine.Remove(newLine.Length - 1);
                    newLine += '"';
                    Console.WriteLine(newLine);
                }
            }
            System.Threading.Thread.Sleep(30000);
        }

        static public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }
    }


}
