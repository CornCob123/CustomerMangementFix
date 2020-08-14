namespace CustomerManagementMVVM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        [Key]
        public int ContactCode { get; set; }

        public int CustomerCode { get; set; }

        public string ContactName { get; set; }
    }
}
