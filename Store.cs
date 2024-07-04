using System;

namespace Hello_World
{
    public class Store
    {
        public Warehouse? Warehouse;
        public string Id;
        public string Name;
        public List<Location> locationList ;

        public Store(string id, string name)
        {
            Id = id;
            Name = name;

            locationList = new List<Location>();
        }

        public void setWarehouse(Warehouse warehouse)
        {
            Warehouse = warehouse;
            Warehouse.storeList.Add(this);
        }

        
    }
}