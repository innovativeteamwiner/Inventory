using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class LoginHistory
    {
        public int Id { get; set; }
        public DateTime LastLogin { get; set; }
        public string LastLogInId { get; set; }
        public string IpAddress { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
