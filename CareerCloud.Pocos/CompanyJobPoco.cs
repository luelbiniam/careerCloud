using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Company { set; get; }
        [Column("Profile_Created")]
        public DateTime ProfileCreated { set; get; }
        [Column("Is_Inactive")]
        public Boolean IsInactive { set; get; }
        [Column("Is_Company_Hidden")]
        public Boolean IsCompanyHidden { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }

        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplictions { get; set; }
        public virtual ICollection<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        public virtual ICollection<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        public virtual ICollection<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        public virtual CompanyProfilePoco CompanyProfile { get; set; }



}
}
