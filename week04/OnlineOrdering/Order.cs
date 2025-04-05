using System;
using System.Collections.Generic;

namespace ProductOrderSystem
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;
        private const double DomesticShippingCost = 5.00;
        private const double InternationalShippingCost = 35.00;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalProductCost = 0;
            foreach (var product in _products)
            {
                totalProductCost += product.GetTotalCost();
            }

            double shippingCost = _customer.IsInUSA() ? DomesticShippingCost : InternationalShippingCost;

            return totalProductCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (var product in _products)
            {
                packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{_customer.Name}\n{_customer.CustomerAddress.GetFullAddress()}";
        }
    }
}
