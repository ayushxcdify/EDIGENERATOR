using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class BHTModel
	{
		public string HierarchicalStructureCode { get; set; }
		public string TransactionSetPurposeCode { get; set; }
		public string ReferenceIdentification { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
	}

}
