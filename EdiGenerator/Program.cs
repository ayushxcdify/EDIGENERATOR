using EdiGenerator;
using EdiGenerator.Helpers;
using EdiGenerator.Models;
using System.Data;
using System.Text;

class Program
{
	static async Task Main(string[] args)
	{

		Console.WriteLine("....................Generating EDI .................................");

		var ediGenerator = new EDIGenerator();
		var dic = new Dictionary<string, string>();
		dic.Add("InvoiceDate", DateTime.Now.ToString());

		string filePath = "C:\\Codebase\\837.edi"; // Provide the file path where you want to save the content

		FileOperations fileOps = new FileOperations();
		var sb = new EDIGenerator().BuildEDI837();
		fileOps.SaveStringBuilderToFile(sb, filePath);
	}

	
}