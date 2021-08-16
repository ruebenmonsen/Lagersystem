using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lagersystem.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        public int Count { get; set; }

        private int inventoryCount;

        public int InventoryCount
        {
            get { return Price*Count; }
            set { inventoryCount = value; }
        }


    }
}
