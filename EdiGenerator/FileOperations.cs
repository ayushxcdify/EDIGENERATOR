using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator
{
	public class FileOperations
	{
		public void SaveStringBuilderToFile(StringBuilder content, string filePath)
		{
			try
			{
				// Write the content of the StringBuilder to the specified file
				File.WriteAllText(filePath, content.ToString());
				Console.WriteLine("Content saved to file successfully!");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error occurred while saving content to file: {ex.Message}");
				// Handle exception as needed
			}
		}
	}
}
