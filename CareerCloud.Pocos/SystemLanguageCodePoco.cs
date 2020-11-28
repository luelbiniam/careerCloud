using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
   [Table("System_Language_Codes")]
    public class SystemLanguageCodePoco 
    {
        [Key]
        public String LanguageID { set; get; }
        [Column("Native_Name")]
        public string NativeName { set; get; }
        public string Name { set; get; }
        public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
    }
}
