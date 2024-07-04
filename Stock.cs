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
        public int TotalQuantity { get;set; } 
        public void moveIn(Product p, int quantity)
        {
            if(p == Product)
            {   
            TotalQuantity = TotalQuantity+quantity;
            }
            else
            {
                System.Console.WriteLine("The product your trying to move in does not match with our stock.");
            }
        }

        public void moveOut(Product p, int quantity)
        {
            if(p == Product && quantity < TotalQuantity)
            {
                TotalQuantity = TotalQuantity - quantity;
            }
            else if (quantity > TotalQuantity)
            {
                System.Console.WriteLine("We don't have that much of this product.");
            }
            else 
            {
                System.Console.WriteLine("The product your trying to move out does not match with our stock.");
            }
        }
    }
}