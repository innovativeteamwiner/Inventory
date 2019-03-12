using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Product : BaseEntity
    {
    #region Properties

        public string Description { get; set; }
        public string AdminComment { get; set; }
        public bool IsPublished { get; set; }
        public bool IsNewProduct { get; set; }
        public bool IsFreeShipping { get; set; }
        public bool IsAproved { get; set; }
        public bool IsReturnAble { get; set; }
        public string ItemCode { get; set; }
        public string SKU { get; set; }
        public Double Price { get; set; }
        public double OldPrice { get; set; }
        public double ProductCost { get; set; }
        public int Quantity { get; set; }

        public double Weight { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int DisplayOrder { get; set; }


        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ProductExpareDate { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    #endregion 
/*
    #region Navigation Property
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        [ForeignKey("ProductTypeId")]
        public int ProductTypeId { get; set; }



        public Vendor Vendor { get; set; }
        public Vendor Vendor { get; set; }
        #endregion

*/
    }
}
