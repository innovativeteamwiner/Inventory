using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("UserType")]
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }

        public ICollection<LoginHistory> LoginHistories { get; set; }
    }
}
