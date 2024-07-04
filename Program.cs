
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
        Product n = new Product(" ", " ", " ", " ", 123, 234, 345);
        Location l = new Location("Bottom", 123, 234, 345);
        Stock stock = new Stock(l, p, 4);
        Stock tock = new Stock(l, m, 4);
        Stock ock = new Stock(l, n, 4);
        Console.WriteLine(wa.getFullAddress() + "\n" + w.Id + "\n" + w.Name + "\n" + w.Address.Postcode + "\n" + w.Longitude + "\n" + w.Lattitude);
        Console.WriteLine("stores: " + w.storeList.Count);
        s.setWarehouse(w);
        Console.WriteLine("stores: " + w.storeList.Count);
        l.setStore(s);

        stock.moveIn(4);
        Console.WriteLine(stock.TotalQuantity);
        stock.moveOut(3);
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