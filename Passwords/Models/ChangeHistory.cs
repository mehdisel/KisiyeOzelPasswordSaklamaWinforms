namespace Passwords.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChangeHistory")]
    public partial class ChangeHistory
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string OldName { get; set; }

        [StringLength(50)]
        public string NewName { get; set; }

        [StringLength(320)]
        public string OldMail { get; set; }

        [StringLength(320)]
        public string NewMail { get; set; }

        [StringLength(50)]
        public string OldPassword { get; set; }

        [StringLength(50)]
        public string NewPassword { get; set; }

        public int IDSites { get; set; }

        public DateTime IslemTarihi { get; set; }

        public int IDType { get; set; }

        public virtual RecordType RecordType { get; set; }

        public virtual Site Site { get; set; }
    }
}
