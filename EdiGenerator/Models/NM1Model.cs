using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Models
{
	public class NM1Model
	{
		public string EntityIdentifierCode { get; set; }
		public string EntityTypeQualifier { get; set; }
		public string NameLastOrOrganizationName { get; set; }
		public string NameFirst { get; set; }
		public string NameMiddle { get; set; }
		public string NamePrefix { get; set; }
		public string NameSuffix { get; set; }
		public string IdentificationCodeQualifier { get; set; }
		public string IdentificationCode { get; set; }
		public string EntityRelationshipCode { get; set; }
	}
}


//41 = Claim Creator
//40 = Claim Receiver
//85 = Billing Provider
//82 = Rendering Provider
//DN = Referring Provider
//IC = Information Contact
//77 = Service Location
//472 = Date of Service
//SY = Social Security Number
//EI = Tax ID (EIN)
//XX = NPI
//Y4 = Claim Casualty Number
//HC = Standard CPT Code
//ABK = Principal Diagnosis
//ABF = Diagnosis