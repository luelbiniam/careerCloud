using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Educations")]
    public class CompanyJobEducationPoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Job { set; get; }
        public String Major { set; get; }
        public Int16 Importance { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public virtual CompanyJobPoco CompanyJob { get; set; }
    }
}
