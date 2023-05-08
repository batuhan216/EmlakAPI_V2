﻿using EmlakAPI_V2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int ProductSize { get; set; }
        
    }
}
