using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Manufacturer : BaseEntity
    {
        public string Description { get; set; }
        public int DisplayOrder { get; set; }

        [ForeignKey("Picture")]
        public int PictureId { get; set; }
        
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Picture Picture { get; set; }

    }
}
