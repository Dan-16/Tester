
namespace Hello_World;


public class Program
{
    static void Main(string[] args)
    {
        WarehouseAddress wa = new WarehouseAddress("SE1 7ND", "20 York Road", "London", "Greater London", "England", "Europe");
        Warehouse w = new Warehouse(3143, "York Road", 51.5072f, 0.1276f, wa);
        Warehouse w2 = new Warehouse(213, "blah", 3.33f, 2.333f, wa);
        Store s = new Store( "12", "Norwich");
        Product p = new Product(" ", " ", " ", " ", 123, 234, 345);
        Product m = new Product(" ", " ", " ", " ", 123, 234, 345);
        Location l = new Location("Bottom", 123, 234, 345);
        Console.WriteLine(wa.getFullAddress() + "\n" + w.Id + "\n" + w.Name + "\n" + w.Address.Postcode + "\n" + w.Longitude + "\n" + w.Lattitude);
        s.setWarehouse(w2);
        l.setStore(s);
        Console.WriteLine("Creating 4 items of stock.");
        Stock stock = new Stock(l, p, 4);
        Stock tock = new Stock(l, m, 4);
    
        Console.WriteLine("Adding 4 items of stock.");
        stock.moveIn(m, 4);
        Console.WriteLine("Stock now :");
        Console.WriteLine(stock.TotalQuantity);
        Console.WriteLine("Moving out 6 items of stock.");
        stock.moveOut(m,7);
        Console.WriteLine("Stock now :");
        Console.WriteLine(stock.TotalQuantity);

            if(s.Warehouse != null)
            {
                System.Console.WriteLine(s.Warehouse.Name);
            }
            if(l.Store != null)
            {
                System.Console.WriteLine(l.Store.Name);
            }
        
    }
}

