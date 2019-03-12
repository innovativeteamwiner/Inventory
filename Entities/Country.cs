using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Country : BaseEntity
    {
        public ICollection<City> Cities { get; set; }
    }
}
