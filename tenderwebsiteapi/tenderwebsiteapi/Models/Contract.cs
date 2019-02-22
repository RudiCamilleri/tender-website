using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace tenderwebsiteapi.Models {
	public class Contract {
		[Key]
		public string Address { get; set; }

		public DateTime CreatedDate { get; set; }

		[NotMapped]
		public DateTime ExpiryDate { get; set; }

		[NotMapped]
		public float PerformanceGuarantee { get; set; }

		[NotMapped]
		public float MaxExtrasCost { get; set; }

		[NotMapped]
		public float PenaltyCap { get; set; }

		[NotMapped]
		public float PenaltyPerDay { get; set; }

		public int NumSmallServers { get; set; }

		public int NumMediumServers { get; set; }

		public int NumLargeServers { get; set; }

		[NotMapped]
		public string EconomicOperator { get; set; }

		public string Description { get; set; }

		public enum Status {
			Proposed = 0,
			Active = 1,
			Terminated = 2
		};

		public byte ContractStatus { get; set; }
	}
}