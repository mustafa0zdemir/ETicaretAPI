using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntitiy
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Adress { get; set;}

        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}