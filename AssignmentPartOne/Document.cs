using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentPartOne
{
    public class Document
    {
        public string? FileName;// (Stores the original file name)
        public string? BusinessNumber;// (Extracted from the file name)
        public int Year;//(Extracted from the file name)
        public int Month;// (Extracted from the file name)
        public string? ReferenceTaskId;// (Extracted from the file name)
        public string? DocumentType;//(Extracted from the file name)

        public void FileInput(string? _filenameinput)
        {
            try
            {
                if (_filenameinput == null)
                {
                    Console.WriteLine("File name is empty:", _filenameinput);
                }

                //123456789.2023.09.9D0A456D4237D3FF30E9EA8F228A0079.pdf
                string[] filedetails = _filenameinput.Split('.');
                // Validate the file format
                if (filedetails.Length != 5 || (filedetails[4] != "pdf" && filedetails[4] != "docx"))
                {
                    throw new ArgumentException("Invalid file name format. Expected format: BusinessNumber.Year.Month.ReferenceTaskId.DocumentType (e.g., 123456789.2023.09.9D0A456D4237D3FF30E9EA8F228A0079.pdf)");
                }
                if (!IsValidYearOrMonth(filedetails[1]))//year
                {
                    Console.WriteLine("The input file year wrong", _filenameinput);
                    return;
                }
                if (!IsValidYearOrMonth(filedetails[2]))//month
                {
                    Console.WriteLine("The input file month wrong", _filenameinput);
                    return;
                }

                if (filedetails[4] == "pdf" || filedetails[4] == "docx")
                {
                    
                    if (filedetails[0].Length == 9 && filedetails[1].Length == 4 && filedetails[2].Length == 2 && filedetails[3].Length == 32)
                    {

                        ShowParsedValue(_filenameinput, filedetails[0].ToString(), Convert.ToInt32(filedetails[1]), Convert.ToInt32(filedetails[2]), filedetails[3].ToString(), filedetails[4].ToString());
                    }
                    else
                    {
                        Console.WriteLine("The input file  order is wrong", _filenameinput);
                    }
                }
                else
                {
                    Console.WriteLine("Input file document type is wrong", _filenameinput);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Class:Document" + ":" + "Method:FileInput" + ":" + "Exception:", ex.Message);
            }

        }
        public void ShowParsedValue(String _fileName, String _businessNumber, int _year, int _month, String _referenceTaskId, String _documentType)
        {
            try
            {
                Console.WriteLine($"Stores the original file name: {_fileName}");
                Console.WriteLine($"BusinessNumber: {_businessNumber}");
                Console.WriteLine($"Year: {_year}");
                Console.WriteLine($"Month: {_month}");
                Console.WriteLine($"ReferenceTaskId: {_referenceTaskId}");
                Console.WriteLine($"Extracted document type: {_documentType}");
            }
            catch (Exception ex) { Console.WriteLine("Class:Document" + ":" + "Method:ShowParsedValue" + ":" + "Exception:", ex.Message); }
        }
        public static bool IsValidYearOrMonth(string input)
        {
            int value;
            if (!int.TryParse(input, out value))
            {
                return false; // Invalid input - not a number
            }
            // Check if it's a valid year

            if (value >= 1 && value <= 9999)
            {
                return true;
            }
            // Check if it's a valid month
            if (value >= 1 && value <= 12)
            {
                return true;
            }
            return false; // Not a valid year or month
        }
    }
}
