namespace Hello_World;
public class WarehouseAddress
  {
        public string? AddressLineOne;
        public string? AddressLineTwo;
        public string? AddressLineThree;
        public string? AddressLineFour;
        public string? AddressLineFive;
        public string? Postcode;
        public WarehouseAddress(string postcode, string addresslineone, string addresslinetwo, string addresslinethree, string addresslinefour, string addresslinefive)
        {
            Postcode = postcode;
            AddressLineOne = addresslineone;
            AddressLineTwo = addresslinetwo;
            AddressLineThree = addresslinethree;
            AddressLineFour = addresslinefour;
            AddressLineFive = addresslinefive;
        }

        public string getFullAddress()
        {
            string fullAddress = AddressLineOne+" "+AddressLineTwo+" "+AddressLineThree+" "+AddressLineFour+" "+AddressLineFive;
            return fullAddress;
        }
     }