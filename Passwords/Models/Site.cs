namespace Passwords.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Site
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Site()
        {
            ChangeHistories = new HashSet<ChangeHistory>();
        }

        public int? IDSiteUserName { get; set; }

        public int IDEmail { get; set; }

        public int IDPassword { get; set; }

        public int IDAppUser { get; set; }

        public int IDSiteName { get; set; }

        public string Notes { get; set; }

        public int ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangeHistory> ChangeHistories { get; set; }

        public virtual Email Email { get; set; }

        public virtual Name Name { get; set; }

        public virtual Password Password { get; set; }

        public virtual SiteName SiteName { get; set; }

        public virtual User User { get; set; }
    }
}
