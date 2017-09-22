using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StewardMaster.Models
{
    public class StewardEnquiryModel
    {
        [DisplayName("Number of tickets")]
        [Required]
        public int NumberOfTickets { get; set; }

        [DisplayName("Stewards (S1)")]
        public int ContractS1Count { get; set; }

        [DisplayName("Supervisors (S3)")]
        public int ContractS3Count { get; set; }

        [DisplayName("Stewards (S1)")]
        public int NonContractS1Count { get; set; }

        [DisplayName("Supervisors (S3)")]
        public int NonContractS3Count { get; set; }

        [DisplayName("Total (S1)")]
        public int TotalS1Count { get { return ContractS1Count + NonContractS1Count; } }

        [DisplayName("Total (S3)")]
        public int TotalS3Count { get { return ContractS3Count + NonContractS3Count; } }
    }
}