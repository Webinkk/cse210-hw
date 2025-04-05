namespace ProductOrderSystem
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        public string Street 
        { 
            get { return _street; } 
            private set { _street = value; }
        }

        public string City 
        { 
            get { return _city; }
            private set { _city = value; }
        }

        public string State 
        { 
            get { return _state; }
            private set { _state = value; }
        }

        public string Country 
        { 
            get { return _country; }
            private set { _country = value; }
        }

        public bool IsInUSA()
        {
            return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public string GetFullAddress()
        {
            return $"{_street}\n{_city}, {_state}\n{_country}";
        }
    }
}
