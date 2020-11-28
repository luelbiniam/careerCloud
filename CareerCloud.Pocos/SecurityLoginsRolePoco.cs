using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco :IPoco 
    {
        [Key]
        public Guid Id { set; get; }
        
        [Column ("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }
        public Guid Login { set; get; }
        public Guid Role { set; get; }
        public virtual SecurityLoginPoco SecurityLogin { get; set; }
        public virtual SecurityRolePoco SecurityRole { get; set; }

    }
}
