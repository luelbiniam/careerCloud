using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Job_Applications")]
    public class ApplicantJobApplicationPoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Applicant { set; get; }
        public Guid Job { set; get; }
        [Column("Application_Date")]
        public DateTime ApplicationDate { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
        public virtual CompanyJobPoco CompanyJob { get; set; }

    }
}
