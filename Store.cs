namespace Hello_World
{
    public class Store
    {
        public Warehouse? Warehouse;
        public string Id;
        public string Name;
    
        public Store(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void setWarehouse(Warehouse warehouse)
        {
            Warehouse = warehouse;
        }
    }
}