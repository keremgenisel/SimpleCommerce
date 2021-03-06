﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCommerce.Models
{
    public class Region
    {
        public int Id { get; set; } 
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentRegionId { get; set; }
        [ForeignKey("ParentRegionId")]
        public Region ParentRegion { get; set; }
        public RegionType RegionType { get; set; }
    }
}
