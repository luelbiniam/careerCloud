using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Applicant { set; get; }
        public string Resume { set; get; }
        [Column("Last_Updated")]
        public DateTime? LastUpdated { set; get; }
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }


    }
}
