using EdiGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Helpers
{
	public class SegmentHelper
	{
		public void GeneratorISASegment(StringBuilder sb, ISAModel isaData)
		{
			sb.Append("ISA"); // Interchange Control Header

			var dictionary = new Dictionary<int, string>
				{
					{ 1, isaData.AuthorizationCodeQualifier },     //Authorization Information Qualifier
					{ 2, isaData.AuthorizationCode },              //Authorization Information
					{ 3, isaData.SecurityCodeQualifier },          //Security Information Qualifier
					{ 4, isaData.SecurityCode },                   //Security Information
					{ 5, isaData.SenderIdQualifier },              //Interchange ID Qualifier
					{ 6, isaData.SenderIdentifier },               //Interchange Sender ID
					{ 7, isaData.ReceiverIdQualifier },            //Interchange ID Qualifier
					{ 8, isaData.ReceiverIdentifier },             //Interchange Receiver ID
					{ 9, isaData.InterchangeDate },                //Interchange Date
					{ 10, isaData.InterchangeTime },               //Interchange Time
					{ 11, isaData.ControlStandardsIdentifier },    //Interchange Control Standards Identifier
					{ 12, isaData.Version },                       //Interchange Control Version Number
					{ 13, isaData.InterchangeControlNumber },      //Interchange Control Number
					{ 14, isaData.AcknowledgmentRequested },       //Acknowledgment Requested
					{ 15, isaData.TestIndicator },                 //Usage Indicator
					{ 16, isaData.SubElementSeparator }            //Component Element Separator
				};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorGSSegment(StringBuilder sb, GSModel gsData)
		{
			sb.Append("GS"); // Functional Group Header

			// Map GS segment properties to their respective positions
			var dictionary = new Dictionary<int, string>
				{
					{ 1, gsData.FunctionalGroupIdentifier },      //Functional Identifier Code
					{ 2, gsData.ApplicationSender },             //Application Sender's Code
					{ 3, gsData.ApplicationReceiver },           //Application Receiver's Code
					{ 4, gsData.FunctionalGroupDate },           //Date
					{ 5, gsData.FunctionalGroupTime },           //Time
					{ 6, gsData.FunctionalGroupControlNo },      //Group Control Number
					{ 7, gsData.Agency },                        //Responsible Agency Code
					{ 8, gsData.Version }                        //Version / Release / Industry Identifier Code
				};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorSTSegment(StringBuilder sb, STModel stData)
		{
			sb.Append("ST"); // Transaction Set Header

			var dictionary = new Dictionary<int, string>
			{
				{ 1, stData.Type },
				{ 2, stData.TransactionSetIdCode },     // Transaction Set Identifier Code
				{ 3, stData.TransSetCtrlNo }            // Transaction Set Control Number
			};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorBHTSegment(StringBuilder sb, BHTModel bhtData)
		{
			sb.Append("BHT"); // Beginning of Hierarchical Transaction

			// Map BHT segment properties to their respective positions
			var dictionary = new Dictionary<int, string>
			{
				{ 1, bhtData.HierarchicalStructureCode },      // Hierarchical Structure Code
				{ 2, bhtData.TransactionSetPurposeCode },      // Transaction Set Purpose Code
				{ 3, bhtData.ReferenceIdentification },        // Reference Identification
				{ 4, bhtData.Date },                           // Date
				{ 5, bhtData.Time }                            // Time
			};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorREFSegment(StringBuilder sb, REFModel refData)
		{
			sb.Append("REF"); // Reference Identification

			// Map REF segment properties to their respective positions
			var dictionary = new Dictionary<int, string>
			{
				{ 1, refData.ReferenceIdentificationQualifier },  // Reference Identification Qualifier
				{ 2, refData.ReferenceIdentification },           // Reference Identification
				{ 3, refData.Description }                        // Description
			};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorNM1Segment(StringBuilder sb, NM1Model nm1Data)
		{
			sb.Append("NM1"); // Entity Identification

			var dictionary = new Dictionary<int, string>
			{
				{ 1, nm1Data.EntityIdentifierCode },           // Entity Identifier Code
				{ 2, nm1Data.EntityTypeQualifier },            // Entity Type Qualifier
				{ 3, nm1Data.NameLastOrOrganizationName },     // Name Last or Organization Name
				{ 4, nm1Data.NameFirst },                      // Name First
				{ 5, nm1Data.NameMiddle },                     // Name Middle
				{ 6, nm1Data.NamePrefix },                     // Name Prefix
				{ 7, nm1Data.NameSuffix },                     // Name Suffix
				{ 8, nm1Data.IdentificationCodeQualifier },     // Identification Code Qualifier
				{ 9, nm1Data.IdentificationCode },             // Identification Code
				        // Entity Relationship Code
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your NM1 segment
		}

		public void GeneratorPERSegment(StringBuilder sb, PERModel perData)
		{
			sb.Append("PER"); // Contact Information

			var dictionary = new Dictionary<int, string>
			{
				{ 1, perData.ContactFunctionCode },               // Contact Function Code
				{ 2, perData.Name },                              // Name
				{ 3, perData.CommunicationQualifier },            // Communication Qualifier
				{ 4, perData.CommunicationNumber },               // Communication Number
				{ 5, perData.CommunicationNumberQualifier }       // Communication Number Qualifier
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your PER segment
		}

		public void GeneratorHLSegment(StringBuilder sb, HLModel hlData)
		{
			sb.Append("HL"); // Hierarchical Level

			var dictionary = new Dictionary<int, string>
				{
					{ 1, hlData.HierarchicalIdNumber },           // Hierarchical ID Number
					{ 2, hlData.HierarchicalParentIdNumber },     // Hierarchical Parent ID Number
					{ 3, hlData.HierarchicalLevelCode },          // Hierarchical Level Code
					{ 4, hlData.HierarchicalChildCode }           // Hierarchical Child Code
				};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your HL segment
		}


		public void GeneratorN3Segment(StringBuilder sb, N3Model n3Data)
		{
			sb.Append("N3"); // Address Information

			var dictionary = new Dictionary<int, string>
			{
				{ 1, n3Data.AddressInformation1 },     // Address Information 1
				{ 2, n3Data.AddressInformation2 }      // Address Information 2
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your N3 segment
		}

		public void GeneratorN4Segment(StringBuilder sb, N4Model n4Data)
		{
			sb.Append("N4"); // Geographic Location

			var dictionary = new Dictionary<int, string>
			{
				{ 1, n4Data.CityName },               // City Name
				{ 2, n4Data.StateOrProvinceCode },    // State or Province Code
				{ 3, n4Data.PostalCode },             // Postal Code
				{ 4, n4Data.CountryCode }             // Country Code
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your N4 segment
		}

		public void GeneratorSBRSegment(StringBuilder sb, SBRModel sbrData)
		{
			sb.Append("SBR"); // Subscriber Information

			var dictionary = new Dictionary<int, string>
			{
				{ 1, sbrData.PayerResponsibilitySequenceNumberCode }, // Payer Responsibility Sequence Number Code
				{ 2, sbrData.IndividualRelationshipCode },            // Individual Relationship Code
				{ 3, sbrData.ReferenceIdentification },                 // Reference Identification
				{ 4, "" },                                            // Add empty field (assuming not provided)
				{ 5, "" },                                            // Add empty field (assuming not provided)
				{ 6, "" },                                            // Add empty field (assuming not provided)
				{ 7, "" },                                            // Add empty field (assuming not provided)
				{ 8, "" },                                            // Add empty field (assuming not provided)
				                                                      // Add empty field (assuming not provided)
				{9, "" }              
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your SBR segment
		}

		public void GeneratorDMGSegment(StringBuilder sb, DMGModel dmgData)
		{
			sb.Append("DMG"); // Demographic Information

			var dictionary = new Dictionary<int, string>
			{
				{ 1, dmgData.DateTimePeriodFormatQualifier },   // Date/Time Period Format Qualifier
				{ 2, dmgData.DateOfBirth },                     // Date of Birth
				{ 3, dmgData.GenderCode }                       // Gender Code
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your DMG segment
		}

		public void GeneratorCLMSegment(StringBuilder sb, CLMModel clmData)
		{
			sb.Append("CLM"); // Claim Information

			var dictionary = new Dictionary<int, string>
			{
				{ 1, clmData.ClaimSubmitterIdentifier },       // Claim Submitter Identifier
				{ 2, clmData.MonetaryAmount },                 // Monetary Amount
				{ 3, clmData.FacilityCodeValue },             // Facility Code Value
				{ 4, clmData.ClaimFrequencyTypeCode },         // Claim Frequency Type Code
				{ 5, clmData.PatientStatusCode },              // Patient Status Code
				{ 6, clmData.DiagnosisRelatedGroupCode },      // Diagnosis Related Group Code
				{ 7, clmData.AdmissionTypeCode },              // Admission Type Code
				{ 8, clmData.AdmissionSourceCode },            // Admission Source Code
				{ 9, clmData.PatientReasonForVisit }           // Patient Reason for Visit
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your CLM segment
		}

		public void GeneratorHISegment(StringBuilder sb, HIModel hiData)
		{
			sb.Append("HI"); // Health Care Diagnosis Code

			var dictionary = new Dictionary<int, string>
			{
				{ 1, hiData.HealthCareCodeInformation },  // Health Care Code Information
				{ 2, hiData.CodeListQualifierCode },      // Code List Qualifier Code
				{ 3, hiData.IndustryCode }                // Industry Code
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your HI segment
		}

		public void GeneratorSV1Segment(StringBuilder sb, SV1Model sv1Data)
		{
			sb.Append("SV1"); // Professional Service

			var dictionary = new Dictionary<int, string>
			{
				{ 1, sv1Data.CompositeMedicalProcedureIdentifier }, // Composite Medical Procedure Identifier
				{ 2, sv1Data.MonetaryAmount },                     // Monetary Amount
				{ 3, sv1Data.UnitBasisMeasCode },                 // Unit or Basis for Measurement Code
				{ 4, sv1Data.ServiceUnitCount },                  // Service Unit Count
				{ 5, sv1Data.PlaceOfServiceCode },                // Place of Service Code
				{ 6, sv1Data.CompositeDiagnosisCodePointer },     // Composite Diagnosis Code Pointer
				{ 7, sv1Data.CopayStatusCode },                   // Copay Status Code
				{ 8, sv1Data.EmergencyIndicator },                // Emergency Indicator
				{ 9, sv1Data.CompositeDiagnosisCode }             // Composite Diagnosis Code
			};

			GenerateSegment(sb, dictionary); // Adjust the count based on the number of fields in your SV1 segment
		}

		public void GeneratorLXSegment(StringBuilder sb, LXModel lxData)
		{
			sb.Append("LX"); // Transaction Set Line Number

			var dictionary = new Dictionary<int, string>
			{
				{ 1, lxData.AssignedNumber } // Assigned Number
			};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorDTPSegment(StringBuilder sb, DTPModel dtpData)
		{
			sb.Append("DTP"); // Date or Time Period

			var dictionary = new Dictionary<int, string>
			{
				{ 1, dtpData.DateTimeCode }, // Date/Time Code
				{ 2, dtpData.DateTimeQualifier }, // Date/Time Qualifier
				{ 3, dtpData.Date }               // Date
			};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorSESegment(StringBuilder sb, SEModel seData)
		{
			sb.Append("SE"); // Transaction Set Trailer

			var dictionary = new Dictionary<int, string>
			{
				{ 1, seData.NumberOfIncludedSegments },        // Number of Included Segments
				{ 2, seData.TransactionSetControlNumber }      // Transaction Set Control Number
			};

			GenerateSegment(sb, dictionary);
		}

		public void GeneratorGESegment(StringBuilder sb, GEModel geData)
		{
			sb.Append("GE"); // Functional Group Trailer

			var dictionary = new Dictionary<int, string>
			{
				{ 1, geData.NumberOfTransactionSetsIncluded }, // Number of Transaction Sets Included
				{ 2, geData.GroupControlNumber }               // Group Control Number
			};

			GenerateSegment(sb, dictionary);
		}


		public void GeneratorIEASegment(StringBuilder sb, IEAModel ieaData)
		{
			sb.Append("IEA"); // Interchange Control Trailer

			var dictionary = new Dictionary<int, string>
			{
				{ 1, ieaData.NumberOfIncludedGroups },       // Number of Included Functional Groups
				{ 2, ieaData.InterchangeControlNumber }      // Interchange Control Number
			};

			GenerateSegment(sb, dictionary);

		}

		private void GenerateSegment(StringBuilder sb, Dictionary<int, string> dictionary)
		{
			sb.Append(dictionary.First().Key == 1 ? "*" + dictionary.First().Value : "");
			for (int i = 2; i <= dictionary.Count; i++)
			{
				sb.Append("*" + (dictionary.ContainsKey(i) == true ? dictionary[i] : ""));
			}
			sb.AppendLine("~");
		}

	}
}
