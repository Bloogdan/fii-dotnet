using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelCodeFirst
{
    public partial class Product
    {
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string ProductName { get; set; }
        public decimal Stock { get; set; }
        public decimal Price { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        protected Product() { }
    }
}
