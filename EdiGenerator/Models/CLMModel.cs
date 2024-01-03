using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class CLMModel
	{
		public string ClaimSubmitterIdentifier { get; set; }
		public string MonetaryAmount { get; set; }
		public string FacilityCodeValue { get; set; }
		public string ClaimFrequencyTypeCode { get; set; }
		public string PatientStatusCode { get; set; }
		public string DiagnosisRelatedGroupCode { get; set; }
		public string AdmissionTypeCode { get; set; }
		public string AdmissionSourceCode { get; set; }
		public string PatientReasonForVisit { get; set; }
	}
}
