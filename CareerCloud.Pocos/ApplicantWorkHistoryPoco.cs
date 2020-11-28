using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco : IPoco 
    {
     [Key]
        public Guid Id { set; get; }
        public Guid Applicant { set; get; }
        [Column("Company_Name")]
        public String CompanyName { set; get; }
        [Column("Country_Code")]
        public string CountryCode { set; get; }
        public String Location { set; get; }
        [Column("Job_Title")]
        public String JobTitle { set; get; }
        [Column("Job_Description")]
        public String JobDescription { set; get; }
        [Column("Start_Month")]
        public Int16 StartMonth { set; get; }
        [Column("Start_Year")]
        public Int32 StartYear { set; get; }
        [Column("End_Month")]
        public Int16 EndMonth { set; get; }
        [Column("End_Year")]
        public Int32 EndYear { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }
        public virtual SystemCountryCodePoco SystemCountryCode { get; set; }


    }
}
