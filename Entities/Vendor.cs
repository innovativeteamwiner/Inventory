using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Vendor : BaseEntity
    {
        public string Description { get; set; }

        [Display(Name="Admin Comment")]
        public string AdminComment { get; set; }

        public bool IsActive { get; set; }
        public int DisplayOrder { get; set; }


        [ForeignKey("Picture")]
        public int PictureId { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }

        public Picture Picture { get; set; }

        public Address Address { get; set; }
    }
}
