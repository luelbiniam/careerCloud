using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco 
    {
       [Key]
        public Guid Id { set; get; }
        public Guid Job { set; get; }
        public string Skill { set; get; }
        [Column("Skill_Level")]
        public string SkillLevel { set; get; }
        public Int32 Importance { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public virtual CompanyJobPoco CompanyJob { get; set; }



    }
}
