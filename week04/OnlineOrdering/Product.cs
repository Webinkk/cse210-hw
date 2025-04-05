namespace ProductOrderSystem
{
    public class Product
    {
        private string _name;
        private int _productId;
        private double _price;
        private int _quantity;

        public Product(string name, int productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        public string Name 
        { 
            get { return _name; }
            private set { _name = value; }
        }

        public int ProductId 
        { 
            get { return _productId; }
            private set { _productId = value; }
        }

        public double Price 
        { 
            get { return _price; }
            private set { _price = value; }
        }

        public int Quantity 
        { 
            get { return _quantity; }
            private set { _quantity = value; }
        }

        public double GetTotalCost()
        {
            return _price * _quantity;
        }
    }
}
