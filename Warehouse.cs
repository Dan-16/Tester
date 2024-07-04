namespace Hello_World;
public class Warehouse
{
    public int Id;
    public string Name;
    public float Longitude;
    public float Lattitude;
    public WarehouseAddress Address;
    public List<Store> storeList; 
    public Warehouse(int id, string name, float longitude, float lattitude, WarehouseAddress address)
    {
        Id = id;
        Name = name;
        Longitude = longitude;
        Lattitude = lattitude;
        Address = address;       
        storeList = new List<Store>(); 
    }
}