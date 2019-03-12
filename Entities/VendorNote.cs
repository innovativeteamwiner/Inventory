using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class VendorNote
    {

        public int Id { get; set; }
        public string Note { get; set; }

        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        public DateTime CreatedAt { get; set; }


        public Vendor Vendor { get; set; }
    }
}
