using EdiGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EdiGenerator.Helpers
{
	public class EDIGenerator
	{
		private int segmentCount = 0;
		private int hierarchicalidnumber = 1;


        public StringBuilder BuildEDI837()
		{
			var sb = new StringBuilder();
			var segmentHelper = new SegmentHelper();
			var isaData = new ISAModel
			{
				AuthorizationCodeQualifier = "00",
				AuthorizationCode = "          ",
				SecurityCodeQualifier = "00",
				SecurityCode = "0000057476",
				SenderIdQualifier = "ZZ",
				SenderIdentifier = "ZirMed         ",
				ReceiverIdQualifier = "ZZ",
				ReceiverIdentifier = "000000000000716",
				InterchangeDate = "231218",
				InterchangeTime = "2359",
				ControlStandardsIdentifier = "U",
				Version = "00501",
				InterchangeControlNumber = "001670385",
				AcknowledgmentRequested = "1",
				TestIndicator = "P",
				SubElementSeparator = ":"
			};
			

            segmentHelper.GeneratorISASegment(sb, isaData);

			var gsModel = new GSModel {
				FunctionalGroupIdentifier = "HC",
				ApplicationSender = "57476",
				ApplicationReceiver = "ZirMed",
				FunctionalGroupDate = "20231218",
				FunctionalGroupTime = "2359",
				FunctionalGroupControlNo = "123456",
				Agency = "X",
				Version = "005010"
			};
            
            segmentHelper.GeneratorGSSegment(sb, gsModel);

			var stData = new STModel
			{
				Type = "837",
				TransactionSetIdCode = "ABC123",
				TransSetCtrlNo = "123456"
			};
            segmentCount++;
            segmentHelper.GeneratorSTSegment(sb, stData);


			var bhtData = new BHTModel
			{
				HierarchicalStructureCode = "0019",
				TransactionSetPurposeCode = "00",
				ReferenceIdentification = "AL0072CLO",
				Date = "20230711",
				Time = "0716"
			};
            segmentCount++;
            segmentHelper.GeneratorBHTSegment(sb, bhtData);


			var refData = new REFModel
			{
				ReferenceIdentificationQualifier = "87",
				ReferenceIdentification = "004010X098A1",
				Description = ""
			};
            segmentCount++;
            segmentHelper.GeneratorREFSegment(sb, refData);

			var nm1Data = new NM1Model
			{
				EntityIdentifierCode = "41",
				EntityTypeQualifier = "2",
				NameLastOrOrganizationName = "Experity Inc",
				IdentificationCodeQualifier = "46",
                IdentificationCode = "115394"
            };
            segmentCount++;
            segmentHelper.GeneratorNM1Segment(sb, nm1Data);


			var perData = new PERModel
			{
				ContactFunctionCode = "IC",
				Name = "Billing Department",
				CommunicationQualifier = "TE",
				CommunicationNumber = "6053366962",
				CommunicationNumberQualifier = ""
			};
            segmentCount++;
            segmentHelper.GeneratorPERSegment(sb, perData);


			 nm1Data = new NM1Model
			{
				EntityIdentifierCode = "40",
				EntityTypeQualifier = "2",
				NameLastOrOrganizationName = "ZirMed",
				IdentificationCodeQualifier = "46",
				IdentificationCode = "ZirMed",
             };
            segmentCount++;
            segmentHelper.GeneratorNM1Segment(sb, nm1Data);


			var hlData = new HLModel
			{
				HierarchicalIdNumber = hierarchicalidnumber.ToString(),
				HierarchicalParentIdNumber = "",
				HierarchicalLevelCode = "20",
				HierarchicalChildCode = "1"
			};
            segmentCount++;
			hierarchicalidnumber++;
            segmentHelper.GeneratorHLSegment(sb, hlData);


			nm1Data = new NM1Model
			{
				EntityIdentifierCode = "85",
				EntityTypeQualifier = "2",
				NameLastOrOrganizationName = "Rural Urgent Care, LLC",
				IdentificationCodeQualifier = "XX",
                IdentificationCode = "1528702685",
            };
            segmentCount++;
            segmentHelper.GeneratorNM1Segment(sb, nm1Data);


			perData = new PERModel
			{
				ContactFunctionCode = "IC",
				Name = "Rural Urgent Care, LLC",
				CommunicationQualifier = "TE",
				CommunicationNumber = "2568549989",
				CommunicationNumberQualifier = ""
			};
            segmentCount++;
            segmentHelper.GeneratorPERSegment(sb, perData);


			var n3Data = new N3Model
			{
				AddressInformation1 = "1500 First Avenue North, Unit #3",
				AddressInformation2 = "Apt 101"
			};
            segmentCount++;
            segmentHelper.GeneratorN3Segment(sb, n3Data);


			var n4Data = new N4Model
			{
				CityName = "Birmingham",
				StateOrProvinceCode = "AL",
				PostalCode = "352031865",
				CountryCode = "US"
			};
            segmentCount++;
            segmentHelper.GeneratorN4Segment(sb, n4Data);


			refData = new REFModel
			{
				ReferenceIdentificationQualifier = "G5",
				ReferenceIdentification = "AL007",
				Description = ""
			};
            segmentCount++;
            segmentHelper.GeneratorREFSegment(sb, refData);


			refData = new REFModel
			{
				ReferenceIdentificationQualifier = "EI",
				ReferenceIdentification = "473524701",
				Description = ""
			};
            segmentCount++;
            segmentHelper.GeneratorREFSegment(sb, refData);


			nm1Data = new NM1Model
			{
				EntityIdentifierCode = "87",
				EntityTypeQualifier = "2",
				NameLastOrOrganizationName = "Rural Urgent Care, LLC",
				IdentificationCodeQualifier = "XX",
                IdentificationCode = "1932586476"
            };
            segmentCount++;
            segmentHelper.GeneratorNM1Segment(sb, nm1Data);


			n3Data = new N3Model
			{
				AddressInformation1 = "Department # COB1 PO BOX 830525",
				AddressInformation2 = ""
			};
            segmentCount++;
            segmentHelper.GeneratorN3Segment(sb, n3Data);


			n4Data = new N4Model
			{
				CityName = "Birmingham",
				StateOrProvinceCode = "AL",
				PostalCode = "352830525",
				CountryCode = "US"
			};
            segmentCount++;
            segmentHelper.GeneratorN4Segment(sb, n4Data);

			refData = new REFModel
			{
				ReferenceIdentificationQualifier = "EI",
				ReferenceIdentification = "473524701",
				Description = ""
			};
            segmentCount++;
            segmentHelper.GeneratorREFSegment(sb, refData);

			hlData = new HLModel
			{
				HierarchicalIdNumber = hierarchicalidnumber.ToString(),
				HierarchicalParentIdNumber = "0",
				HierarchicalLevelCode = "22",
				HierarchicalChildCode = "1"
			};
			hierarchicalidnumber++;
            segmentCount++;
            segmentHelper.GeneratorHLSegment(sb, hlData);

			var sbrData = new SBRModel
			{
				PayerResponsibilitySequenceNumberCode = "P",
				IndividualRelationshipCode = "18",
				ReferenceIdentification = "123456789"
			};
            segmentCount++;
            segmentHelper.GeneratorSBRSegment(sb, sbrData);


			nm1Data = new NM1Model
			{
				EntityIdentifierCode = "IL",
				EntityTypeQualifier = "1",
				NameLastOrOrganizationName = "RIVERO",
				NameFirst = "RIVERO",
				NamePrefix= "SUZANNE",
				IdentificationCodeQualifier = "MI",
                IdentificationCode = "XIR921527602"

            };
            segmentCount++;
            segmentHelper.GeneratorNM1Segment(sb, nm1Data);


			n3Data = new N3Model
			{
				AddressInformation1 = "41 STONELEDGE TRACE N",
				AddressInformation2 = ""
			};
            segmentCount++;
            segmentHelper.GeneratorN3Segment(sb, n3Data);


			n4Data = new N4Model
			{
				CityName = "JASPER",
				StateOrProvinceCode = "GA",
				PostalCode = "30143",
				CountryCode = "US"
			};
            segmentCount++;
            segmentHelper.GeneratorN4Segment(sb, n4Data);

			var dmgData = new DMGModel
			{
				DateTimePeriodFormatQualifier = "D8",
				DateOfBirth = "19670408",
				GenderCode = "F"
			};
            segmentCount++;
            segmentHelper.GeneratorDMGSegment(sb, dmgData);

			nm1Data = new NM1Model
			{
				EntityIdentifierCode = "PR",
				EntityTypeQualifier = "2",
				NameLastOrOrganizationName = "BCBS GA",
				IdentificationCodeQualifier = "PI",
                IdentificationCode = "SB601",
            };
            segmentCount++;
            segmentHelper.GeneratorNM1Segment(sb, nm1Data);

			refData = new REFModel
			{
				ReferenceIdentificationQualifier = "FY",
				ReferenceIdentification = "NOCD",
				Description = ""
			};
            segmentCount++;
            segmentHelper.GeneratorREFSegment(sb, refData);


			var clmDataList = ExtractClaims();
			foreach (var clmModel in clmDataList)
			{
                segmentCount++;
                segmentHelper.GeneratorCLMSegment(sb, clmModel);

                segmentCount++;
                segmentHelper.GeneratorHISegment(sb, new HIModel
				{
					HealthCareCodeInformation = "ABK:I10",
					CodeListQualifierCode = "",
					IndustryCode = ""
				});
                segmentCount++;
                segmentHelper.GeneratorLXSegment(sb, new LXModel
				{
					AssignedNumber = "1"
				});
                segmentCount++;
                segmentHelper.GeneratorSV1Segment(sb, new SV1Model
				{
					CompositeMedicalProcedureIdentifier = "HC:99213",
					MonetaryAmount = "140",
					UnitBasisMeasCode = "UN",
					ServiceUnitCount = "1",
					CopayStatusCode = "1"
				});
                segmentCount++;
                segmentHelper.GeneratorDTPSegment(sb, new DTPModel
				{
					DateTimeCode = "420",
					DateTimeQualifier = "D8",
					Date = "20151124"
				});
                segmentCount++;
                segmentHelper.GeneratorHLSegment(sb, new HLModel
				{
					HierarchicalIdNumber = hierarchicalidnumber.ToString(),
					HierarchicalParentIdNumber = "0",
					HierarchicalLevelCode = "22",
					HierarchicalChildCode = "1"
				});
				hierarchicalidnumber++;
                segmentCount++;
                segmentHelper.GeneratorNM1Segment(sb, new NM1Model
				{
					EntityIdentifierCode = "IL",
					EntityTypeQualifier = "1",
					NameLastOrOrganizationName = "BLOGGS",
					NameFirst = "FRED",
					IdentificationCodeQualifier = "MI",
                    IdentificationCode="75893251"
                });
                segmentCount++;
                segmentHelper.GeneratorN3Segment(sb, new N3Model
				{
					AddressInformation1 = "1 ANOTHER STR",
					AddressInformation2 = ""
				});
                segmentCount++;
                segmentHelper.GeneratorN4Segment(sb, new N4Model
				{
					CityName = "CHICAGO",
					StateOrProvinceCode = "IL",
					PostalCode = "606129998",
					CountryCode = "US"
				});
                segmentCount++;
                segmentHelper.GeneratorDMGSegment(sb, new DMGModel
				{
					DateTimePeriodFormatQualifier = "D8",
					DateOfBirth = "19700601",
					GenderCode = "M"
				});
                segmentCount++;
                segmentHelper.GeneratorNM1Segment(sb, new NM1Model
				{
					EntityIdentifierCode = "PR",
					EntityTypeQualifier = "2",
					NameLastOrOrganizationName = "AETNA INSURANCE COMPANY",
					IdentificationCodeQualifier = "PI",
                    IdentificationCode = "60054",
                });
                segmentCount++;
                segmentHelper.GeneratorN4Segment(sb, new N4Model
				{
					CityName = "ST LOUIS",
					StateOrProvinceCode = "MO",
					PostalCode = "212441850",
					CountryCode = "US"
				});
                segmentCount++;
                segmentHelper.GeneratorREFSegment(sb, new REFModel
				{
					ReferenceIdentificationQualifier = "2U",
					ReferenceIdentification = "W1014",
					Description = ""
				});


			}
            segmentCount++;
            segmentHelper.GeneratorSESegment(sb, new SEModel
			{
				NumberOfIncludedSegments = segmentCount.ToString(),
				TransactionSetControlNumber = "ABC123"
            });
			segmentHelper.GeneratorGESegment(sb, new GEModel
			{
				NumberOfTransactionSetsIncluded = "1",
				GroupControlNumber = "123456"
			});

			segmentHelper.GeneratorIEASegment(sb, new IEAModel
			{
				InterchangeControlNumber = "001670385",
				NumberOfIncludedGroups = "1",
			});

			return sb;
		}

		private List<CLMModel> ExtractClaims()
		{
			var claims = new List<CLMModel>();

			string[] inputVal = {
				"(87880,QW,43,1,\"1,2,3,4\")",
				"(87804A,QW,35,1,\"1,2,3,4\")",
				"(POSITIVECOVID,,0,1,\"1,2,3,4\")",
				"(PCHASOTHERPCP,,0,1,\"1,2,3,4\")",
				"(99214,,216,1,\"1,2,3,4\")",
				"(87811,QW,49,1,\"1,2,3,4\")",
				"(87804B,\"QW,59\",35,1,\"1,2,3,4\")"
			};
			foreach (var item in inputVal)
			{
				string[] values = item.Split(',');


				if (values.Length >= 5) 
				{
					var clm = new CLMModel
					{
						ClaimSubmitterIdentifier = values[0].Trim('('),
						MonetaryAmount = values[2].Trim('\"'),
						FacilityCodeValue = values[3].Trim('\"'),
						ClaimFrequencyTypeCode = values[4].Trim('\"'),
						PatientStatusCode = "57:B:1",
						DiagnosisRelatedGroupCode = "Y",
						AdmissionTypeCode = "A",
						AdmissionSourceCode = "Y",
						PatientReasonForVisit = "Y"
					};

					claims.Add(clm);
				}
			}
			return claims;
		}

	}
}
