using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCodeFirst
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public int Payed { get; set; }
        public decimal Value { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        protected Order() { }
    }
}
