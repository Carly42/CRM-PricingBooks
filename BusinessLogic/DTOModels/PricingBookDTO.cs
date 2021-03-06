﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_PricingBooks.DTOModels
{
    public class PricingBookDTO
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public List<ProductPriceDTO> ProductPrices { get; set; }
    }
}
