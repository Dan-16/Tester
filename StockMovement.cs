using System;

namespace Hello_World
{
    public class StockMovement
    {
        public StockMovement(Product product, int quantity, Location? from, Location? to)
        {
            Created = DateTime.Now;
            Quantity = quantity;
            Product = product;
            FromLocation = from;
            ToLocation = to;

            // move stock out of a loc
            // move stock into another loc
        }

        public DateTime Created { get; set; }
        public Location? FromLocation { get; set; }
        public Location? ToLocation { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}