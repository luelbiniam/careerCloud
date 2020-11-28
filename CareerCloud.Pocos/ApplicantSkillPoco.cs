using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Skills")]
    public class ApplicantSkillPoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Applicant { set; get; }
        public String Skill { set; get; }
        [Column("Skill_Level")]
        public String SkillLevel { set; get; }
        [Column("Start_Month")]
        public Byte StartMonth { set; get; }
        [Column("Start_Year")]
        public Int32 StartYear { set; get; }
        [Column("End_Month")]
        public Byte EndMonth { set; get; }
        [Column("End_Year")]
        public Int32 EndYear { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { set; get; }
        [NotMapped]
        public virtual ApplicantProfilePoco ApplicantProfile { get; set; }


    }
}
