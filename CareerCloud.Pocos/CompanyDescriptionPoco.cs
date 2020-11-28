using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Company { set; get; }
        
        [Column("Company_Name")]
        public string CompanyName { set; get; }
        [Column("Company_Description")]
        public string CompanyDescription { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { set; get; }
        public string LanguageId { set; get; }
        public virtual CompanyProfilePoco CompanyProfile { get; set; }
        public virtual SystemLanguageCodePoco SystemLanguageCode { get; set; }
    }
}
