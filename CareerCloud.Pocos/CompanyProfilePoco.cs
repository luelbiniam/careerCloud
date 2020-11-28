using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco :IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        [Column("Registration_Date")]
        public DateTime RegistrationDate { set; get; }
        [Column ("Company_Website")]
        public String CompanyWebsite { set; get; }
        [Column("Contact_Phone")]
        public String ContactPhone { set; get; }
        [Column("Contact_Name")]
        public String ContactName { set; get; }
        [Column("Company_Logo")]
        public Byte [] CompanyLogo { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        public virtual ICollection<CompanyJobPoco> CompanyJobs { get; set; }
        public virtual ICollection<CompanyLocationPoco> CompanyLocations { get; set; }






    }
}
