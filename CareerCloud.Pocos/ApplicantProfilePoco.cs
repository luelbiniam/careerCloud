using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")] 
    public class ApplicantProfilePoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        [Column("Current_Salary")]
        public Decimal? CurrentSalary { set; get; }
        [Column("Current_Rate")]
        public Decimal? CurrentRate { set; get; }
        public string Currency { set; get; }
        [Column("Country_Code")]
        public string Country { set; get; }
        [Column("State_Province_Code")]
        public string Province { set; get; }
        [Column("Street_Address")]
        public string Street { set; get; }
        [Column("City_Town")]
        public string City { set; get; }
        [Column("Zip_Postal_Code")]
        public string PostalCode { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public Guid Login { set; get; }

        public virtual SecurityLoginPoco SecurityLogin { get; set; }
        public SystemCountryCodePoco SystemCountryCode { get; set; }
        public virtual ICollection<ApplicantResumePoco> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistories { get; set; }
        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }


    }
}

