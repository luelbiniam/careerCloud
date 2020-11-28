using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Log")]
    public class SecurityLoginsLogPoco : IPoco 
    {
        [Key]
        public Guid Id { set; get; }
       
        [Column("Source_IP")]
        public String SourceIP { set; get; }
        [Column("Logon_Date")]
        public DateTime LogonDate { set; get; }
        [Column("Is_Succesful")]
        public Boolean IsSuccesful { set; get; }
        public Guid Login { set; get; }
        public SecurityLoginPoco SecurityLogins { get; set; }
    }
}
