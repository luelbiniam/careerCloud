using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{

    [Table("Company_Locations")]
    public class CompanyLocationPoco : IPoco
    {
        [Key]
        public Guid Id { set; get; }
        public Guid Company { set; get; }
        [Column("Country_Code")]
        public String CountryCode { set; get; }
        [Column("State_Province_Code")]
        public String Province { set; get; }
        [Column("Street_Address")]
        public String Street { set; get; }
        [Column("City_Town")]
        public String City { set; get; }
        [Column("Zip_Postal_Code")]
        public string PostalCode { set; get; }
        [NotMapped]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { set; get; }
        public virtual CompanyProfilePoco CompanyProfile { get; set; }

    }

        
}
