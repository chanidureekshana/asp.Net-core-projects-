using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models

{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get;set; }
        public string Description { get; set; }
        public ICollection<ProductModel> Products { get; set; }
    }
}