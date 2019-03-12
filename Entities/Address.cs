using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(15)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(15)]
        public string LastName { get; set; }

        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public string Company { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }

        public string PostCode { get; set; }


        public City City { get; set; }


    }
}
