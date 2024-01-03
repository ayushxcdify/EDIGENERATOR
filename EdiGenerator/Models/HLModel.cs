using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class HLModel
	{
		public string HierarchicalIdNumber { get; set; }
		public string HierarchicalParentIdNumber { get; set; }
		public string HierarchicalLevelCode { get; set; }
		public string HierarchicalChildCode { get; set; }
	}
}
