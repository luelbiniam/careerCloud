using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginPoco :IPoco 
    {
        [Key]
        public Guid Id { set; get; }

        [Column("Created_Date")]
        public DateTime Created { set; get; }
        [Column("Password_Update_Date")]
        public DateTime? PasswordUpdate { set; get; }
        [Column("Agreement_Accepted_Date")]
        public DateTime? AgreementAccepted { set; get; }
        [Column ("Is_Locked")]
        public Boolean IsLocked { set; get; }
        [Column("Is_Inactive")]
        public Boolean IsInactive { set; get; }
        [Column("Email_Address")]
        public string EmailAddress { set; get; } 
        [Column("Phone_Number")]
        public string PhoneNumber { set; get; }
        [Column("Full_Name")]
        public string FullName { set; get; }
        [Column("Force_Change_Password")]
        public Boolean ForceChangePassword { set; get; }
        [Column("Prefferred_Language")]
        public string PrefferredLanguage { set; get; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte [] TimeStamp { set; get; }

        public String Login { set; get; }
        public String Password { set; get; }
        public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        public virtual ICollection<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        public virtual ICollection<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }








    }
}
