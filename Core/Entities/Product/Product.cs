using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace EcomDotNet.Entities
{
    public class Product:BaseEntity
    {
        
        public string name { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public double price { get; set; }
        public ProductType productType { get; set; }
        public long ProductTypeId { get; set; }
        public ProductBrand productBrand { get; set; }
        public long ProductBrandId { get; set; }
        
    }
}