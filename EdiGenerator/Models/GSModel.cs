using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class GSModel
	{
		public string FunctionalGroupIdentifier { get; set; }
		public string ApplicationSender { get; set; }
		public string ApplicationReceiver { get; set; }
		public string FunctionalGroupDate { get; set; }
		public string FunctionalGroupTime { get; set; }
		public string FunctionalGroupControlNo { get; set; }
		public string Agency { get; set; }
		public string Version { get; set; }
	}

}
