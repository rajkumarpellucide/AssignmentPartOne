// See https://aka.ms/new-console-template for more information
using System.IO;

namespace AssignmentPartOne
{
    public class Program
    {
        static void Main()
        {
            // System.Console.WriteLine(args.Length);            
            Console.WriteLine("Enter your file name:- ");
            string? fileinput = Console.ReadLine();           
            Document document = new Document();
            document.FileInput(fileinput);//("123456789.2023.09.9D0A456D4237D3FF30E9EA8F228A0079.pdf");
            //123456789.aaaa.bb.9D0A456D4237D3FF30E9EA8F228A0079.pdf
            //123456789.aaaa.bb.9D0A456D4237D3FF30E9EA8F228A0079.pdf
//123456789.aaaa.02.9D0A456D4237D3FF30E9EA8F228A0079.pdf
//123456789.2005.bb.9D0A456D4237D3FF30E9EA8F228A0079.pdf
//123456789.2005.12.9D0A456D4237D3FF30E9EA8F228A0079.pdf
            // Pauses the console until the user presses enter key
            Console.ReadLine();
        }
    }
}