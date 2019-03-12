using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class City : BaseEntity
    {
        public Country Country { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
    }
}
