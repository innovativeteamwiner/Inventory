using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CustomerRole : BaseEntity
    {
        public bool IsFreeshipping { get; set; }
        public bool IsActive { get; set; }
    }
}
