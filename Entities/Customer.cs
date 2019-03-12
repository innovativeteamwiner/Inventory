using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public  class Customer : Persion
    {
        public DateTime RegisterDate { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
