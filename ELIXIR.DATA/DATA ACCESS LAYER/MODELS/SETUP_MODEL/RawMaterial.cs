﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIR.DATA.DATA_ACCESS_LAYER.MODELS.SETUP_MODEL
{
    public class RawMaterial : BaseEntity
    {
 //       [Required(ErrorMessage = "Item Code is Required!")]
        public string ItemCode { get; set; }

  //      [Required(ErrorMessage = "Item Description is Required!")]
        public string ItemDescription { get; set; }

        public ItemCategory ItemCategory { get; set; }
        public int ItemCategoryId { get; set; }
        public UOM UOM { get; set; }
        public int UomId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BufferLevel { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
        public bool IsActive { get; set; }
        public string Reason { get; set; }


    }
}
