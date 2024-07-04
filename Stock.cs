namespace Hello_World
{
    public class Stock
    {
        public Stock(Location location, Product product, int quantity)
        {
            Location = location;
            Product = product;
            TotalQuantity = quantity;
        }

        public Location Location { get; set; }
        public Product Product { get; set; }
        public int TotalQuantity { get; set; }

        public void moveIn(int quantity)
        {
            TotalQuantity = TotalQuantity+quantity;
        }

        public void moveOut(int quantity)
        {
            if (quantity > TotalQuantity)
            {
                System.Console.WriteLine("We don't have that much of this product.");
            }
            else 
            {
                TotalQuantity = TotalQuantity - quantity;
            }
        }
    }
}
