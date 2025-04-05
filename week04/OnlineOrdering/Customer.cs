namespace ProductOrderSystem
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        public string Name 
        { 
            get { return _name; }
            private set { _name = value; }
        }

        public Address CustomerAddress 
        { 
            get { return _address; }
            private set { _address = value; }
        }

        public bool IsInUSA()
        {
            return _address.IsInUSA();
        }
    }
}
