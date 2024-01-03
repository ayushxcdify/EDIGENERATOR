using EdiGenerator.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class ISAModel
	{
		public string AuthorizationCodeQualifier { get; set; }
		public string AuthorizationCode { get; set; }
		public string SecurityCodeQualifier { get; set; }
		public string SecurityCode { get; set; }
		public string SenderIdQualifier { get; set; }
		public string SenderIdentifier { get; set; }
		public string ReceiverIdQualifier { get; set; }
		public string ReceiverIdentifier { get; set; }
		public string InterchangeDate { get; set; }
		public string InterchangeTime { get; set; }
		public string ControlStandardsIdentifier { get; set; }
		public string Version { get; set; }
		public string InterchangeControlNumber { get; set; }
		public string AcknowledgmentRequested { get; set; }
		public string TestIndicator { get; set; }
		public string SubElementSeparator { get; set; }
	}

}
