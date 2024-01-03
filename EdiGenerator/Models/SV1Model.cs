using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class SV1Model
	{
		public string CompositeMedicalProcedureIdentifier { get; set; }
		public string MonetaryAmount { get; set; }
		public string UnitBasisMeasCode { get; set; }
		public string ServiceUnitCount { get; set; }
		public string PlaceOfServiceCode { get; set; }
		public string CompositeDiagnosisCodePointer { get; set; }
		public string CopayStatusCode { get; set; }
		public string EmergencyIndicator { get; set; }
		public string CompositeDiagnosisCode { get; set; }
	}

}
