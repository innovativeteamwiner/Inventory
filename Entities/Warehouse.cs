using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Warehouse : BaseEntity
    {
        public int AddressId { get; set; }

        [Display(Name="Admin Comment")]
        public string AdminComment { get; set; }

        public Address Address { get; set; }
    }
}
