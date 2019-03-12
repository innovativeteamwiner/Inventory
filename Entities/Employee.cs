using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Employee : Persion
    {

        public double Salary { get; set; }

        public DateTime HireDate { get; set; }
        public DateTime UpdatedAt { get; set; }

        
    }
}
